namespace AnnonFileEncryptor
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
            this.openFileButton = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveFileName = new System.Windows.Forms.TextBox();
            this.SaveFileLabel = new System.Windows.Forms.Label();
            this.passwordInputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EncryptDecryptButton = new System.Windows.Forms.Button();
            this.encryptRadioButton = new System.Windows.Forms.RadioButton();
            this.decryptRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(26, 77);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(107, 80);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(217, 20);
            this.FileName.TabIndex = 2;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(330, 83);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(54, 13);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "File Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(26, 119);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save File";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveFileName
            // 
            this.SaveFileName.Location = new System.Drawing.Point(107, 121);
            this.SaveFileName.Name = "SaveFileName";
            this.SaveFileName.Size = new System.Drawing.Size(217, 20);
            this.SaveFileName.TabIndex = 10;
            // 
            // SaveFileLabel
            // 
            this.SaveFileLabel.AutoSize = true;
            this.SaveFileLabel.Location = new System.Drawing.Point(330, 124);
            this.SaveFileLabel.Name = "SaveFileLabel";
            this.SaveFileLabel.Size = new System.Drawing.Size(82, 13);
            this.SaveFileLabel.TabIndex = 11;
            this.SaveFileLabel.Text = "Save File Name";
            // 
            // passwordInputBox
            // 
            this.passwordInputBox.Location = new System.Drawing.Point(107, 165);
            this.passwordInputBox.Name = "passwordInputBox";
            this.passwordInputBox.PasswordChar = '*';
            this.passwordInputBox.Size = new System.Drawing.Size(217, 20);
            this.passwordInputBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password";
            // 
            // EncryptDecryptButton
            // 
            this.EncryptDecryptButton.Location = new System.Drawing.Point(177, 191);
            this.EncryptDecryptButton.Name = "EncryptDecryptButton";
            this.EncryptDecryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptDecryptButton.TabIndex = 14;
            this.EncryptDecryptButton.Text = "Encrypt";
            this.EncryptDecryptButton.UseVisualStyleBackColor = true;
            this.EncryptDecryptButton.Click += new System.EventHandler(this.EncryptDecryptButton_Click);
            // 
            // encryptRadioButton
            // 
            this.encryptRadioButton.AutoSize = true;
            this.encryptRadioButton.Checked = true;
            this.encryptRadioButton.Location = new System.Drawing.Point(258, 194);
            this.encryptRadioButton.Name = "encryptRadioButton";
            this.encryptRadioButton.Size = new System.Drawing.Size(61, 17);
            this.encryptRadioButton.TabIndex = 15;
            this.encryptRadioButton.TabStop = true;
            this.encryptRadioButton.Text = "Encrypt";
            this.encryptRadioButton.UseVisualStyleBackColor = true;
            this.encryptRadioButton.CheckedChanged += new System.EventHandler(this.encryptRadioButton_CheckedChanged);
            // 
            // decryptRadioButton
            // 
            this.decryptRadioButton.AutoSize = true;
            this.decryptRadioButton.Location = new System.Drawing.Point(257, 217);
            this.decryptRadioButton.Name = "decryptRadioButton";
            this.decryptRadioButton.Size = new System.Drawing.Size(62, 17);
            this.decryptRadioButton.TabIndex = 16;
            this.decryptRadioButton.Text = "Decrypt";
            this.decryptRadioButton.UseVisualStyleBackColor = true;
            this.decryptRadioButton.CheckedChanged += new System.EventHandler(this.decryptRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 281);
            this.Controls.Add(this.decryptRadioButton);
            this.Controls.Add(this.encryptRadioButton);
            this.Controls.Add(this.EncryptDecryptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordInputBox);
            this.Controls.Add(this.SaveFileLabel);
            this.Controls.Add(this.SaveFileName);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.openFileButton);
            this.Name = "Form1";
            this.Text = "Annon File Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SaveFileName;
        private System.Windows.Forms.Label SaveFileLabel;
        private System.Windows.Forms.TextBox passwordInputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EncryptDecryptButton;
        private System.Windows.Forms.RadioButton encryptRadioButton;
        private System.Windows.Forms.RadioButton decryptRadioButton;
    }
}

