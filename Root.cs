using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gamification_Of_Life
{
    public partial class Root : Form
    {
        private int level = 0, exp = 0, needExp = 500;
        private List<string> tasks = new List<string>();
        private List<int> tasksExp = new List<int>();

        public Root()
        {
            InitializeComponent();
            startProgram();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAddTask.Text) && textBoxAddExp.Text.All(char.IsDigit))
            {
                tasks.Add(textBoxAddTask.Text);
                textBoxAddTask.Text = "";
                tasksExp.Add(int.Parse(textBoxAddExp.Text));
                textBoxAddExp.Text = "";
                updateListBox();
                saveTodo();
            }
            else
                MessageBox.Show("Введите задачу и укажите опыт в цифрах!", "Ошибка");
        }

        private void btnDelTask_Click(object sender, EventArgs e)
        {
            int number = listBoxTasks.SelectedIndex;
            if (number != -1)
            {
                tasks.RemoveAt(number);
                tasksExp.RemoveAt(number); // Change from Remove to RemoveAt
                updateListBox();
                saveTodo();
            }
        }

        private void btnDoneTask_Click(object sender, EventArgs e)
        {
            int number = listBoxTasks.SelectedIndex;
            if (number != -1)
            {
                setLvlAndExperience(tasksExp[number]);
                saveLogs(tasks[number], tasksExp[number].ToString());
                tasks.RemoveAt(number);
                tasksExp.RemoveAt(number);
                lblLvl.Text = getLvlAndExperience();
                updateListBox();
                saveData();
                saveTodo();
            }
        }

        private String getLvlAndExperience()
        {
            return "Уровень: " + level + " | Опыт: " + exp + "/" + needExp;
        }

        private void setLvlAndExperience(int _exp)
        {
            exp += _exp;
            while (exp >= needExp)
            {
                level++;
                exp = exp - needExp;
                needExp = needExp + (needExp / level);
            }
        }

        private void saveData()
        {
            try
            {
                // Создание файла и запись строки в него
                using (StreamWriter writer = new StreamWriter("userData.txt"))
                {
                    writer.WriteLine("Level: " + level);
                    writer.WriteLine("Experience: " + exp);
                    writer.WriteLine("Need experience: " + needExp);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Ошибка сохранения пользовательских данных! " + e, "Ошибка");
            }
        }

        private void readData()
        {
            try
            {
                // Чтение файла и сохранения данных в переменные
                using (StreamReader reader = new StreamReader("userData.txt"))
                {
                    string line;
                    if ((line = reader.ReadLine()) != null)
                        level = Convert.ToInt32(line.Split(": ")[1]);
                    if ((line = reader.ReadLine()) != null)
                        exp = Convert.ToInt32(line.Split(": ")[1]);
                    if ((line = reader.ReadLine()) != null)
                        needExp = Convert.ToInt32(line.Split(": ")[1]);
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Файл для чтения пользовательских данных не найден! " + e, "Ошибка");
            }
            catch (IOException e)
            {
                MessageBox.Show("Ошибка чтения пользовательских данных! " + e, "Ошибка");
            }
        }

        private void saveTodo()
        {
            try
            {
                // Создание файла и запись строки в него
                using (StreamWriter writer = new StreamWriter("userTodo.txt"))
                {
                    for (int i = 0; i < tasks.Count; i++)
                        writer.WriteLine(tasks[i] + " : " + tasksExp[i]);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Ошибка сохранения списка задач! " + e, "Ошибка");
            }
        }

        private void readTodo()
        {
            try
            {
                // Чтение файла и сохранения данных в переменные
                using (StreamReader reader = new StreamReader("userTodo.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] str = line.Split(" : ");
                        tasks.Add(str[0]);
                        tasksExp.Add(Convert.ToInt32(str[1]));
                        updateListBox();
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Файл для чтения списка задач не найден! " + e, "Ошибка");
            }
            catch (IOException e)
            {
                MessageBox.Show("Ошибка чтения списка задач! " + e, "Ошибка");
            }
        }

        private void saveLogs(String _tasks, String _exp)
        {
            DateTime now = DateTime.Now;
            try
            {
                // Создание файла и запись строки в него
                using (StreamWriter writer = new StreamWriter("userLogs.txt", true))
                {
                    writer.WriteLine(_tasks + " : " + _exp + " : " + now.ToString("dd.MM.yyyy") + " : " + now.ToString("HH:mm:ss"));
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Ошибка сохранения логов! " + e, "Ошибка");
            }
        }

        private void updateListBox()
        {
            listBoxTasks.Items.Clear();
            listBoxExp.Items.Clear();
            for (int i = 0; i < tasks.Count; i++)
            {
                listBoxTasks.Items.Add(tasks[i]);
                listBoxExp.Items.Add(tasksExp[i]);
            }
        }

        private void startProgram()
        {
            if (!File.Exists("userData.txt")) // Проверяем, существует ли файл
                File.Create("userData.txt"); // Создаем новый файл

            if (!File.Exists("userTodo.txt")) // Проверяем, существует ли файл
                File.Create("userTodo.txt"); // Создаем новый файл

            if (!File.Exists("userLogs.txt")) // Проверяем, существует ли файл
                File.Create("userLogs.txt"); // Создаем новый файл

            readData();
            readTodo();
            lblLvl.Text = getLvlAndExperience();
        }

        private void Root_Load(object sender, EventArgs e)
        {
            startProgram();
        }

        private void достиженияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Achievements achievements = new Achievements();
            achievements.ShowDialog();
        }

        private void прогрессToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            progress.ShowDialog();
        }
    }
}