using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using Bulls_And_Cows;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        IBulls_And_Cows comb;
        Answer ans;
        int iter;
        
        public Form1()
        {
            InitializeComponent();
            ChannelFactory<IBulls_And_Cows> factory = new ChannelFactory<IBulls_And_Cows>(new WSHttpBinding());
            comb = factory.CreateChannel(new EndpointAddress("http://localhost:8088/Bulls_And_Cows/Combination/"));
            iter = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ans = comb.GetAnswer(textBox1.Text);
            textBox2.Text += ans.result.ToString()  + Environment.NewLine;
            if (ans.result.Substring(0, 8).Equals("You lose"))
            {
                button3_Click(null,null);

            }
            else {
                textBox2.Text += ans.ToString().Substring(0, 8);
            }//iter.ToString() + ".  " + textBox1.Text + " " + ans.Bulls.ToString() + 
                                                        //"B " + 
            iter++;
            //if (ans.Bulls == 4) button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comb.GetCombination();
            textBox2.Text += "Я загадал, готов проиграть?" + Environment.NewLine;
            label1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
            button2.Enabled = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://rs1img.memecdn.com/now-who-wants-boobs_o_1020089.jpg");            
        }
    }
}
