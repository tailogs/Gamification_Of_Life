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
    public partial class Achievements : Form
    {
        public Achievements()
        {
            InitializeComponent();
        }

        private void Achievements_Load(object sender, EventArgs e)
        {
            int taskDone = 0;
            using (StreamReader reader = new StreamReader("userLogs.txt"))
            {
                while (reader.ReadLine() != null)
                    taskDone++;
            }
            if (taskDone >= 100)
                pictureBox100Tasks.Visible = true;
            if (taskDone >= 250)
                pictureBox250Tasks.Visible = true;
            if (taskDone >= 500)
                pictureBox500Tasks.Visible = true;
            if (taskDone >= 1000)
                pictureBox1000Tasks.Visible = true;

            int lvl = 0;
            using (StreamReader reader = new StreamReader("userData.txt"))
            {
                string line;
                if ((line = reader.ReadLine()) != null)
                    lvl = Convert.ToInt32(line.Split(": ")[1]);
            }
            if (lvl >= 10)
                pictureBox10LVL.Visible = true;
            if (lvl >= 20)
                pictureBox20LVL.Visible = true;
            if (lvl >= 30)
                pictureBox30LVL.Visible = true;
            if (lvl >= 40)
                pictureBox40LVL.Visible = true;
        }
    }
}
