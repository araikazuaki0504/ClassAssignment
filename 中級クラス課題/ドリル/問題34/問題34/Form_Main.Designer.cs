﻿namespace 問題34
{
    partial class Form_Main
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
            button = new Button();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(95, 94);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 0;
            button.Text = "表示";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 217);
            Controls.Add(button);
            Name = "Form_Main";
            Text = "問題34";
            ResumeLayout(false);
        }

        #endregion

        private Button button;
    }
}