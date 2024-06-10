using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using NAudio.Lame;
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
			Random random = new();
			int red = random.Next(0, 256);
			int green = random.Next(0, 256);
			int blue = random.Next(0, 256);
			this.BackColor = Color.FromArgb(red, green, blue);
		}
		private void btnSelectOutputFolder_Click(object sender, EventArgs e) {
            using FolderBrowserDialog folderDialog = new();
            if (folderDialog.ShowDialog() == DialogResult.OK) {
                txtOutputFolderPath.Text = folderDialog.SelectedPath;
            }
        }
		private void btnSelectFile_Click_1(object sender, EventArgs e) {
			if (folderMode.Checked == false) {
				if ((convertTo.Text == "MP3" || convertTo.Text == "WAV") && convertFrom.Text == "MP4") {
					OpenFileDialog openFileDialog = new()
					{
						Filter = "MP4 files (*.mp4)|*.mp4",
						Title = "Select a file for conversion",
					};
					if (openFileDialog.ShowDialog() == DialogResult.OK) {
						txtFilePath.Text = openFileDialog.FileName;
						lblStatus.Text = "File selected: " + openFileDialog.FileName;
					}
				}
				if (convertTo.Text == "MP3" && convertFrom.Text == "WAV") {
					OpenFileDialog openFileDialog = new()
					{
						Filter = "WAV files (*.wav)|*.wav",
						Title = "Select a file for conversion",
					};
					if (openFileDialog.ShowDialog() == DialogResult.OK) {
						txtFilePath.Text = openFileDialog.FileName;
						lblStatus.Text = "File selected: " + openFileDialog.FileName;
					}
				}
			}
			if (folderMode.Checked == true) {
                using FolderBrowserDialog openFileDialog = new();
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    txtFilePath.Text = openFileDialog.SelectedPath;
                    lblStatus.Text = "File selected: " + openFileDialog.SelectedPath;
                }
            }
		}
		private void btnConvert_Click_1(object sender, EventArgs e) {
			conversionLogic();
		}
		private void conversionLogic() {
			// Handles program-wide conversion logic
			void ExtractAudioFromMp4(string ffmpegPath, string inputFilePath, string outputFilePath) {
				var ffmpegProcess = new Process {
					StartInfo = new ProcessStartInfo {
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
			void ConvertMp3ToWav(string inputFilePath, string outputFilePath) {
                // MP3 to WAV conversion process
                using var reader = new Mp3FileReader(inputFilePath);
                using var writer = new WaveFileWriter(outputFilePath, reader.WaveFormat);
                reader.CopyTo(writer);
            }
			void ConvertWavtoMp3(string inputFilePath, string outputFilePath) {
                // WAV to MP3 conversion process
                using var reader = new WaveFileReader(inputFilePath);
                using var writer = new LameMP3FileWriter(outputFilePath, reader.WaveFormat, LAMEPreset.STANDARD);
                reader.CopyTo(writer);
            }
			string outputFolderPath = txtOutputFolderPath.Text;
			if (!folderMode.Checked) {
				// Individual file conversion mode
				string ffmpegPath = "ffmpeg.exe";
				string inputFilePath = txtFilePath.Text;
				if (string.IsNullOrWhiteSpace(inputFilePath) || !System.IO.File.Exists(inputFilePath)) {
					lblStatus.Text = "Please select a valid file for conversion. ";
				}
				if (convertTo.Text == "WAV" && convertFrom.Text == "MP4") {
					// Individual file MP4 to WAV conversion
					string tempAudioFilePath = "temp_audio.mp3";
					string outputFilePath = Path.Combine(outputFolderPath, Path.GetFileNameWithoutExtension(inputFilePath) + ".wav");
					try {
						lblStatus.Text = "Extracting audio...";
						ExtractAudioFromMp4(ffmpegPath, inputFilePath, tempAudioFilePath);
						lblStatus.Text = "Converting to WAV...";
						ConvertMp3ToWav(tempAudioFilePath, outputFilePath);
						lblStatus.Text = "Conversion complete: " + outputFilePath;
					}
					catch(Exception ex) {
						lblStatus.Text = "An error occurred: " + ex.Message;
					}
					finally {
						if (System.IO.File.Exists(tempAudioFilePath)) {
							System.IO.File.Delete(tempAudioFilePath);
						}
					}
				}
				if (convertTo.Text == "MP3" && convertFrom.Text == "MP4") {
                    // Individual file MP4 to MP3 conversion
                    string outputFilePath = Path.Combine(outputFolderPath, Path.GetFileNameWithoutExtension(inputFilePath) + ".mp3");
                    try {
						lblStatus.Text = "Extracting audio...";
						ExtractAudioFromMp4(ffmpegPath, inputFilePath, outputFilePath);
						lblStatus.Text = "Conversion complete: " + outputFilePath;
					}
					catch (Exception ex) {
						lblStatus.Text = "An error occurred: " + ex.Message;
					}
				}
				if (convertTo.Text == "MP3" && convertFrom.Text == "WAV") {
                    // Individual file WAV to MP3 conversion
                    string outputFilePath = Path.Combine(outputFolderPath, Path.GetFileNameWithoutExtension(inputFilePath) + ".mp3");
					try {
						lblStatus.Text = "Extracting audio...";
						ConvertWavtoMp3(inputFilePath, outputFilePath);
						lblStatus.Text = "Conversion complete: " + outputFilePath;
					}
					catch(Exception ex) {
						lblStatus.Text = "An error occurred: " + ex.Message;
					}
                }
			}
			if (folderMode.Checked) {
				// Full folder conversion mode
				string[] targetedFiles = Directory.GetFiles(txtFilePath.Text);
				string ffmpegPath = "ffmpeg.exe";
				string tempAudioFilePath = "temp_audio.mp3";
				if (string.IsNullOrWhiteSpace(targetedFiles[0]) || !System.IO.File.Exists(targetedFiles[0])) {
					lblStatus.Text = "Please select a valid folder for conversion. ";
					return;
				}
				if (convertTo.Text == "WAV" && convertFrom.Text == "MP4") {
					// Full folder MP4 to WAV conversion mode
					for (int i = 0; i < targetedFiles.Length; i++) {
						try {
							string inputFilePath = targetedFiles[i];
							string outputFilePath = Path.Combine(outputFolderPath, Path.GetFileNameWithoutExtension(targetedFiles[i]) + ".wav");
							lblStatus.Text = "Extracting audio...";
							ExtractAudioFromMp4(ffmpegPath, inputFilePath, tempAudioFilePath);
							lblStatus.Text = "Converting to WAV...";
							ConvertMp3ToWav(tempAudioFilePath, outputFilePath);
							Thread.Sleep(500);
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
				if (convertTo.Text == "MP3" && convertFrom.Text == "MP4") {
					// Full folder MP4 to MP3 conversion mode
					for (int i = 0; i < targetedFiles.Length; i++) {
						try {
							string inputFilePath = targetedFiles[i];
							string outputFilePath = Path.Combine(outputFolderPath, Path.GetFileNameWithoutExtension(targetedFiles[i]) + ".mp3");
							lblStatus.Text = "Extracting audio... ";
							ExtractAudioFromMp4(ffmpegPath, inputFilePath, outputFilePath);
							lblStatus.Text = "Conversion complete: " + outputFilePath;
							Thread.Sleep(500);
						}
						catch (Exception ex) {
							lblStatus.Text = "An error occurred: " + ex.Message;
						}
					}
				}
				if (convertTo.Text == "MP3" && convertFrom.Text == "WAV") {
					// Full folder WAV to MP3 conversion mode
					for (int i = 0; i < targetedFiles.Length; i++) {
						try {
							string inputFilePath = targetedFiles[i];
                            string outputFilePath = Path.Combine(outputFolderPath, Path.GetFileNameWithoutExtension(targetedFiles[i]) + ".mp3");
							lblStatus.Text = "Extracting audio...";
							ConvertWavtoMp3(inputFilePath, outputFilePath);
							lblStatus.Text = "Conversion complete: " + outputFilePath;
                        }
						catch (Exception ex) {
							lblStatus.Text = "An error occurred: " + ex.Message;
						}
					}
				}
			}
		}
		private void convertFrom_SelectedIndexChanged(object sender, EventArgs e) {
			// Handles drop down menu contents
			convertTo.Items.Clear();
			string[] WAVConversionOptions = ["MP3"];
			string[] MP4ConversionOptions = ["WAV", "MP3"];
			if (convertFrom.Text == "MP4") {
				convertTo.Items.AddRange(MP4ConversionOptions);
			}
			if (convertFrom.Text == "WAV") {
				convertTo.Items.AddRange(WAVConversionOptions);
			}
		}
	}
}