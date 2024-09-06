namespace MP4_to_WAV_Converter {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnSelectFile = new Button();
            targetedFile = new Label();
            btnConvert = new Button();
            label1 = new Label();
            label2 = new Label();
            lblStatus = new Label();
            txtFilePath = new Label();
            convertFrom = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            convertTo = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtOutputFolderPath = new Label();
            btnSelectOutputFolder = new Button();
            label7 = new Label();
            folderMode = new CheckBox();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.BackColor = Color.White;
            btnSelectFile.BackgroundImageLayout = ImageLayout.None;
            btnSelectFile.FlatStyle = FlatStyle.Flat;
            btnSelectFile.Font = new Font("Playboy Visuelt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectFile.Location = new Point(35, 137);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(174, 69);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Select Target";
            btnSelectFile.UseVisualStyleBackColor = false;
            btnSelectFile.Click += btnSelectFile_Click_1;
            // 
            // targetedFile
            // 
            targetedFile.AutoSize = true;
            targetedFile.BackColor = Color.White;
            targetedFile.Font = new Font("Playboy Visuelt", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            targetedFile.Location = new Point(248, 21);
            targetedFile.Name = "targetedFile";
            targetedFile.Size = new Size(171, 20);
            targetedFile.TabIndex = 1;
            targetedFile.Text = "Targeted File / Folder: ";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.Control;
            btnConvert.BackgroundImageLayout = ImageLayout.None;
            btnConvert.FlatStyle = FlatStyle.Flat;
            btnConvert.Font = new Font("Playboy Visuelt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConvert.ForeColor = SystemColors.ControlText;
            btnConvert.Location = new Point(23, 315);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(199, 118);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Perform Conversion";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click_1;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(239, 12);
            label1.Name = "label1";
            label1.Size = new Size(580, 86);
            label1.TabIndex = 4;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(221, 432);
            label2.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = SystemColors.Control;
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Font = new Font("Playboy Visuelt", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ControlText;
            lblStatus.Location = new Point(239, 315);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(580, 129);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status Messages";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFilePath
            // 
            txtFilePath.BackColor = Color.White;
            txtFilePath.Font = new Font("Playboy Visuelt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilePath.Location = new Point(248, 41);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(560, 48);
            txtFilePath.TabIndex = 8;
            txtFilePath.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // convertFrom
            // 
            convertFrom.Font = new Font("Playboy Visuelt", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            convertFrom.FormattingEnabled = true;
            convertFrom.Items.AddRange(new object[] { "MP4", "PDF", "WAV", "WEBP" });
            convertFrom.Location = new Point(64, 45);
            convertFrom.Name = "convertFrom";
            convertFrom.RightToLeft = RightToLeft.No;
            convertFrom.Size = new Size(121, 24);
            convertFrom.Sorted = true;
            convertFrom.TabIndex = 9;
            convertFrom.Text = "Select Filetype";
            convertFrom.SelectedIndexChanged += convertFrom_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Playboy Visuelt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 72);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 10;
            label3.Text = "to";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Playboy Visuelt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(76, 19);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 11;
            label4.Text = "Convert";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // convertTo
            // 
            convertTo.Font = new Font("Playboy Visuelt", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            convertTo.FormattingEnabled = true;
            convertTo.Location = new Point(64, 98);
            convertTo.Name = "convertTo";
            convertTo.Size = new Size(121, 24);
            convertTo.Sorted = true;
            convertTo.TabIndex = 12;
            convertTo.Text = "Select Filetype";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(239, 108);
            label5.Name = "label5";
            label5.Size = new Size(580, 89);
            label5.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Playboy Visuelt", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(248, 117);
            label6.Name = "label6";
            label6.Size = new Size(186, 20);
            label6.TabIndex = 14;
            label6.Text = "Selected Output Folder: ";
            // 
            // txtOutputFolderPath
            // 
            txtOutputFolderPath.BackColor = Color.White;
            txtOutputFolderPath.Font = new Font("Playboy Visuelt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOutputFolderPath.Location = new Point(248, 137);
            txtOutputFolderPath.Name = "txtOutputFolderPath";
            txtOutputFolderPath.Size = new Size(560, 48);
            txtOutputFolderPath.TabIndex = 15;
            txtOutputFolderPath.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSelectOutputFolder
            // 
            btnSelectOutputFolder.BackColor = Color.White;
            btnSelectOutputFolder.BackgroundImageLayout = ImageLayout.None;
            btnSelectOutputFolder.FlatStyle = FlatStyle.Flat;
            btnSelectOutputFolder.Font = new Font("Playboy Visuelt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectOutputFolder.Location = new Point(35, 224);
            btnSelectOutputFolder.Name = "btnSelectOutputFolder";
            btnSelectOutputFolder.Size = new Size(174, 69);
            btnSelectOutputFolder.TabIndex = 16;
            btnSelectOutputFolder.Text = "Select Output Folder";
            btnSelectOutputFolder.UseVisualStyleBackColor = false;
            btnSelectOutputFolder.Click += btnSelectOutputFolder_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(239, 204);
            label7.Name = "label7";
            label7.Size = new Size(580, 101);
            label7.TabIndex = 17;
            // 
            // folderMode
            // 
            folderMode.AutoSize = true;
            folderMode.BackColor = Color.White;
            folderMode.Font = new Font("Playboy Visuelt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            folderMode.Location = new Point(249, 215);
            folderMode.Name = "folderMode";
            folderMode.Size = new Size(288, 28);
            folderMode.TabIndex = 18;
            folderMode.Text = "Folder / Playlist Convert Mode";
            folderMode.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(832, 456);
            Controls.Add(folderMode);
            Controls.Add(btnSelectOutputFolder);
            Controls.Add(txtOutputFolderPath);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(convertTo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(convertFrom);
            Controls.Add(txtFilePath);
            Controls.Add(lblStatus);
            Controls.Add(btnConvert);
            Controls.Add(targetedFile);
            Controls.Add(btnSelectFile);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "MP4 to WAV Converter";
            TransparencyKey = Color.LawnGreen;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private Label targetedFile;
        private Button btnConvert;
        private Label label1;
        private Label label2;
        private Label lblStatus;
        private Label txtFilePath;
        private ComboBox convertFrom;
        private Label label3;
        private Label label4;
        private ComboBox convertTo;
        private Label label5;
        private Label label6;
        private Label txtOutputFolderPath;
        private Button btnSelectOutputFolder;
        private Label label7;
        private CheckBox folderMode;
    }
}
