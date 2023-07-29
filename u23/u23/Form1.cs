using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace u23
{
    public partial class microphone : Form
    {
        SpeechSynthesizer reader;
        //SpeechSynthesizer synthesizer;
        private bool isDarkMode = false;
        private SpeechRecognitionEngine recognizer;
        public microphone()
        {
            InitializeComponent();

            reader = new SpeechSynthesizer();

            InitializeSpeechRecognition();
        }

        private void InitializeSpeechRecognition()
        {
            recognizer = new SpeechRecognitionEngine();
            recognizer.LoadGrammar(new DictationGrammar());
            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Recognizer_AudioStateChanged(object sender, AudioStateChangedEventArgs e)
        {
            if (e.AudioState == AudioState.Silence)
            {
                recognizer.SetInputToDefaultAudioDevice();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reader = new SpeechSynthesizer();
            pauseButton.Enabled = false;
            resumeButton.Enabled = false;
            stopButton.Enabled = false;
            textBox1.ScrollBars = ScrollBars.Both;
            micophoneButton.Click += micophoneButton_Click;
            
        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string recognizedText = e.Result.Text;
            textBox1.Text += recognizedText + " ";
        }

        private void micophoneButton_Click(object sender, EventArgs e)
        {
            StartRecognition();
        }

        private void StartRecognition()
        {
            textBox1.Text = "";
            recognizer.RecognizeAsync();
        }

        private void microphone_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(textBox1.Text);
                pauseButton.Enabled = true;
                stopButton.Enabled = true;
                reader.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(reader_SpeakCompleted);
            }
            else
            {
                MessageBox.Show("Please enter some text in the textbox", "Message", MessageBoxButtons.OK);
            }
        }

        private void reader_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Speaking)
                {
                    reader.Pause();
                    resumeButton.Enabled = true;
                }
            }
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Resume();
                }
                resumeButton.Enabled = false;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                reader.Dispose();
                pauseButton.Enabled = false;
                resumeButton.Enabled = false;
                stopButton.Enabled = false;
            }
        }

        private void inputLabel_Click(object sender, EventArgs e)
        {
            //input label code
        }

        private void changeTheme_Click(object sender, EventArgs e)
        {
                isDarkMode = !isDarkMode;

                if (isDarkMode)
                {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                settingsButton.ForeColor = Color.Black;
                changeTheme.ForeColor = Color.Black;
                }
                else
                {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                settingsButton.ForeColor = Color.Black;
                changeTheme.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
    }
}
