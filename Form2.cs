using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using System.Threading;

namespace ClickerC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Form1.GameScore.Score++;
            label1.Text = Convert.ToString(Form1.GameScore.Score);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1.GameScore.Score++;
            label1.Text = Convert.ToString(Form1.GameScore.Score);
        }
        private void ButtonClick_Click(object sender, EventArgs e)
        {
            Form1.GameScore.Score++;
            if (Form3.NewTree1.Tree1 == true)
            {
                timer.Interval = 10000;
                timer.Enabled = true;
            }
            if (Form3.NewTree2.Tree2 == true)
            {
                Form1.GameScore.Score++;
            }
            if (Form3.NewTree3.Tree3 == true)
            {
                timer1.Interval = 5000;
                timer1.Enabled = true;
            }
            label1.Text = Convert.ToString(Form1.GameScore.Score);
        }
        private void ButtonTree_Click(object sender, EventArgs e)
        {
            Form3 Tree = new Form3(label1.Text)
            {
                Size = new Size(819, 493),
                StartPosition = FormStartPosition.CenterScreen
            };
            Tree.Show();
        }
        private void ButtonShop_Click(object sender, EventArgs e)
        {
            Form4 Shop = new Form4(label1.Text)
            {
                Size = new Size(819, 493),
                StartPosition = FormStartPosition.CenterScreen
            };
            Shop.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            string path = @"ПУТЬ К ФАЙЛУ";
            FileStream file1 = new FileStream(path, FileMode.Open);
               file1.Seek(0, SeekOrigin.End);
            using (StreamWriter stream = new StreamWriter(file1))
            {
                stream.Write(Convert.ToString(Form1.GameScore.Score));
                stream.Write(" SCORE");
            }
        }
    }
}
