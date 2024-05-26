using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
using static System.Net.WebRequestMethods;

namespace MP4_to_WAV_Converter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            if (System.IO.File.Exists("temp_audio.mp3")) {
                System.IO.File.Delete("temp_audio.mp3");
            }
            this.Load += new EventHandler(Form1_Load);
        }
        private void Form1_Load(object sender, EventArgs e) {
            Random random = new Random();
            int red = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue = random.Next(0, 256);
            this.BackColor = Color.FromArgb(red, green, blue);
        }
        private void btnSelectOutputFolder_Click(object sender, EventArgs e) {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog()) {
                if (folderDialog.ShowDialog() == DialogResult.OK) {
                    txtOutputFolderPath.Text = folderDialog.SelectedPath;
                }
            }
        }
        private void ExtractAudioFromMp4(string ffmpegPath, string inputFilePath, string outputFilePath) {
            var ffmpegProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = $"-i \"{inputFilePath}\" -q:a 0 -map a \"{outputFilePath}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            ffmpegProcess.Start();
            ffmpegProcess.WaitForExit();
        }
        private void ConvertMp3ToWav(string inputFilePath, string outputFilePath) {
            using (var reader = new Mp3FileReader(inputFilePath))
            using (var writer = new WaveFileWriter(outputFilePath, reader.WaveFormat)) {
                reader.CopyTo(writer);
            }
        }
        private void btnSelectFile_Click_1(object sender, EventArgs e) {
            if (folderMode.Checked == false) {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "MP4 files (*.mp4)|*.mp4",
                    Title = "Select a file for conversion",
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    txtFilePath.Text = openFileDialog.FileName;
                    lblStatus.Text = "File selected: " + openFileDialog.FileName;
                }
            }
            if (folderMode.Checked == true) {
                using (FolderBrowserDialog openFileDialog = new FolderBrowserDialog()) {
                    if (openFileDialog.ShowDialog() == DialogResult.OK) {
                        txtFilePath.Text = openFileDialog.SelectedPath;
                        lblStatus.Text = "File selected: " + openFileDialog.SelectedPath;
                    }
                }
            }
        }
        private void btnConvert_Click_1(object sender, EventArgs e) {
            string outputFolderPath = txtOutputFolderPath.Text;
            if (convertTo.Text == "WAV" && convertFrom.Text == "MP4") {
                if (!folderMode.Checked) {
                    string ffmpegPath = "ffmpeg.exe";
                    string inputFilePath = txtFilePath.Text;
                    string tempAudioFilePath = "temp_audio.mp3";
                    string outputFilePath = Path.Combine(outputFolderPath, Path.GetFileNameWithoutExtension(inputFilePath) + ".wav");
                    if (string.IsNullOrWhiteSpace(inputFilePath) || !System.IO.File.Exists(inputFilePath)) {
                        lblStatus.Text = "Please select a valid MP4 file.";
                        return;
                    }
                    try {
                        lblStatus.Text = "Extracting audio...";
                        ExtractAudioFromMp4(ffmpegPath, inputFilePath, tempAudioFilePath);
                        lblStatus.Text = "Converting to WAV...";
                        ConvertMp3ToWav(tempAudioFilePath, outputFilePath);
                        lblStatus.Text = "Conversion complete: " + outputFilePath;
                    }
                    catch (Exception ex) {
                        lblStatus.Text = "An error occurred: " + ex.Message;
                    }
                    finally {
                        if (System.IO.File.Exists(tempAudioFilePath)) {
                            System.IO.File.Delete(tempAudioFilePath);
                        }
                    }
                }
                if (folderMode.Checked == true) {
                    string[] targetedFiles = Directory.GetFiles(txtFilePath.Text);
                    string ffmpegPath = "ffmpeg.exe";
                    string tempAudioFilePath = "temp_audio.mp3";
                    if (string.IsNullOrWhiteSpace(targetedFiles[0]) || !System.IO.File.Exists(targetedFiles[0])) {
                        lblStatus.Text = "Please select a valid MP4 file. ";
                        return;
                    }
                    for (int i = 0; i < targetedFiles.Length; i++) {
                        try {
                            string inputFilePath = targetedFiles[i];
                            string outputFilePath = Path.Combine(outputFolderPath, Path.GetFileNameWithoutExtension(targetedFiles[i]) + ".wav");
                            lblStatus.Text = "Extracting audio...";
                            ExtractAudioFromMp4(ffmpegPath, inputFilePath, tempAudioFilePath);
                            lblStatus.Text = "Converting to WAV...";
                            ConvertMp3ToWav(tempAudioFilePath, outputFilePath);
                            lblStatus.Text = "Conversion complete: " + outputFilePath;
                        }
                        catch (Exception ex) {
                            lblStatus.Text = "An error occurred: " + ex.Message;
                        }
                        finally {
                            if (System.IO.File.Exists(tempAudioFilePath)) {
                                System.IO.File.Delete(tempAudioFilePath);
                            }
                        }
                    }
                }
            }
            if (convertTo.Text == "MP3" && convertFrom.Text == "MP4") {
                string ffmpegPath = "ffmpeg.exe";
                string inputFilePath = txtFilePath.Text;
                string outputFilePath = Path.ChangeExtension(inputFilePath, ".mp3");
                if (string.IsNullOrWhiteSpace(inputFilePath) || !System.IO.File.Exists(inputFilePath)) {
                    lblStatus.Text = "Please select a valid MP4 file. ";
                    return;
                }
                try {
                    lblStatus.Text = "Extracting audio...";
                    ExtractAudioFromMp4(ffmpegPath, inputFilePath, outputFilePath);
                    lblStatus.Text = "Conversion complete: " + outputFilePath;
                }
                catch (Exception ex) {
                    lblStatus.Text = "An error occurred: " + ex.Message;
                }
            }
        }

        private void convertFrom_SelectedIndexChanged(object sender, EventArgs e) {
            convertTo.Items.Clear();
            string[] MP4ToWAVConversionOptions = ["WAV", "MP3"];
            if (convertFrom.Text == "MP4") {
                convertTo.Items.AddRange(MP4ToWAVConversionOptions);
            }
        }
    }
}