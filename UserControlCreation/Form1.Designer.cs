﻿namespace UserControlCreation
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
            this.clearableTextBox1 = new UserControlCreation.ClearableTextBox();
            this.clearableTextBox2 = new UserControlCreation.ClearableTextBox();
            this.SuspendLayout();
            // 
            // clearableTextBox1
            // 
            this.clearableTextBox1.Location = new System.Drawing.Point(13, 13);
            this.clearableTextBox1.MinimumSize = new System.Drawing.Size(84, 53);
            this.clearableTextBox1.Name = "clearableTextBox1";
            this.clearableTextBox1.Size = new System.Drawing.Size(191, 53);
            this.clearableTextBox1.TabIndex = 0;
            this.clearableTextBox1.Title = "label1";
            // 
            // clearableTextBox2
            // 
            this.clearableTextBox2.Location = new System.Drawing.Point(13, 100);
            this.clearableTextBox2.MinimumSize = new System.Drawing.Size(84, 53);
            this.clearableTextBox2.Name = "clearableTextBox2";
            this.clearableTextBox2.Size = new System.Drawing.Size(191, 53);
            this.clearableTextBox2.TabIndex = 1;
            this.clearableTextBox2.Title = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 276);
            this.Controls.Add(this.clearableTextBox2);
            this.Controls.Add(this.clearableTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ClearableTextBox clearableTextBox1;
        private ClearableTextBox clearableTextBox2;
    }
}

