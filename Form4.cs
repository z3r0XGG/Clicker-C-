using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerC
{
    public partial class Form4 : Form
    {
        public Form4(string data)
        {
            InitializeComponent();
            this.data = data;
            label1.Text = data;
        }
        string data;
        public class NewCase
        {
            public static bool Case1 = false;
            public static bool Case2 = false;
            public static bool Case3 = false;
            public static void CaseFunction()
            {

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Form1.GameScore.Score >= 50)
            { 
            Random rand = new Random();
            int Case = rand.Next(1, 4);
                switch (Case)
                {
                    case 1:
                        NewCase.Case1 = true;
                        Form1.GameScore.Score += 30;
                        label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) + 30);
                        string Message = "+30 SCORE";
                        string Caption = "Приз";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(Message, Caption, buttons);
                        if (result == DialogResult.OK)
                            return;
                        break;
                    case 2:
                        NewCase.Case2 = true;
                        Form1.GameScore.Score += 50;
                        label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) + 70);
                        Message = "+50 SCORE";
                        Caption = "Приз";
                        buttons = MessageBoxButtons.OK;
                        DialogResult result1;
                        result1 = MessageBox.Show(Message, Caption, buttons);
                        if (result1 == DialogResult.OK)
                            return;
                        break;
                    case 3:
                        NewCase.Case3 = true;
                        Form1.GameScore.Score += 70;
                        Message = "+70 SCORE";
                        Caption = "Приз";
                        buttons = MessageBoxButtons.OK;
                        DialogResult result2;
                        result2 = MessageBox.Show(Message, Caption, buttons);
                        if (result2 == DialogResult.OK)
                            return;
                        break;
                }
            }
            else
            {
                string Message = "У ВАС НЕДОСТАТОЧНО ОЧКОВ";
                string Caption = "Упс...";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(Message, Caption, buttons);
                if (result == DialogResult.OK)
                    return;
            }
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
