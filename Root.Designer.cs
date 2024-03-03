namespace Gamification_Of_Life
{
    partial class Root
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Root));
            lblLvl=new Label();
            listBoxTasks=new ListBox();
            listBoxExp=new ListBox();
            textBoxAddTask=new TextBox();
            lblTasks=new Label();
            lblExp=new Label();
            lblAddTask=new Label();
            lblAddExp=new Label();
            textBoxAddExp=new TextBox();
            btnAddTask=new Button();
            btnDelTask=new Button();
            btnDoneTask=new Button();
            menuStripTop=new MenuStrip();
            дополнительныеОкнаToolStripMenuItem=new ToolStripMenuItem();
            достиженияToolStripMenuItem=new ToolStripMenuItem();
            прогрессToolStripMenuItem=new ToolStripMenuItem();
            menuStripTop.SuspendLayout();
            SuspendLayout();
            // 
            // lblLvl
            // 
            lblLvl.AutoSize=true;
            lblLvl.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLvl.ForeColor=SystemColors.ControlLight;
            lblLvl.Location=new Point(8, 35);
            lblLvl.Name="lblLvl";
            lblLvl.Size=new Size(222, 25);
            lblLvl.TabIndex=0;
            lblLvl.Text="Уровень: 0 | Опыт: 0/500";
            // 
            // listBoxTasks
            // 
            listBoxTasks.BackColor=Color.BlueViolet;
            listBoxTasks.BorderStyle=BorderStyle.None;
            listBoxTasks.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxTasks.ForeColor=SystemColors.ControlLight;
            listBoxTasks.FormattingEnabled=true;
            listBoxTasks.ItemHeight=25;
            listBoxTasks.Location=new Point(12, 91);
            listBoxTasks.Name="listBoxTasks";
            listBoxTasks.Size=new Size(330, 400);
            listBoxTasks.TabIndex=1;
            // 
            // listBoxExp
            // 
            listBoxExp.BackColor=Color.BlueViolet;
            listBoxExp.BorderStyle=BorderStyle.None;
            listBoxExp.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxExp.ForeColor=SystemColors.ControlLight;
            listBoxExp.FormattingEnabled=true;
            listBoxExp.ItemHeight=25;
            listBoxExp.Location=new Point(355, 91);
            listBoxExp.Name="listBoxExp";
            listBoxExp.Size=new Size(117, 400);
            listBoxExp.TabIndex=2;
            // 
            // textBoxAddTask
            // 
            textBoxAddTask.BackColor=Color.BlueViolet;
            textBoxAddTask.BorderStyle=BorderStyle.None;
            textBoxAddTask.Cursor=Cursors.IBeam;
            textBoxAddTask.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddTask.ForeColor=SystemColors.ControlLight;
            textBoxAddTask.Location=new Point(12, 519);
            textBoxAddTask.Name="textBoxAddTask";
            textBoxAddTask.Size=new Size(460, 25);
            textBoxAddTask.TabIndex=3;
            // 
            // lblTasks
            // 
            lblTasks.AutoSize=true;
            lblTasks.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTasks.ForeColor=SystemColors.ControlLight;
            lblTasks.Location=new Point(22, 67);
            lblTasks.Name="lblTasks";
            lblTasks.Size=new Size(62, 21);
            lblTasks.TabIndex=4;
            lblTasks.Text="Задачи";
            // 
            // lblExp
            // 
            lblExp.AutoSize=true;
            lblExp.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExp.ForeColor=SystemColors.ControlLight;
            lblExp.Location=new Point(365, 67);
            lblExp.Name="lblExp";
            lblExp.Size=new Size(49, 21);
            lblExp.TabIndex=5;
            lblExp.Text="Опыт";
            // 
            // lblAddTask
            // 
            lblAddTask.AutoSize=true;
            lblAddTask.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddTask.ForeColor=SystemColors.ControlLight;
            lblAddTask.Location=new Point(22, 494);
            lblAddTask.Name="lblAddTask";
            lblAddTask.Size=new Size(132, 21);
            lblAddTask.TabIndex=6;
            lblAddTask.Text="Добавить задачу";
            // 
            // lblAddExp
            // 
            lblAddExp.AutoSize=true;
            lblAddExp.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddExp.ForeColor=SystemColors.ControlLight;
            lblAddExp.Location=new Point(22, 547);
            lblAddExp.Name="lblAddExp";
            lblAddExp.Size=new Size(191, 21);
            lblAddExp.TabIndex=8;
            lblAddExp.Text="Добавить опыт за задачу";
            // 
            // textBoxAddExp
            // 
            textBoxAddExp.BackColor=Color.BlueViolet;
            textBoxAddExp.BorderStyle=BorderStyle.None;
            textBoxAddExp.Cursor=Cursors.IBeam;
            textBoxAddExp.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddExp.ForeColor=SystemColors.ControlLight;
            textBoxAddExp.Location=new Point(12, 572);
            textBoxAddExp.Name="textBoxAddExp";
            textBoxAddExp.Size=new Size(460, 25);
            textBoxAddExp.TabIndex=7;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor=Color.FromArgb(114, 31, 170);
            btnAddTask.Cursor=Cursors.Hand;
            btnAddTask.FlatStyle=FlatStyle.Popup;
            btnAddTask.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddTask.ForeColor=SystemColors.ControlLight;
            btnAddTask.Location=new Point(12, 612);
            btnAddTask.Name="btnAddTask";
            btnAddTask.Size=new Size(460, 30);
            btnAddTask.TabIndex=9;
            btnAddTask.Text="Добавить";
            btnAddTask.UseVisualStyleBackColor=false;
            btnAddTask.Click+=btnAddTask_Click;
            // 
            // btnDelTask
            // 
            btnDelTask.BackColor=Color.FromArgb(114, 31, 170);
            btnDelTask.Cursor=Cursors.Hand;
            btnDelTask.FlatStyle=FlatStyle.Popup;
            btnDelTask.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelTask.ForeColor=SystemColors.ControlLight;
            btnDelTask.Location=new Point(12, 648);
            btnDelTask.Name="btnDelTask";
            btnDelTask.Size=new Size(460, 30);
            btnDelTask.TabIndex=10;
            btnDelTask.Text="Удалить";
            btnDelTask.UseVisualStyleBackColor=false;
            btnDelTask.Click+=btnDelTask_Click;
            // 
            // btnDoneTask
            // 
            btnDoneTask.BackColor=Color.FromArgb(114, 31, 170);
            btnDoneTask.Cursor=Cursors.Hand;
            btnDoneTask.FlatStyle=FlatStyle.Popup;
            btnDoneTask.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoneTask.ForeColor=SystemColors.ControlLight;
            btnDoneTask.Location=new Point(12, 684);
            btnDoneTask.Name="btnDoneTask";
            btnDoneTask.Size=new Size(460, 30);
            btnDoneTask.TabIndex=11;
            btnDoneTask.Text="Выполнить";
            btnDoneTask.UseVisualStyleBackColor=false;
            btnDoneTask.Click+=btnDoneTask_Click;
            // 
            // menuStripTop
            // 
            menuStripTop.BackColor=Color.Indigo;
            menuStripTop.Items.AddRange(new ToolStripItem[] { дополнительныеОкнаToolStripMenuItem });
            menuStripTop.Location=new Point(0, 0);
            menuStripTop.Name="menuStripTop";
            menuStripTop.Size=new Size(484, 24);
            menuStripTop.TabIndex=12;
            menuStripTop.Text="menuStrip1";
            // 
            // дополнительныеОкнаToolStripMenuItem
            // 
            дополнительныеОкнаToolStripMenuItem.BackColor=Color.Indigo;
            дополнительныеОкнаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { достиженияToolStripMenuItem, прогрессToolStripMenuItem });
            дополнительныеОкнаToolStripMenuItem.ForeColor=SystemColors.ControlLight;
            дополнительныеОкнаToolStripMenuItem.Name="дополнительныеОкнаToolStripMenuItem";
            дополнительныеОкнаToolStripMenuItem.Size=new Size(144, 20);
            дополнительныеОкнаToolStripMenuItem.Text="Дополнительные окна";
            // 
            // достиженияToolStripMenuItem
            // 
            достиженияToolStripMenuItem.BackColor=Color.Indigo;
            достиженияToolStripMenuItem.ForeColor=SystemColors.ControlLight;
            достиженияToolStripMenuItem.Name="достиженияToolStripMenuItem";
            достиженияToolStripMenuItem.Size=new Size(180, 22);
            достиженияToolStripMenuItem.Text="Достижения";
            достиженияToolStripMenuItem.Click+=достиженияToolStripMenuItem_Click;
            // 
            // прогрессToolStripMenuItem
            // 
            прогрессToolStripMenuItem.BackColor=Color.Indigo;
            прогрессToolStripMenuItem.ForeColor=SystemColors.ControlLight;
            прогрессToolStripMenuItem.Name="прогрессToolStripMenuItem";
            прогрессToolStripMenuItem.Size=new Size(180, 22);
            прогрессToolStripMenuItem.Text="Прогресс";
            прогрессToolStripMenuItem.Click+=прогрессToolStripMenuItem_Click;
            // 
            // Root
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.Indigo;
            ClientSize=new Size(484, 726);
            Controls.Add(btnDoneTask);
            Controls.Add(btnDelTask);
            Controls.Add(btnAddTask);
            Controls.Add(lblAddExp);
            Controls.Add(textBoxAddExp);
            Controls.Add(lblAddTask);
            Controls.Add(lblExp);
            Controls.Add(lblTasks);
            Controls.Add(textBoxAddTask);
            Controls.Add(listBoxExp);
            Controls.Add(listBoxTasks);
            Controls.Add(lblLvl);
            Controls.Add(menuStripTop);
            ForeColor=SystemColors.ControlLight;
            Icon=(Icon)resources.GetObject("$this.Icon");
            MainMenuStrip=menuStripTop;
            MaximizeBox=false;
            MaximumSize=new Size(500, 765);
            MinimumSize=new Size(500, 765);
            Name="Root";
            Text="Геймификация жизни";
            Load+=Root_Load;
            menuStripTop.ResumeLayout(false);
            menuStripTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLvl;
        private ListBox listBoxTasks;
        private ListBox listBoxExp;
        private TextBox textBoxAddTask;
        private Label lblTasks;
        private Label lblExp;
        private Label lblAddTask;
        private Label lblAddExp;
        private TextBox textBoxAddExp;
        private Button btnAddTask;
        private Button btnDelTask;
        private Button btnDoneTask;
        private MenuStrip menuStripTop;
        private ToolStripMenuItem дополнительныеОкнаToolStripMenuItem;
        private ToolStripMenuItem достиженияToolStripMenuItem;
        private ToolStripMenuItem прогрессToolStripMenuItem;
    }
}