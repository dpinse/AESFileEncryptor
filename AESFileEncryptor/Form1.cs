using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TriplesecFileEncryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();



        public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        public byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }




        private void openFileButton_Click(object sender, EventArgs e)
        {
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                FileName.Text = ofd.FileName;
            }
        }

        private void SaveFileButton_click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SaveFileName.Text = sfd.FileName;
          
            }
        }

        private void encryptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(encryptRadioButton.Checked)
            {
                EncryptDecryptButton.Text = "Encrypt";
            }
        }

        private void decryptRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(decryptRadioButton.Checked)
            {
                EncryptDecryptButton.Text = "Decrypt";
            }
        }

        private void EncryptDecryptButton_Click(object sender, EventArgs e)
        {
            if (FileName.Text != "")
            {
                if (SaveFileName.Text != "")
                {
                    if (EncryptDecryptButton.Text == "Encrypt")
                    {
                        byte[] bytesToBeEncrypted = File.ReadAllBytes(FileName.Text);
                        byte[] passwordBytes = Encoding.UTF8.GetBytes(passwordInputBox.Text);
                        passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
                        byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);
                        File.WriteAllBytes(SaveFileName.Text, bytesEncrypted);
                        System.Windows.Forms.MessageBox.Show("File encrypted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        byte[] bytesToBeDecrypted = File.ReadAllBytes(FileName.Text);
                        byte[] passwordBytes = Encoding.UTF8.GetBytes(passwordInputBox.Text);
                        passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
                        byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);
                        File.WriteAllBytes(SaveFileName.Text, bytesDecrypted);
                        System.Windows.Forms.MessageBox.Show("File decrypted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else System.Windows.Forms.MessageBox.Show("No save file selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else System.Windows.Forms.MessageBox.Show("No file selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
