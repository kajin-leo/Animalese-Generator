using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Animalese_Generator
{
    public partial class MainForm : Form
    {
        public string tone = "Boy";
        public MainForm()
        {
            InitializeComponent();
        }

        private void pitchTrackBar_Scroll(object sender, EventArgs e)
        {
            string valueNow = (pitchTrackBar.Value * 2).ToString();
            string indicatorText = pitchValueIndicator.Text.Remove(pitchValueIndicator.Text.Length - 2, 2);
            pitchValueIndicator.Text = indicatorText + valueNow;
        }

        private void combineWav(List<String> inputFiles, string outputName)
        {
            WaveStream waveStream = WaveFormatConversionStream.CreatePcmStream(new WaveFileReader(inputFiles[0]));
            using (WaveFileWriter waveFileWriter = new WaveFileWriter(outputName, waveStream.WaveFormat))
            {
                foreach (string file in inputFiles)
                {
                    waveStream = WaveFormatConversionStream.CreatePcmStream(new WaveFileReader(file));
                    byte[] bytes = new byte[waveStream.Length];
                    waveStream.Position = 141;
                    waveStream.Read(bytes, 0, (int)waveStream.Length);
                    try { waveFileWriter.Write(bytes, 0, 14100 / 3 * 2); } catch {
                        MessageBox.Show(Properties.strings.saveFailed, Properties.strings.saveError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            string resourcesPath = Path.Combine(projectPath, "Resources");
            List<string> vowelsExample = new List<string> { "a", "e", "i", "o", "u" };
            if (vowelsTextBox.Text.Replace(" ", "") == "")
            {
                MessageBox.Show(Properties.strings.noVowels, Properties.strings.vowelsError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] vowels = vowelsTextBox.Text.Split(' ');
            for(int i = 0; i < vowels.Length; i++)
            {
                if(vowels[i].Length > 1)
                {
                    MessageBox.Show(Properties.strings.vowelsInputIncorrect, Properties.strings.vowelsError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!vowelsExample.Contains(vowels[i]) && vowels[i] != "")
                {
                    MessageBox.Show(Properties.strings.vowelsInputIncorrect, Properties.strings.vowelsError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            List<string> processedVowels = new List<string>(vowels);
            for(int i = processedVowels.Count - 1; i >= 0; i--)
            {
                processedVowels.Remove("");
            }
            List<string> fileNames = new List<string> { };
            for(int i = 0; i < processedVowels.Count; i++)
            {
                /*
                if(processedVowels[i].ToUpper() == "I" || processedVowels[i].ToUpper() == "O")
                {
                    Random random = new Random();
                    int randomNum = random.Next(0, 2);
                    switch (randomNum)
                    {
                        case 0:
                            processedVowels[i] += "Low";
                            break;
                    }
                }
                */
                string currentFileName = tone + "\\Npc_Vocal_" + tone + "_" + processedVowels[i].ToUpper() + "_" + (pitchTrackBar.Value * 2).ToString() + " [1].wav";
                string fullPathName = Path.Combine(resourcesPath, currentFileName);
                fileNames.Add(fullPathName);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "|*.wav";
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.Cancel) return;
            string outputName = saveFileDialog.FileName;
            combineWav(fileNames, outputName);
        }

        private void boyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (boyRadioButton.Checked == true)
                tone = "Boy";
        }

        private void girlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (girlRadioButton.Checked == true)
                tone = "Girl";
        }

        private void manRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (manRadioButton.Checked == true)
                tone = "Man";
        }
    }
}
