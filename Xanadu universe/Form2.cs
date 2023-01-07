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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
      

        class YY
        {
            private Label reply;
            public static void speakfrench(Label reply)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"yy/speak.wav";
                player.Load();
                player.Play();
                reply.Text = "I can Speak French";
            }
  
            public static void eat(Label reply)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"yy/eat.wav";
                player.Load();
                player.Play();
                reply.Text = "I can eat";
            }
            public static void sing(Label reply)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"yy/sing.wav";
                player.Load();
                player.Play();
                reply.Text = "I can't Sing";
            }
            public static void snore(Label reply)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"yy/snore.wav";
                player.Load();
                player.Play();
                reply.Text = "I don't snore";
            }
            public static void icodecsharp(Label reply)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"yy/c#.wav";
                player.Load();
                player.Play();
                reply.Text = "I can't Code";
            }
            public static void dance(Label reply)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"yy/dance.wav";
                player.Load();
                player.Play();
                reply.Text = "I can't Dance!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            YY.speakfrench(reply);
        }
       


        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void humanoid_reply_Click(object sender, EventArgs e)
        {

        }


        private void button8_Click(object sender, EventArgs e)
        {
            string userinput1 = user_input.Text;
            string userinput = userinput1.ToLower();

            if (userinput.Contains("sing") || userinput.Contains("opera"))
            {
            
                YY.sing(reply);
            } else if (userinput.Contains("dance"))

            {
              
                YY.dance(reply);
            }
            else if (userinput.Contains("ancestor") || userinput.Contains("inherit"))
            {
                reply.Text = "I don't have any ancestor!";
            }
            else if (userinput.Contains("speak") || userinput.Contains("french"))
            {
              
                YY.speakfrench(reply);
            }
            else if (userinput.Contains("c#") || userinput.Contains("code"))
            {
                
                YY.icodecsharp(reply);
            }
            else if (userinput.Contains("snore") || userinput.Contains("sleep"))
            {
               
                YY.snore(reply);
            }
            else if (userinput.Contains("eat") || userinput.Contains("food"))
            {
              
                YY.eat(reply);
            }
            else if (userinput.Contains("hello") || userinput.Contains("hi"))
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"yy/hi.wav";
                player.Load();
                player.Play();
                reply.Text = "Hi!";
            }
            else if (userinput=="")
            {
                Random random = new Random();
                string rnd_reply = Convert.ToString(random.Next(1, 3));
                if(rnd_reply == "1")
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"yy/empty.wav";
                    player.Load();
                    player.Play();
                    reply.Text = "Write Something!";
                } else if(rnd_reply == "2")
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"yy/empty_2.wav";
                    player.Load();
                    player.Play();
                    reply.Text = "Write a valid Question!";
                } else
                {
                    reply.Text = "Write Something!";
                }

                
            }
            else
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"yy/noreply.wav";
                player.Load();
                player.Play();
                reply.Text = "I don't Understand";
            }

        }

        private void user_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"yy/hello.wav";
            player.Load();
            player.Play();
        }
    }
   
}

