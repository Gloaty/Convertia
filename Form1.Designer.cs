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
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.BackColor = Color.White;
            btnSelectFile.BackgroundImageLayout = ImageLayout.None;
            btnSelectFile.FlatStyle = FlatStyle.Flat;
            btnSelectFile.Font = new Font("Playboy Visuelt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectFile.Location = new Point(22, 149);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(168, 69);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Select Target File";
            btnSelectFile.UseVisualStyleBackColor = false;
            btnSelectFile.Click += btnSelectFile_Click_1;
            // 
            // targetedFile
            // 
            targetedFile.AutoSize = true;
            targetedFile.BackColor = Color.White;
            targetedFile.Font = new Font("Playboy Visuelt", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            targetedFile.Location = new Point(217, 22);
            targetedFile.Name = "targetedFile";
            targetedFile.Size = new Size(109, 20);
            targetedFile.TabIndex = 1;
            targetedFile.Text = "Targeted File: ";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.Control;
            btnConvert.BackgroundImageLayout = ImageLayout.None;
            btnConvert.FlatStyle = FlatStyle.Flat;
            btnConvert.Font = new Font("Playboy Visuelt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConvert.ForeColor = SystemColors.ControlText;
            btnConvert.Location = new Point(22, 316);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(168, 118);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Perform Conversion";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click_1;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(208, 12);
            label1.Name = "label1";
            label1.Size = new Size(580, 89);
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
            label2.Size = new Size(190, 432);
            label2.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = SystemColors.Control;
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Font = new Font("Playboy Visuelt", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ControlText;
            lblStatus.Location = new Point(208, 117);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(580, 327);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status Messages";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFilePath
            // 
            txtFilePath.BackColor = Color.White;
            txtFilePath.Font = new Font("Playboy Visuelt", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilePath.Location = new Point(217, 41);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(560, 48);
            txtFilePath.TabIndex = 8;
            txtFilePath.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // convertFrom
            // 
            convertFrom.Font = new Font("Playboy Visuelt", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            convertFrom.FormattingEnabled = true;
            convertFrom.Items.AddRange(new object[] { "MP4" });
            convertFrom.Location = new Point(46, 51);
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
            label3.Location = new Point(57, 78);
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
            label4.Location = new Point(57, 25);
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
            convertTo.Location = new Point(46, 104);
            convertTo.Name = "convertTo";
            convertTo.Size = new Size(121, 24);
            convertTo.Sorted = true;
            convertTo.TabIndex = 12;
            convertTo.Text = "Select Filetype";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(800, 456);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "MP4 to WAV Converter";
            TransparencyKey = Color.LawnGreen;
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
    }
}
