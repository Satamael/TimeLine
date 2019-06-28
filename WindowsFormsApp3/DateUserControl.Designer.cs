namespace WindowsFormsApp3
{
    partial class DateUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Date = new System.Windows.Forms.Label();
            this.Tip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(0, 192);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(53, 25);
            this.Date.TabIndex = 1;
            this.Date.Text = "Date";
            // 
            // Tip
            // 
            this.Tip.BackColor = System.Drawing.SystemColors.Control;
            this.Tip.Location = new System.Drawing.Point(18, 19);
            this.Tip.Multiline = true;
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            this.Tip.Size = new System.Drawing.Size(114, 139);
            this.Tip.TabIndex = 2;
            this.Tip.TextChanged += new System.EventHandler(this.Tip_TextChanged);
            // 
            // DateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.rama;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.Date);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(150, 180);
            this.MinimumSize = new System.Drawing.Size(150, 100);
            this.Name = "DateUserControl";
            this.Size = new System.Drawing.Size(150, 180);
            this.Load += new System.EventHandler(this.DateUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox Tip;
    }
}
