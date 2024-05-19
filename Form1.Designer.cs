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
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.BackColor = Color.White;
            btnSelectFile.BackgroundImageLayout = ImageLayout.None;
            btnSelectFile.FlatStyle = FlatStyle.Flat;
            btnSelectFile.Font = new Font("Playboy Visuelt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectFile.Location = new Point(22, 36);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(168, 69);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Select MP4 File";
            btnSelectFile.UseVisualStyleBackColor = false;
            btnSelectFile.Click += btnSelectFile_Click_1;
            // 
            // targetedFile
            // 
            targetedFile.AutoSize = true;
            targetedFile.BackColor = Color.White;
            targetedFile.Font = new Font("Playboy Visuelt", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            targetedFile.Location = new Point(217, 22);
            targetedFile.Name = "targetedFile";
            targetedFile.Size = new Size(134, 19);
            targetedFile.TabIndex = 1;
            targetedFile.Text = "Targeted MP4 File: ";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.Control;
            btnConvert.BackgroundImageLayout = ImageLayout.Zoom;
            btnConvert.FlatStyle = FlatStyle.Flat;
            btnConvert.Font = new Font("Playboy Visuelt", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConvert.ForeColor = SystemColors.ControlText;
            btnConvert.Location = new Point(22, 166);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(168, 118);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Convert to WAV";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click_1;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(208, 12);
            label1.Name = "label1";
            label1.Size = new Size(580, 124);
            label1.TabIndex = 4;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.BorderStyle = BorderStyle.FixedSingle;
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
            lblStatus.Font = new Font("Playboy Visuelt", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ControlText;
            lblStatus.Location = new Point(208, 146);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(580, 298);
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
            txtFilePath.Size = new Size(560, 85);
            txtFilePath.TabIndex = 8;
            txtFilePath.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(800, 456);
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
    }
}
