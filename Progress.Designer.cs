namespace Gamification_Of_Life
{
    partial class Progress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Progress));
            lblTasksDone=new Label();
            lblLvl=new Label();
            SuspendLayout();
            // 
            // lblTasksDone
            // 
            lblTasksDone.AutoSize=true;
            lblTasksDone.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTasksDone.ForeColor=SystemColors.ControlLight;
            lblTasksDone.Location=new Point(12, 9);
            lblTasksDone.Name="lblTasksDone";
            lblTasksDone.Size=new Size(312, 25);
            lblTasksDone.TabIndex=0;
            lblTasksDone.Text="Количество выполненных задач: 0";
            // 
            // lblLvl
            // 
            lblLvl.AutoSize=true;
            lblLvl.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLvl.ForeColor=SystemColors.ControlLight;
            lblLvl.Location=new Point(12, 48);
            lblLvl.Name="lblLvl";
            lblLvl.Size=new Size(105, 25);
            lblLvl.TabIndex=1;
            lblLvl.Text="Уровень: 0";
            // 
            // Progress
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.Indigo;
            BackgroundImage=Properties.Resources._progress_background;
            BackgroundImageLayout=ImageLayout.Stretch;
            ClientSize=new Size(784, 461);
            Controls.Add(lblLvl);
            Controls.Add(lblTasksDone);
            ForeColor=SystemColors.ControlLight;
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            MaximumSize=new Size(800, 500);
            MinimumSize=new Size(800, 500);
            Name="Progress";
            Text="Прогресс";
            Load+=Progress_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTasksDone;
        private Label lblLvl;
    }
}