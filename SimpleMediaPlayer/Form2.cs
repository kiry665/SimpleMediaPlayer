using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Configuration;
using System.Collections;
using System.Resources;
using SimpleMediaPlayer.Properties;

namespace SimpleMediaPlayer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.Text = Settings.Default.portClient.ToString();
            textBox3.Text = Settings.Default.ipServer;
            textBox4.Text = Settings.Default.portServer.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.portClient = Convert.ToInt32(textBox2.Text);
            Settings.Default.ipServer = textBox3.Text;
            Settings.Default.portServer = Convert.ToInt32(textBox4.Text);
            Settings.Default.Save();
        }

        
    }
}
