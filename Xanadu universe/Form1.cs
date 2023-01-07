using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xanadu_universe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
           
        }
        public void IspeakFrench()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\audio.wav";
            player.Play();
        }
        public void sing()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\audio.wav";
            player.Play();
        }
        public void snore()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\audio.wav";
            player.Play();
        }
        class YY
        {
            public void speak()
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"C:\audio.wav";
                player.Play();
            }
            public void eat()
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"C:\audio.wav";
                player.Play();
            }
            public void dance()
            {
             

            }

        }
        class ZZ
        {
            public void dance()
            {
              



            }
            public void sing()
            {

            }


        }

        class NN : ZZ
        {


        }

     
        class DD : NN
        {
            public void speak()
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"C:\audio.wav";
                player.Play();
            }
            public void eat()
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"C:\audio.wav";
                player.Play();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
