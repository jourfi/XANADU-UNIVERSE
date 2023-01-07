using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xanadu_universe
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        class DD
        {
            private Label reply;
            public static void speakfrench(Label reply)
            {
                reply.Text = "I can't Speak French!";
            }

            public static void eat(Label reply)
            {
                reply.Text = "I can't eat!";
            }
            public static void sing(Label reply)
            {
                reply.Text = "I can sing when i socialiaze!";
            }
            public static void snore(Label reply)
            {
                reply.Text = "I can't snore!";
            }
            public static void icodecsharp(Label reply)
            {
                reply.Text = "I can't code in C#";
            }
            public static void dance(Label reply)
            {
                reply.Text = "I can dance when I socialize";
            }
        }

        class NN : DD
        {
            private Label reply;
            public static void sing(Label reply)
            {

                reply.Text = "I like to sing when i socialize!";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            NN.speakfrench(reply);
        }




        private void button7_Click(object sender, EventArgs e)
        {
            NN.sing(reply);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NN.eat(reply);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NN.snore(reply);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NN.icodecsharp(reply);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NN.dance(reply);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    
        class ZZ : NN
        {
            public static void snore(Label reply)
            {
                reply.Text = "I snore Loudly!";
            }




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DD.speakfrench(reply);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DD.eat(reply);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DD.snore(reply);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DD.icodecsharp(reply);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DD.dance(reply);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            DD.sing(reply);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string userinput1 = user_input.Text;
            string userinput = userinput1.ToLower();

            if (userinput.Contains("sing") || userinput.Contains("opera"))
            {
                DD.sing(reply);
            }
            else if (userinput.Contains("dance"))
            {
                DD.dance(reply);
            }
            else if (userinput.Contains("speak") || userinput.Contains("french"))
            {
                DD.speakfrench(reply);
            }
            else if (userinput.Contains("c#") || userinput.Contains("code"))
            {
                DD.icodecsharp(reply);
            }
            else if (userinput.Contains("snore") || userinput.Contains("sleep"))
            {
                DD.snore(reply);
            }
            else if (userinput.Contains("eat") || userinput.Contains("food"))
            {
                DD.eat(reply);
            }
            else if (userinput.Contains("hello") || userinput.Contains("hi"))
            {
                reply.Text = "Hi!";
            }
            else if (userinput.Contains("ancestor") || userinput.Contains("inherited"))
            {
                reply.Text = "My Ancestor is NN";
            }
            else if (userinput == "")
            {
                reply.Text = "Write Something!";
            }
            else
            {
                reply.Text = "I didn't Understand";
            }
        }
    }
}
