namespace CourceGame
{
    partial class Form1
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
            this.ExitEmage = new System.Windows.Forms.PictureBox();
            this.MainLoopTimer = new System.Windows.Forms.Timer(this.components);
            this.log = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExitEmage)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitEmage
            // 
            this.ExitEmage.BackColor = System.Drawing.Color.Transparent;
            this.ExitEmage.BackgroundImage = global::CourceGame.Resource1.ExitBtn;
            this.ExitEmage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitEmage.ErrorImage = null;
            this.ExitEmage.InitialImage = null;
            this.ExitEmage.Location = new System.Drawing.Point(774, 3);
            this.ExitEmage.Name = "ExitEmage";
            this.ExitEmage.Size = new System.Drawing.Size(23, 22);
            this.ExitEmage.TabIndex = 0;
            this.ExitEmage.TabStop = false;
            this.ExitEmage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainLoopTimer
            // 
            this.MainLoopTimer.Enabled = true;
            this.MainLoopTimer.Interval = 41;
            this.MainLoopTimer.Tick += new System.EventHandler(this.MainLoopTimer_Tick);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.BackColor = System.Drawing.Color.Lime;
            this.log.Location = new System.Drawing.Point(13, 13);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(0, 13);
            this.log.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.log);
            this.Controls.Add(this.ExitEmage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ExitEmage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitEmage;
        private System.Windows.Forms.Timer MainLoopTimer;
        private System.Windows.Forms.Label log;
    }
}

