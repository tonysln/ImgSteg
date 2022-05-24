namespace ImgSteg
{
    partial class Main
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
            this.sourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.encodeImg = new System.Windows.Forms.Button();
            this.decodeImg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileSize = new System.Windows.Forms.Label();
            this.chosenFileDisplay = new System.Windows.Forms.TextBox();
            this.chooseImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.messageOutput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblDecodedMessage = new System.Windows.Forms.Label();
            this.messageInput = new System.Windows.Forms.TextBox();
            this.sourceImagePreview = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.controlTabs = new System.Windows.Forms.TabControl();
            this.encodePage = new System.Windows.Forms.TabPage();
            this.fromFile = new System.Windows.Forms.Button();
            this.charCounter = new System.Windows.Forms.Label();
            this.decodePage = new System.Windows.Forms.TabPage();
            this.saveOutput = new System.Windows.Forms.Button();
            this.startWithCode = new System.Windows.Forms.CheckBox();
            this.destFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSteganographyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitmapImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutHashingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutThisAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rc4 = new System.Windows.Forms.RadioButton();
            this.Rotate = new System.Windows.Forms.RadioButton();
            this.noEncryption = new System.Windows.Forms.RadioButton();
            this.hashBox = new System.Windows.Forms.GroupBox();
            this.rc4Pwd = new System.Windows.Forms.TextBox();
            this.rotValue = new System.Windows.Forms.NumericUpDown();
            this.importInputMessage = new System.Windows.Forms.OpenFileDialog();
            this.saveOutputMessage = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImagePreview)).BeginInit();
            this.controlTabs.SuspendLayout();
            this.encodePage.SuspendLayout();
            this.decodePage.SuspendLayout();
            this.status.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.hashBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotValue)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceFileDialog
            // 
            this.sourceFileDialog.FileName = "sourceFile";
            this.sourceFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.sourceFileDialog_FileOk);
            // 
            // encodeImg
            // 
            this.encodeImg.Cursor = System.Windows.Forms.Cursors.Default;
            this.encodeImg.Location = new System.Drawing.Point(349, 295);
            this.encodeImg.Name = "encodeImg";
            this.encodeImg.Size = new System.Drawing.Size(74, 32);
            this.encodeImg.TabIndex = 0;
            this.encodeImg.Text = "Encode";
            this.encodeImg.UseVisualStyleBackColor = true;
            this.encodeImg.Click += new System.EventHandler(this.encodeImg_Click);
            // 
            // decodeImg
            // 
            this.decodeImg.Cursor = System.Windows.Forms.Cursors.Default;
            this.decodeImg.Location = new System.Drawing.Point(349, 295);
            this.decodeImg.Name = "decodeImg";
            this.decodeImg.Size = new System.Drawing.Size(74, 32);
            this.decodeImg.TabIndex = 1;
            this.decodeImg.Text = "Decode";
            this.decodeImg.UseVisualStyleBackColor = true;
            this.decodeImg.Click += new System.EventHandler(this.decodeImg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fileSize);
            this.groupBox1.Controls.Add(this.chosenFileDisplay);
            this.groupBox1.Controls.Add(this.chooseImage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // fileSize
            // 
            this.fileSize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fileSize.Location = new System.Drawing.Point(112, 86);
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(318, 21);
            this.fileSize.TabIndex = 3;
            this.fileSize.Text = "fileSize";
            this.fileSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chosenFileDisplay
            // 
            this.chosenFileDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chosenFileDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chosenFileDisplay.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenFileDisplay.Location = new System.Drawing.Point(109, 52);
            this.chosenFileDisplay.Name = "chosenFileDisplay";
            this.chosenFileDisplay.ReadOnly = true;
            this.chosenFileDisplay.Size = new System.Drawing.Size(318, 25);
            this.chosenFileDisplay.TabIndex = 2;
            this.chosenFileDisplay.TextChanged += new System.EventHandler(this.chosenFileDisplay_TextChanged);
            // 
            // chooseImage
            // 
            this.chooseImage.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseImage.Location = new System.Drawing.Point(18, 50);
            this.chooseImage.Name = "chooseImage";
            this.chooseImage.Size = new System.Drawing.Size(81, 28);
            this.chooseImage.TabIndex = 1;
            this.chooseImage.Text = "Open";
            this.chooseImage.UseVisualStyleBackColor = true;
            this.chooseImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Image";
            // 
            // messageOutput
            // 
            this.messageOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.messageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageOutput.Location = new System.Drawing.Point(14, 45);
            this.messageOutput.Multiline = true;
            this.messageOutput.Name = "messageOutput";
            this.messageOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageOutput.ShortcutsEnabled = false;
            this.messageOutput.Size = new System.Drawing.Size(409, 233);
            this.messageOutput.TabIndex = 3;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(11, 21);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(46, 21);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Input";
            this.lblInput.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDecodedMessage
            // 
            this.lblDecodedMessage.AutoSize = true;
            this.lblDecodedMessage.Location = new System.Drawing.Point(11, 21);
            this.lblDecodedMessage.Name = "lblDecodedMessage";
            this.lblDecodedMessage.Size = new System.Drawing.Size(136, 21);
            this.lblDecodedMessage.TabIndex = 1;
            this.lblDecodedMessage.Text = "Decoded Message";
            // 
            // messageInput
            // 
            this.messageInput.Location = new System.Drawing.Point(14, 45);
            this.messageInput.Multiline = true;
            this.messageInput.Name = "messageInput";
            this.messageInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageInput.Size = new System.Drawing.Size(409, 233);
            this.messageInput.TabIndex = 0;
            this.messageInput.TextChanged += new System.EventHandler(this.messageInput_TextChanged);
            // 
            // sourceImagePreview
            // 
            this.sourceImagePreview.Location = new System.Drawing.Point(476, 63);
            this.sourceImagePreview.Name = "sourceImagePreview";
            this.sourceImagePreview.Size = new System.Drawing.Size(353, 324);
            this.sourceImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourceImagePreview.TabIndex = 5;
            this.sourceImagePreview.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Image Preview";
            // 
            // controlTabs
            // 
            this.controlTabs.Controls.Add(this.encodePage);
            this.controlTabs.Controls.Add(this.decodePage);
            this.controlTabs.Location = new System.Drawing.Point(12, 156);
            this.controlTabs.Name = "controlTabs";
            this.controlTabs.SelectedIndex = 0;
            this.controlTabs.Size = new System.Drawing.Size(448, 376);
            this.controlTabs.TabIndex = 7;
            // 
            // encodePage
            // 
            this.encodePage.Controls.Add(this.fromFile);
            this.encodePage.Controls.Add(this.charCounter);
            this.encodePage.Controls.Add(this.messageInput);
            this.encodePage.Controls.Add(this.lblInput);
            this.encodePage.Controls.Add(this.encodeImg);
            this.encodePage.Location = new System.Drawing.Point(4, 29);
            this.encodePage.Name = "encodePage";
            this.encodePage.Padding = new System.Windows.Forms.Padding(3);
            this.encodePage.Size = new System.Drawing.Size(440, 343);
            this.encodePage.TabIndex = 0;
            this.encodePage.Text = "Encode";
            this.encodePage.UseVisualStyleBackColor = true;
            // 
            // fromFile
            // 
            this.fromFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.fromFile.Location = new System.Drawing.Point(269, 295);
            this.fromFile.Name = "fromFile";
            this.fromFile.Size = new System.Drawing.Size(74, 32);
            this.fromFile.TabIndex = 4;
            this.fromFile.Text = "Import";
            this.fromFile.UseVisualStyleBackColor = true;
            this.fromFile.Click += new System.EventHandler(this.fromFile_Click);
            // 
            // charCounter
            // 
            this.charCounter.AutoSize = true;
            this.charCounter.Location = new System.Drawing.Point(14, 299);
            this.charCounter.Name = "charCounter";
            this.charCounter.Size = new System.Drawing.Size(85, 21);
            this.charCounter.TabIndex = 3;
            this.charCounter.Text = "wordcount";
            // 
            // decodePage
            // 
            this.decodePage.Controls.Add(this.saveOutput);
            this.decodePage.Controls.Add(this.startWithCode);
            this.decodePage.Controls.Add(this.lblDecodedMessage);
            this.decodePage.Controls.Add(this.messageOutput);
            this.decodePage.Controls.Add(this.decodeImg);
            this.decodePage.Location = new System.Drawing.Point(4, 29);
            this.decodePage.Name = "decodePage";
            this.decodePage.Padding = new System.Windows.Forms.Padding(3);
            this.decodePage.Size = new System.Drawing.Size(440, 343);
            this.decodePage.TabIndex = 1;
            this.decodePage.Text = "Decode";
            this.decodePage.UseVisualStyleBackColor = true;
            // 
            // saveOutput
            // 
            this.saveOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveOutput.Location = new System.Drawing.Point(269, 295);
            this.saveOutput.Name = "saveOutput";
            this.saveOutput.Size = new System.Drawing.Size(74, 32);
            this.saveOutput.TabIndex = 5;
            this.saveOutput.Text = "Save";
            this.saveOutput.UseVisualStyleBackColor = true;
            this.saveOutput.Click += new System.EventHandler(this.saveOutput_Click);
            // 
            // startWithCode
            // 
            this.startWithCode.AutoSize = true;
            this.startWithCode.Location = new System.Drawing.Point(14, 299);
            this.startWithCode.Name = "startWithCode";
            this.startWithCode.Size = new System.Drawing.Size(204, 25);
            this.startWithCode.TabIndex = 4;
            this.startWithCode.Text = "Filter (look for start code)";
            this.startWithCode.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDisplay});
            this.status.Location = new System.Drawing.Point(0, 543);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(841, 22);
            this.status.SizingGrip = false;
            this.status.TabIndex = 8;
            this.status.Text = "statusStrip1";
            // 
            // statusDisplay
            // 
            this.statusDisplay.Name = "statusDisplay";
            this.statusDisplay.Size = new System.Drawing.Size(0, 17);
            // 
            // mainMenu
            // 
            this.mainMenu.AutoSize = false;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(841, 28);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "mainMenu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(41, 24);
            this.toolStripMenuItem1.Text = "File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(115, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSteganographyToolStripMenuItem,
            this.bitmapImagesToolStripMenuItem,
            this.aboutHashingToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutThisAppToolStripMenuItem});
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSteganographyToolStripMenuItem
            // 
            this.aboutSteganographyToolStripMenuItem.Name = "aboutSteganographyToolStripMenuItem";
            this.aboutSteganographyToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.aboutSteganographyToolStripMenuItem.Text = "Steganography";
            // 
            // bitmapImagesToolStripMenuItem
            // 
            this.bitmapImagesToolStripMenuItem.Name = "bitmapImagesToolStripMenuItem";
            this.bitmapImagesToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.bitmapImagesToolStripMenuItem.Text = "Bitmap Images";
            // 
            // aboutHashingToolStripMenuItem
            // 
            this.aboutHashingToolStripMenuItem.Name = "aboutHashingToolStripMenuItem";
            this.aboutHashingToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.aboutHashingToolStripMenuItem.Text = "Encryption";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(195, 6);
            // 
            // aboutThisAppToolStripMenuItem
            // 
            this.aboutThisAppToolStripMenuItem.Name = "aboutThisAppToolStripMenuItem";
            this.aboutThisAppToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.aboutThisAppToolStripMenuItem.Text = "About";
            this.aboutThisAppToolStripMenuItem.Click += new System.EventHandler(this.aboutThisAppToolStripMenuItem_Click);
            // 
            // Rc4
            // 
            this.Rc4.AutoSize = true;
            this.Rc4.Location = new System.Drawing.Point(19, 26);
            this.Rc4.Name = "Rc4";
            this.Rc4.Size = new System.Drawing.Size(57, 25);
            this.Rc4.TabIndex = 4;
            this.Rc4.Text = "RC4";
            this.Rc4.UseVisualStyleBackColor = true;
            this.Rc4.CheckedChanged += new System.EventHandler(this.Rc4_CheckedChanged);
            // 
            // Rotate
            // 
            this.Rotate.AutoSize = true;
            this.Rotate.Location = new System.Drawing.Point(19, 57);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(81, 25);
            this.Rotate.TabIndex = 5;
            this.Rotate.Text = "ROT-13";
            this.Rotate.UseVisualStyleBackColor = true;
            // 
            // noEncryption
            // 
            this.noEncryption.AutoSize = true;
            this.noEncryption.Checked = true;
            this.noEncryption.Location = new System.Drawing.Point(19, 88);
            this.noEncryption.Name = "noEncryption";
            this.noEncryption.Size = new System.Drawing.Size(127, 25);
            this.noEncryption.TabIndex = 6;
            this.noEncryption.TabStop = true;
            this.noEncryption.Text = "No Encryption";
            this.noEncryption.UseVisualStyleBackColor = true;
            // 
            // hashBox
            // 
            this.hashBox.Controls.Add(this.rc4Pwd);
            this.hashBox.Controls.Add(this.rotValue);
            this.hashBox.Controls.Add(this.noEncryption);
            this.hashBox.Controls.Add(this.Rc4);
            this.hashBox.Controls.Add(this.Rotate);
            this.hashBox.Location = new System.Drawing.Point(474, 399);
            this.hashBox.Name = "hashBox";
            this.hashBox.Size = new System.Drawing.Size(354, 133);
            this.hashBox.TabIndex = 9;
            this.hashBox.TabStop = false;
            this.hashBox.Text = "Encryption";
            // 
            // rc4Pwd
            // 
            this.rc4Pwd.Location = new System.Drawing.Point(76, 26);
            this.rc4Pwd.MaxLength = 50;
            this.rc4Pwd.Name = "rc4Pwd";
            this.rc4Pwd.PasswordChar = '*';
            this.rc4Pwd.Size = new System.Drawing.Size(174, 27);
            this.rc4Pwd.TabIndex = 8;
            this.rc4Pwd.UseSystemPasswordChar = true;
            this.rc4Pwd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rc4Pwd_MouseClick);
            this.rc4Pwd.TextChanged += new System.EventHandler(this.rc4Pwd_TextChanged);
            // 
            // rotValue
            // 
            this.rotValue.Location = new System.Drawing.Point(76, 58);
            this.rotValue.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.rotValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rotValue.Name = "rotValue";
            this.rotValue.Size = new System.Drawing.Size(52, 27);
            this.rotValue.TabIndex = 7;
            this.rotValue.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 565);
            this.Controls.Add(this.hashBox);
            this.Controls.Add(this.status);
            this.Controls.Add(this.controlTabs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.sourceImagePreview);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Steganography";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImagePreview)).EndInit();
            this.controlTabs.ResumeLayout(false);
            this.encodePage.ResumeLayout(false);
            this.encodePage.PerformLayout();
            this.decodePage.ResumeLayout(false);
            this.decodePage.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.hashBox.ResumeLayout(false);
            this.hashBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog sourceFileDialog;
        private System.Windows.Forms.Button encodeImg;
        private System.Windows.Forms.Button decodeImg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox messageInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblDecodedMessage;
        private System.Windows.Forms.TextBox messageOutput;
        private System.Windows.Forms.Button chooseImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chosenFileDisplay;
        private System.Windows.Forms.PictureBox sourceImagePreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl controlTabs;
        private System.Windows.Forms.TabPage encodePage;
        private System.Windows.Forms.TabPage decodePage;
        private System.Windows.Forms.SaveFileDialog destFileDialog;
        private System.Windows.Forms.Label charCounter;
        private System.Windows.Forms.CheckBox startWithCode;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusDisplay;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.RadioButton noEncryption;
        private System.Windows.Forms.RadioButton Rotate;
        private System.Windows.Forms.RadioButton Rc4;
        private System.Windows.Forms.GroupBox hashBox;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSteganographyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutHashingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem bitmapImagesToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown rotValue;
        private System.Windows.Forms.TextBox rc4Pwd;
        private System.Windows.Forms.Button fromFile;
        private System.Windows.Forms.Button saveOutput;
        private System.Windows.Forms.OpenFileDialog importInputMessage;
        private System.Windows.Forms.SaveFileDialog saveOutputMessage;
        private System.Windows.Forms.Label fileSize;
    }
}

