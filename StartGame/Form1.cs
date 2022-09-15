using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace StartGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create a sound player and load the alert.wav sound, then play it
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.bellSound);
            alertPlayer.Play();

            startLabel.Text = "3"; 
            
            Refresh();
            Thread.Sleep(1000);

            startLabel.Text = "2";

            Refresh();
            Thread.Sleep(1000);

            startLabel.Text = "1";

            Refresh();
            Thread.Sleep(1000);

            startLabel.Text = "go";

            Refresh();
            Thread.Sleep(1000);


        }
    }
}
