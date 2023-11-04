using LibVLCSharp.Shared;
using System.Timers;
using System.Windows.Forms;

namespace SimpleMediaPlayer
{
    public partial class Form1 : Form
    {
        public LibVLC _libVLC;
        public LibVLCSharp.Shared.MediaPlayer _mp;
        bool clicked;
        bool fullscreen = false;
        string path = "";
        FormWindowState last_state = FormWindowState.Normal;
        System.Timers.Timer timer = new System.Timers.Timer();
        public Form1()
        {
            if (!DesignMode)
            {
                Core.Initialize();
            }
            InitializeComponent();

            _libVLC = new LibVLC();
            _mp = new LibVLCSharp.Shared.MediaPlayer(_libVLC);
            videoView1.MediaPlayer = _mp;

            _mp.Playing += OnPlaying;
            _mp.Paused += OnPaused;
        }

        #region События формы
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 200;
            timer.Elapsed += Timer_Elapsed;

            //var media = new Media(_libVLC, new Uri("C:\\Users\\novok\\Downloads\\2.mp4"));
            //_mp.Play(media);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mp.Stop();
            _mp.Dispose();
            _libVLC.Dispose();
        }
        #endregion

        #region События плеера
        private void OnPlaying(object sender, EventArgs e)
        {
            timer.Start();
            int length_s = Convert.ToInt32(_mp.Length / 1000);
            metroTrackBar1.Maximum = length_s;

            _mp.EnableKeyInput = false;
            _mp.EnableMouseInput = false;

        }

        private void OnPaused(object sender, EventArgs e)
        {
            timer.Stop();
        }
        #endregion

        #region События видео
        private async void VideoView1_Click(object? sender, EventArgs e)
        {
            if (clicked) return;
            clicked = true;
            await Task.Delay(SystemInformation.DoubleClickTime);
            if (!clicked) return;
            clicked = false;

            if (_mp.IsPlaying)
            {
                _mp.Pause();
            }
            else
            {
                _mp.Play();
            }

        }

        private void VideoView1_DoubleClick(object? sender, EventArgs e)
        {
            clicked = false;
            if (fullscreen)
            {
                fullscreen = false;

                menuStrip1.Visible = true;
                toolStrip1.Visible = true;
                metroTrackBar1.Visible = true;

                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = last_state;
            }
            else
            {
                fullscreen = true;
                last_state = this.WindowState;

                menuStrip1.Visible = false;
                toolStrip1.Visible = false;
                metroTrackBar1.Visible = false;

                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        #endregion

        #region События Menu
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV,*.webm";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                var media = new Media(_libVLC, new Uri(path));
                this.Text = Path.GetFileNameWithoutExtension(path);
                _mp.Play(media);
            }
        }
        #endregion

        #region Tool
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _mp.Play();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            _mp.Pause();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (_mp.Mute)
            {
                toolStripButton3.Image = Properties.Resources.unmute;
            }
            else
            {
                toolStripButton3.Image = Properties.Resources.mute;
            }
            _mp.ToggleMute();
        }
        #endregion

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            TimeSpan t = TimeSpan.FromMilliseconds(_mp.Time);
            int time_s = Convert.ToInt32(_mp.Time / 1000);

            if (toolStripTextBox1.Control.InvokeRequired)
            {
                toolStripTextBox1.Control.Invoke((MethodInvoker)delegate
                {
                    toolStripTextBox1.Text = t.ToString(@"hh\:mm\:ss");
                });
            }
            else
            {
                toolStripTextBox1.Text = t.ToString(@"hh\:mm\:ss");
            }

            if (metroTrackBar1.InvokeRequired)
            {
                metroTrackBar1.Invoke((MethodInvoker)delegate
                {
                    metroTrackBar1.Value = time_s;
                });
            }
            else
            {
                metroTrackBar1.Value = time_s;
            }
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            _mp.Time = metroTrackBar1.Value * 1000;
            TimeSpan t = TimeSpan.FromMilliseconds(_mp.Time);
            toolStripTextBox1.Text = t.ToString(@"hh\:mm\:ss");
        }


    }
}