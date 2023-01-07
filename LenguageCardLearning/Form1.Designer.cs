namespace LenguageCardLearning
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
            this.Work = new System.Windows.Forms.GroupBox();
            this.txtTranslate = new System.Windows.Forms.TextBox();
            this.txtTrans = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveWords = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.Work.SuspendLayout();
            this.SuspendLayout();
            // 
            // Work
            // 
            this.Work.Controls.Add(this.txtTranslate);
            this.Work.Controls.Add(this.txtTrans);
            this.Work.Controls.Add(this.txtWord);
            this.Work.Controls.Add(this.label3);
            this.Work.Controls.Add(this.label2);
            this.Work.Controls.Add(this.label1);
            this.Work.Location = new System.Drawing.Point(12, 12);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(1043, 125);
            this.Work.TabIndex = 1;
            this.Work.TabStop = false;
            this.Work.Text = "workPlace";
            // 
            // txtTranslate
            // 
            this.txtTranslate.Location = new System.Drawing.Point(800, 63);
            this.txtTranslate.Name = "txtTranslate";
            this.txtTranslate.Size = new System.Drawing.Size(223, 20);
            this.txtTranslate.TabIndex = 5;
            // 
            // txtTrans
            // 
            this.txtTrans.Location = new System.Drawing.Point(389, 63);
            this.txtTrans.Name = "txtTrans";
            this.txtTrans.Size = new System.Drawing.Size(225, 20);
            this.txtTrans.TabIndex = 4;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(21, 63);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(209, 20);
            this.txtWord.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(886, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Translate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transcription";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "English";
            // 
            // btnSaveWords
            // 
            this.btnSaveWords.Location = new System.Drawing.Point(1062, 60);
            this.btnSaveWords.Name = "btnSaveWords";
            this.btnSaveWords.Size = new System.Drawing.Size(158, 35);
            this.btnSaveWords.TabIndex = 2;
            this.btnSaveWords.Text = "Save Word";
            this.btnSaveWords.UseVisualStyleBackColor = true;
            this.btnSaveWords.Click += new System.EventHandler(this.btnSaveWords_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1062, 19);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(158, 35);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create file";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1232, 761);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSaveWords);
            this.Controls.Add(this.Work);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Learning";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Work.ResumeLayout(false);
            this.Work.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Work;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTranslate;
        private System.Windows.Forms.TextBox txtTrans;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnSaveWords;
        private System.Windows.Forms.Button btnCreate;
    }
}

