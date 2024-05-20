using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;

namespace MP4_to_WAV_Converter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            if (File.Exists("temp_audio.mp3")) {
                File.Delete("temp_audio.mp3");
            }
            this.Load += new EventHandler(Form1_Load);
        }
        private void Form1_Load(object sender, EventArgs e) {
            // Generate a random color
            Random random = new Random();
            int red = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue = random.Next(0, 256);

            // Set the form's background color to the random color
            this.BackColor = Color.FromArgb(red, green, blue);
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
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "MP4 files (*.mp4)|*.mp4",
                Title = "Select an MP4 file"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                txtFilePath.Text = openFileDialog.FileName;
                lblStatus.Text = "File selected: " + openFileDialog.FileName;
            }
        }

        private void btnConvert_Click_1(object sender, EventArgs e) {
            if (convertTo.Text == "WAV" || convertFrom.Text == "MP4") {
                string ffmpegPath = "ffmpeg.exe";
                string inputFilePath = txtFilePath.Text;
                string tempAudioFilePath = "temp_audio.mp3";
                string outputFilePath = Path.ChangeExtension(inputFilePath, ".wav");

                if (string.IsNullOrWhiteSpace(inputFilePath) || !File.Exists(inputFilePath)) {
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
                    if (File.Exists(tempAudioFilePath)) {
                        File.Delete(tempAudioFilePath);
                    }
                }
            }
        }

        private void convertFrom_SelectedIndexChanged(object sender, EventArgs e) {
            string[] MP4ToWAVConversionOptions = ["WAV", "MP3"];
            if (convertFrom.Text == "MP4") {
                convertTo.Items.AddRange(MP4ToWAVConversionOptions);
            }
        }
    }
}
