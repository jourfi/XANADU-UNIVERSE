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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        class ZZ
        {
            private Label reply;
            public static void speakfrench(Label reply)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"zz/speak.wav";
                player.Load();
                player.Play();
                reply.Text = "I can't Speak French!";
            }

            public static void eat(Label reply)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"zz/eat.wav";
                player.Load();
                player.Play();
                reply.Text = "I can't eat!";
            }
            public static void sing(Label reply)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"zz/sing.wav";
                player.Load();
                player.Play();
                reply.Text = "I can sing when i socialiaze!";
            }
            public static void snore(Label reply)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"zz/snore.wav";
                player.Load();
                player.Play();
                reply.Text = "I can't snore!";
            }
            public static void icodecsharp(Label reply)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"zz/c#.wav";
                player.Load();
                player.Play();
                reply.Text = "I can't code in C#";
            }
            public static void dance(Label reply)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"zz/dance.wav";
                player.Load();
                player.Play();
                reply.Text = "I can dance when I socialize";
            }
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            ZZ.speakfrench(reply);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZZ.eat(reply);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZZ.snore(reply);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ZZ.icodecsharp(reply);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"zz/hello.wav";
            player.Load();
            player.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
                ZZ.dance(reply);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ZZ.sing(reply);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
  
        private void button8_Click(object sender, EventArgs e)
        {
            string userinput1 = user_input.Text;
            string userinput = userinput1.ToLower();

            if (userinput.Contains("sing") || userinput.Contains("opera"))
            {
                ZZ.sing(reply);
            }
            else if (userinput.Contains("dance"))
            {
                ZZ.dance(reply);
            }
            else if (userinput.Contains("speak") || userinput.Contains("french"))
            {
                ZZ.speakfrench(reply);
            }
            else if (userinput.Contains("c#") || userinput.Contains("code"))
            {
                ZZ.icodecsharp(reply);
            }
            else if (userinput.Contains("snore") || userinput.Contains("sleep"))
            {
                ZZ.snore(reply);
            }
            else if (userinput.Contains("eat") || userinput.Contains("food"))
            {
                ZZ.eat(reply);
            }
            else if (userinput.Contains("ancestor") || userinput.Contains("inherit"))
            {
                reply.Text = "I don't Have Any.";
            }
            else if (userinput.Contains("hello") || userinput.Contains("hi"))
            {
                reply.Text = "Hi!";
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"zz/hi.wav";
                player.Load();
                player.Play();
            }
            else if (userinput == "")
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"zz/empty.wav";
                player.Load();
                player.Play();
                reply.Text = "Write Something!";

            }
            else
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"zz/noreply.wav";
                player.Load();
                player.Play();
                reply.Text = "I didn't Understand";
            }
        }
        }
    }


