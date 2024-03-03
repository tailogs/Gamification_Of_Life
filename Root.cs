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
                MessageBox.Show("������� ������ � ������� ���� � ������!", "������");
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
            return "�������: " + level + " | ����: " + exp + "/" + needExp;
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
                // �������� ����� � ������ ������ � ����
                using (StreamWriter writer = new StreamWriter("userData.txt"))
                {
                    writer.WriteLine("Level: " + level);
                    writer.WriteLine("Experience: " + exp);
                    writer.WriteLine("Need experience: " + needExp);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("������ ���������� ���������������� ������! " + e, "������");
            }
        }

        private void readData()
        {
            try
            {
                // ������ ����� � ���������� ������ � ����������
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
                MessageBox.Show("���� ��� ������ ���������������� ������ �� ������! " + e, "������");
            }
            catch (IOException e)
            {
                MessageBox.Show("������ ������ ���������������� ������! " + e, "������");
            }
        }

        private void saveTodo()
        {
            try
            {
                // �������� ����� � ������ ������ � ����
                using (StreamWriter writer = new StreamWriter("userTodo.txt"))
                {
                    for (int i = 0; i < tasks.Count; i++)
                        writer.WriteLine(tasks[i] + " : " + tasksExp[i]);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("������ ���������� ������ �����! " + e, "������");
            }
        }

        private void readTodo()
        {
            try
            {
                // ������ ����� � ���������� ������ � ����������
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
                MessageBox.Show("���� ��� ������ ������ ����� �� ������! " + e, "������");
            }
            catch (IOException e)
            {
                MessageBox.Show("������ ������ ������ �����! " + e, "������");
            }
        }

        private void saveLogs(String _tasks, String _exp)
        {
            DateTime now = DateTime.Now;
            try
            {
                // �������� ����� � ������ ������ � ����
                using (StreamWriter writer = new StreamWriter("userLogs.txt", true))
                {
                    writer.WriteLine(_tasks + " : " + _exp + " : " + now.ToString("dd.MM.yyyy") + " : " + now.ToString("HH:mm:ss"));
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("������ ���������� �����! " + e, "������");
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
            if (!File.Exists("userData.txt")) // ���������, ���������� �� ����
                File.Create("userData.txt"); // ������� ����� ����

            if (!File.Exists("userTodo.txt")) // ���������, ���������� �� ����
                File.Create("userTodo.txt"); // ������� ����� ����

            if (!File.Exists("userLogs.txt")) // ���������, ���������� �� ����
                File.Create("userLogs.txt"); // ������� ����� ����

            readData();
            readTodo();
            lblLvl.Text = getLvlAndExperience();
        }

        private void Root_Load(object sender, EventArgs e)
        {
            startProgram();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Achievements achievements = new Achievements();
            achievements.ShowDialog();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            progress.ShowDialog();
        }
    }
}