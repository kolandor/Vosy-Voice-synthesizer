using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOICE_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SpeechSynthesizer _voice;

        private Thread _threadSpeech;

        private ReadOnlyCollection<InstalledVoice> collectionVoices;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_threadSpeech == null)
                {
                    _threadSpeech = new Thread(Say);

                    _threadSpeech.IsBackground = true;

                    _threadSpeech.Start(mainText.Text);

                    buttonSay.Text = @"STOP";
                }
                else
                {
                    _threadSpeech.Abort();

                    buttonSay.Text = @"START";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Say(object objString)
        {
            try
            {
                _voice.Speak((string)objString);
            }
            catch (ThreadAbortException)
            {
                ShowText("Voice stoped", _voice.Voice.Name);
                _voice.Dispose();
                _voice = new SpeechSynthesizer();
                comboBox1_SelectedIndexChanged(null, null);
                trackBarVoiceSpeed_Scroll(null, null);
            }
            finally
            {
                _threadSpeech = null;
                this.Invoke(new Action(() => buttonSay.Text = @"START"));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _voice = new SpeechSynthesizer();

            trackBarVoiceSpeed_Scroll(null, null);

            collectionVoices = _voice.GetInstalledVoices();

            foreach (var v in collectionVoices)
            {
                comboBoxVoices.Items.Add(v.VoiceInfo.Name);
            }

            if (comboBoxVoices.Items.Count > 0)
            {
                int index = 0;

                for (int i = 0; i < comboBoxVoices.Items.Count; i++)
                {
                    if (comboBoxVoices.Items[i].ToString().ToLower().Contains("maxim"))
                    {
                        index = i;
                        break;
                    }
                }

                comboBoxVoices.SelectedIndex = index;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentVoiceName = comboBoxVoices.SelectedItem.ToString();
            

            foreach (var v in collectionVoices)
            {
                if (v.VoiceInfo.Name == currentVoiceName)
                {
                    _voice.SelectVoice(v.VoiceInfo.Name);
                    break;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {

                //Voice SYNTESIER Object
                SpeechSynthesizer synth = new SpeechSynthesizer();

                // Saving file path
                synth.SetOutputToWaveFile(@"Sample.wav");

                synth.SelectVoice(comboBoxVoices.SelectedItem.ToString());

                //Event after voice generate
                synth.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synth_SpeakCompleted);

                //Thread builder get text from text box
                PromptBuilder builder = new PromptBuilder();
                builder.AppendText(mainText.Text);

                //start async voice generating 
                synth.SpeakAsync(builder);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //BalloonTip notifier
        static void ShowText(string title = "Title", string text = "Text", int time = 2000)
        {
            notifyIconMessage.Visible = true;
            notifyIconMessage.BalloonTipTitle = title;
            notifyIconMessage.BalloonTipText = text;
            notifyIconMessage.ShowBalloonTip(time);
            notifyIconMessage.Visible = false;
        }

        
        static void synth_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            ShowText("Process finished", "You can enjoy your Sample");
            

            (sender as SpeechSynthesizer)?.Dispose();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("HELP.txt");
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer: Kolandor \nLicense: there is no license, it's free:-)");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VOICE SYNTESIER 2017\n Alpha 0.1");
        }

        private void trackBarVoiceSpeed_Scroll(object sender, EventArgs e)
        {
            _voice.Rate = trackBarVoiceSpeed.Value;
        }
    }
}
