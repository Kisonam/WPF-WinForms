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
            this.GroundBox = new System.Windows.Forms.PictureBox();
            this.SendBox = new System.Windows.Forms.PictureBox();
            this.EmptyBox = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExitEmage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroundBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmptyBox)).BeginInit();
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
            // GroundBox
            // 
            this.GroundBox.BackColor = System.Drawing.Color.Transparent;
            this.GroundBox.BackgroundImage = global::CourceGame.Resource1.Ground1;
            this.GroundBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GroundBox.ErrorImage = null;
            this.GroundBox.InitialImage = null;
            this.GroundBox.Location = new System.Drawing.Point(12, 4);
            this.GroundBox.Name = "GroundBox";
            this.GroundBox.Size = new System.Drawing.Size(23, 22);
            this.GroundBox.TabIndex = 2;
            this.GroundBox.TabStop = false;
            this.GroundBox.Click += new System.EventHandler(this.GroundBox_Click);
            // 
            // SendBox
            // 
            this.SendBox.BackColor = System.Drawing.Color.Transparent;
            this.SendBox.BackgroundImage = global::CourceGame.Resource1.Ground2;
            this.SendBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SendBox.ErrorImage = null;
            this.SendBox.InitialImage = null;
            this.SendBox.Location = new System.Drawing.Point(41, 4);
            this.SendBox.Name = "SendBox";
            this.SendBox.Size = new System.Drawing.Size(23, 22);
            this.SendBox.TabIndex = 3;
            this.SendBox.TabStop = false;
            this.SendBox.Click += new System.EventHandler(this.SendBox_Click);
            // 
            // EmptyBox
            // 
            this.EmptyBox.BackColor = System.Drawing.Color.Black;
            this.EmptyBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmptyBox.ErrorImage = null;
            this.EmptyBox.InitialImage = null;
            this.EmptyBox.Location = new System.Drawing.Point(70, 3);
            this.EmptyBox.Name = "EmptyBox";
            this.EmptyBox.Size = new System.Drawing.Size(23, 22);
            this.EmptyBox.TabIndex = 4;
            this.EmptyBox.TabStop = false;
            this.EmptyBox.Click += new System.EventHandler(this.EmptyBox_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(521, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(602, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(683, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.EmptyBox);
            this.Controls.Add(this.SendBox);
            this.Controls.Add(this.GroundBox);
            this.Controls.Add(this.log);
            this.Controls.Add(this.ExitEmage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ExitEmage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroundBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SendBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmptyBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitEmage;
        private System.Windows.Forms.Timer MainLoopTimer;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.PictureBox GroundBox;
        private System.Windows.Forms.PictureBox SendBox;
        private System.Windows.Forms.PictureBox EmptyBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnGenerate;
    }
}

