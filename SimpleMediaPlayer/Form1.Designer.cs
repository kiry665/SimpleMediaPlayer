namespace SimpleMediaPlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            синхронизацияToolStripMenuItem = new ToolStripMenuItem();
            подключитьсяToolStripMenuItem = new ToolStripMenuItem();
            отключитьсяToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripButton3 = new ToolStripButton();
            metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.Black;
            videoView1.Dock = DockStyle.Fill;
            videoView1.Location = new Point(0, 33);
            videoView1.Margin = new Padding(0);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(800, 450);
            videoView1.TabIndex = 0;
            videoView1.Text = "videoView1";
            videoView1.Click += VideoView1_Click;
            videoView1.DoubleClick += VideoView1_DoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, синхронизацияToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(69, 29);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(184, 34);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // синхронизацияToolStripMenuItem
            // 
            синхронизацияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { подключитьсяToolStripMenuItem, отключитьсяToolStripMenuItem, настройкиToolStripMenuItem });
            синхронизацияToolStripMenuItem.Name = "синхронизацияToolStripMenuItem";
            синхронизацияToolStripMenuItem.Size = new Size(156, 29);
            синхронизацияToolStripMenuItem.Text = "Синхронизация";
            // 
            // подключитьсяToolStripMenuItem
            // 
            подключитьсяToolStripMenuItem.Name = "подключитьсяToolStripMenuItem";
            подключитьсяToolStripMenuItem.Size = new Size(234, 34);
            подключитьсяToolStripMenuItem.Text = "Подключиться";
            подключитьсяToolStripMenuItem.Click += подключитьсяToolStripMenuItem_Click;
            // 
            // отключитьсяToolStripMenuItem
            // 
            отключитьсяToolStripMenuItem.Name = "отключитьсяToolStripMenuItem";
            отключитьсяToolStripMenuItem.Size = new Size(234, 34);
            отключитьсяToolStripMenuItem.Text = "Отключиться";
            отключитьсяToolStripMenuItem.Click += отключитьсяToolStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(234, 34);
            настройкиToolStripMenuItem.Text = "Настройки";
            настройкиToolStripMenuItem.Click += настройкиToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.AllowMerge = false;
            toolStrip1.BackColor = Color.White;
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripTextBox1, toolStripButton3 });
            toolStrip1.Location = new Point(0, 511);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.ShowItemToolTips = false;
            toolStrip1.Size = new Size(800, 33);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.BackColor = Color.White;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.play;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.pause;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.BackColor = Color.White;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new Size(100, 33);
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.unmute;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(34, 28);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // metroTrackBar1
            // 
            metroTrackBar1.BackColor = Color.White;
            metroTrackBar1.Dock = DockStyle.Bottom;
            metroTrackBar1.Location = new Point(0, 483);
            metroTrackBar1.Maximum = 1;
            metroTrackBar1.Name = "metroTrackBar1";
            metroTrackBar1.Size = new Size(800, 28);
            metroTrackBar1.SmallChange = 10;
            metroTrackBar1.TabIndex = 3;
            metroTrackBar1.TabStop = false;
            metroTrackBar1.Text = "metroTrackBar1";
            metroTrackBar1.Value = 0;
            metroTrackBar1.Scroll += metroTrackBar1_Scroll;
            metroTrackBar1.MouseEnter += metroTrackBar1_MouseEnter;
            metroTrackBar1.MouseLeave += metroTrackBar1_MouseLeave;
            metroTrackBar1.MouseUp += metroTrackBar1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 544);
            Controls.Add(videoView1);
            Controls.Add(metroTrackBar1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripTextBox toolStripTextBox1;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private ToolStripButton toolStripButton3;
        private ToolStripMenuItem синхронизацияToolStripMenuItem;
        private ToolStripMenuItem подключитьсяToolStripMenuItem;
        private ToolStripMenuItem отключитьсяToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
    }
}