namespace chap08_stringprocessing
{
    partial class Form1
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
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.OpenTextFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(134, 44);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(92, 23);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "&Open File...";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // OpenTextFileDialog
            // 
            this.OpenTextFileDialog.FileName = "openFileDialog1";
            // 
            // FileTypeCheckBox
            // 
            this.FileTypeCheckBox.AutoSize = true;
            this.FileTypeCheckBox.Location = new System.Drawing.Point(281, 50);
            this.FileTypeCheckBox.Name = "FileTypeCheckBox";
            this.FileTypeCheckBox.Size = new System.Drawing.Size(105, 17);
            this.FileTypeCheckBox.TabIndex = 1;
            this.FileTypeCheckBox.Text = "Comma-delimited";
            this.FileTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 136);
            this.Controls.Add(this.FileTypeCheckBox);
            this.Controls.Add(this.OpenFileButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter 8 - Process Text Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.OpenFileDialog OpenTextFileDialog;
        private System.Windows.Forms.CheckBox FileTypeCheckBox;
    }
}

