namespace CardApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFullSize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFullSize
            // 
            this.btnFullSize.BackgroundImage = global::CardApplication.Properties.Resources.maximize;
            this.btnFullSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFullSize.Location = new System.Drawing.Point(488, 12);
            this.btnFullSize.Name = "btnFullSize";
            this.btnFullSize.Size = new System.Drawing.Size(32, 32);
            this.btnFullSize.TabIndex = 1;
            this.btnFullSize.UseVisualStyleBackColor = true;
            this.btnFullSize.Click += new System.EventHandler(this.btnFullSize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::CardApplication.Properties.Resources.cross;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(526, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackgroundImage = global::CardApplication.Properties.Resources.hidden;
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHide.Location = new System.Drawing.Point(450, 12);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(32, 32);
            this.btnHide.TabIndex = 2;
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 590);
            this.ControlBox = false;
            this.Controls.Add(this.btnFullSize);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnglishCard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFullSize;
        private System.Windows.Forms.Button btnHide;
    }
}

