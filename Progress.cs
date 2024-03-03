using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gamification_Of_Life
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        private void Progress_Load(object sender, EventArgs e)
        {
            int taskDone = 0;
            using (StreamReader reader = new StreamReader("userLogs.txt"))
            {
                while (reader.ReadLine() != null)
                    taskDone++;
            }
            lblTasksDone.Text = "Количество выполненных задач: " + taskDone;

            int lvl = 0;
            using (StreamReader reader = new StreamReader("userData.txt"))
            {
                string line;
                if ((line = reader.ReadLine()) != null)
                    lvl = Convert.ToInt32(line.Split(": ")[1]);
            }
            lblLvl.Text = "Уровень: " + lvl;
        }
    }
}
