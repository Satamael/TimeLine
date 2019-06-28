namespace WindowsFormsApp3
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.LabelZagolovok = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Button();
            this.buttonRez = new System.Windows.Forms.Button();
            this.BallLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNext.BackgroundImage")));
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNext.Location = new System.Drawing.Point(623, 484);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(98, 60);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Дальше";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Location = new System.Drawing.Point(397, 484);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 60);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // LabelZagolovok
            // 
            this.LabelZagolovok.AutoSize = true;
            this.LabelZagolovok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelZagolovok.Font = new System.Drawing.Font("Comic Sans MS", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelZagolovok.Image = ((System.Drawing.Image)(resources.GetObject("LabelZagolovok.Image")));
            this.LabelZagolovok.Location = new System.Drawing.Point(216, 9);
            this.LabelZagolovok.Name = "LabelZagolovok";
            this.LabelZagolovok.Size = new System.Drawing.Size(442, 108);
            this.LabelZagolovok.TabIndex = 3;
            this.LabelZagolovok.Text = "Интелектуальная игра\r\n\"Проверь знание дат\"";
            // 
            // Help
            // 
            this.Help.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.rama;
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Help.Location = new System.Drawing.Point(685, 9);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(47, 50);
            this.Help.TabIndex = 4;
            this.Help.Text = "?";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRez
            // 
            this.buttonRez.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRez.BackgroundImage")));
            this.buttonRez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRez.Location = new System.Drawing.Point(493, 472);
            this.buttonRez.Name = "buttonRez";
            this.buttonRez.Size = new System.Drawing.Size(124, 72);
            this.buttonRez.TabIndex = 6;
            this.buttonRez.Text = "Вписать результат";
            this.buttonRez.UseVisualStyleBackColor = true;
            this.buttonRez.Click += new System.EventHandler(this.buttonRez_Click);
            // 
            // BallLabel
            // 
            this.BallLabel.AutoSize = true;
            this.BallLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.85714F, System.Drawing.FontStyle.Bold);
            this.BallLabel.Location = new System.Drawing.Point(12, 439);
            this.BallLabel.Name = "BallLabel";
            this.BallLabel.Size = new System.Drawing.Size(202, 53);
            this.BallLabel.TabIndex = 7;
            this.BallLabel.Text = "Баллы: 0";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.85714F, System.Drawing.FontStyle.Bold);
            this.TimeLabel.Location = new System.Drawing.Point(12, 503);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(190, 53);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "Время: 0";
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 60000;
            this.timerTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 565);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.BallLabel);
            this.Controls.Add(this.buttonRez);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.LabelZagolovok);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(755, 565);
            this.MinimumSize = new System.Drawing.Size(755, 565);
            this.Name = "GameForm";
            this.Text = "Игра";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label LabelZagolovok;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button buttonRez;
        private System.Windows.Forms.Label BallLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer timerTime;
    }
}

