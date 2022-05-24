using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImgSteg
{
    public partial class Main : Form
    {
        // All encoded messages start with "STG"

        // TODO: rewrite everything - create all items from code, not from the designer

        public Main()
        {
            InitializeComponent();

            charCounter.Text = "";

            sourceFileDialog.Title = "Open Source Image";
            sourceFileDialog.Filter = "PNG files (*.png)|*.png";
            sourceFileDialog.FileName = "";

            destFileDialog.Title = "Save Encoded Image";
            destFileDialog.Filter = "PNG files (*.png)|*.png";
            destFileDialog.FileName = "";

            importInputMessage.Title = "Import Message";
            importInputMessage.Filter = "TXT files (*.txt)|*.txt";
            importInputMessage.FileName = "";

            saveOutputMessage.Title = "Save Message";
            saveOutputMessage.Filter = "TXT files (*.txt)|*.txt";
            saveOutputMessage.FileName = "";

            startWithCode.Checked = true;
            messageOutput.ReadOnly = true;
            chosenFileDisplay.ReadOnly = true;

            encodeImg.Enabled = false;
            decodeImg.Enabled = false;
            messageInput.Enabled = false;
            startWithCode.Enabled = false;
            hashBox.Enabled = false;
            fromFile.Enabled = false;
            saveOutput.Enabled = false;

            rotValue.Minimum = 1;
            rotValue.Maximum = 25;
            rotValue.Value = 13;

            rc4Pwd.Text = "";
            fileSize.Text = "";
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            statusDisplay.Text = "Ready";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sourceFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenSourceFile();
        }

        private void OpenSourceFile()
        {
            if (sourceFileDialog.ShowDialog() == DialogResult.OK
                && !string.IsNullOrEmpty(sourceFileDialog.FileName))
            {
                string filePath = sourceFileDialog.FileName;
                chosenFileDisplay.Text = filePath;
                statusDisplay.Text = "Image Path OK";

                Image selected;
                using (var bmpTemp = new Bitmap(filePath))
                {
                    selected = new Bitmap(bmpTemp);
                    double size = Math.Round(new FileInfo(filePath).Length / Math.Pow(1024.0, 2), 3);
                    fileSize.Text = size.ToString() + " KiB";
                }

                sourceImagePreview.Image = selected;

                encodeImg.Enabled = true;
                decodeImg.Enabled = true;
                fromFile.Enabled = true;
                saveOutput.Enabled = true;
                messageInput.Enabled = true;
                startWithCode.Enabled = true;
                hashBox.Enabled = true;

                int maxChars = (selected.Width * selected.Height) / 3 - (1 + 3);
                messageInput.MaxLength = maxChars;
                charCounter.Text = messageInput.Text.Length + "/" + maxChars;

                messageOutput.Text = "";
                rc4Pwd.Text = "";

            }
        }

        private void chosenFileDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void encodeImg_Click(object sender, EventArgs e)
        {

            if (Rc4.Checked && string.IsNullOrEmpty(rc4Pwd.Text))
            {
                statusDisplay.Text = "Please provide a password for RC4";
                return;
            }

            if (!string.IsNullOrEmpty(chosenFileDisplay.Text) && !string.IsNullOrEmpty(messageInput.Text))
            {
                statusDisplay.Text = "Encoding...";

                try
                {
                    if (destFileDialog.ShowDialog() == DialogResult.OK
                        && !string.IsNullOrEmpty(destFileDialog.FileName))
                    {

                        string inputMessage = messageInput.Text;

                        if (Rotate.Checked)
                        {
                            inputMessage = Encryption.Rotate(inputMessage, (int)rotValue.Value);
                        }
                        else if (Rc4.Checked)
                        {
                            inputMessage = Encryption.Rc4(inputMessage, rc4Pwd.Text);
                        }

                        Steganography.EncodeAndSave(chosenFileDisplay.Text,
                            inputMessage, destFileDialog.FileName);
                        statusDisplay.Text = "Successfully encoded and saved image";
                    }
                    else
                    {
                        statusDisplay.Text = "Encoding cancelled";
                    }
                }
                catch (Exception)
                {
                    statusDisplay.Text = "Unable to open and process the selected file";
                }

            }
            else
            {
                statusDisplay.Text = "Image path and/or message can't be empty";
            }
        }

        private void decodeImg_Click(object sender, EventArgs e)
        {

            if (Rc4.Checked && string.IsNullOrEmpty(rc4Pwd.Text))
            {
                statusDisplay.Text = "Please provide a password for RC4";
                return;
            }

            if (!string.IsNullOrEmpty(chosenFileDisplay.Text))
            {
                statusDisplay.Text = "Decoding...";

                string message = Steganography.Decode(chosenFileDisplay.Text, startWithCode.Checked);

                if (Rotate.Checked)
                {
                    message = Encryption.DeRotate(message, (int)rotValue.Value);
                }
                else if (Rc4.Checked)
                {
                    message = Encryption.Rc4(message, rc4Pwd.Text);
                }

                messageOutput.Text = message;
                if (message.Length > 0)
                {
                    statusDisplay.Text = "Successfully decoded image";
                }
                else
                {
                    statusDisplay.Text = "No message found";
                }
            }
            else
            {
                statusDisplay.Text = "Image path can't be empty";
            }
        }

        private void messageInput_TextChanged(object sender, EventArgs e)
        {
            charCounter.Text = String.Format("{0}/{1}", messageInput.Text.Length, messageInput.MaxLength);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSourceFile();
        }

        private void aboutThisAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Image Steganography App" +
                "\nAnton Slavin\ngithub.com/tonysln\n\nSome code by\ngithub.com/AlexMaclean";
            string caption = "About";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        private void Rc4_CheckedChanged(object sender, EventArgs e)
        {
            rc4Pwd.Focus();
        }

        private void rc4Pwd_TextChanged(object sender, EventArgs e)
        {
            Rc4.Checked = true;
        }

        private void rc4Pwd_Enter(object sender, EventArgs e)
        {
            
        }

        private void rc4Pwd_MouseClick(object sender, MouseEventArgs e)
        {
            Rc4.Checked = true;
        }

        private void fromFile_Click(object sender, EventArgs e)
        {
            // import input from file

            if (importInputMessage.ShowDialog() == DialogResult.OK
                && !string.IsNullOrEmpty(importInputMessage.FileName))
            {
                string importedText = File.ReadAllText(importInputMessage.FileName);
                if (importedText.Length <= messageInput.MaxLength)
                {
                    messageInput.Text = importedText;
                    statusDisplay.Text = "Successfully imported message from file";
                }
                else
                {
                    statusDisplay.Text = "Message is too long for this image";
                }
            }
        }

        private void saveOutput_Click(object sender, EventArgs e)
        {
            // save output to file

            if (!string.IsNullOrEmpty(messageOutput.Text))
            {
                if (saveOutputMessage.ShowDialog() == DialogResult.OK
                        && !string.IsNullOrEmpty(saveOutputMessage.FileName))
                {
                    File.WriteAllText(saveOutputMessage.FileName, messageOutput.Text);
                    statusDisplay.Text = "Successfully saved message to file";
                }
            }
            else
            {
                statusDisplay.Text = "Nothing to save";
            }
        }
    }
}
