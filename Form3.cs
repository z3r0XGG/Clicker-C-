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
    public partial class Form3 : Form
    {
        public Form3(string data)
        {
            InitializeComponent();
            this.data = data;
            label1.Text = data;
            Convert.ToInt32(label1.Text);
        }
        string data;

        public class NewTree1
        {
            public static bool Tree1 = false;
            public static void TreeFunction()
            {

            }

        }
        public class NewTree2
        {
            public static bool Tree2 = false;
            public static void TreeFunction()
            {

            }

        }
        public class NewTree3
        {
            public static bool Tree3 = false;
            public static void TreeFunction()
            {

            }

        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ButtonTree1_Click(object sender, EventArgs e)
        {
            if (NewTree1.Tree1 == true)
            {
                string Message = "У ВАС УЖЕ ЕСТЬ ЭТО УЛУЧШЕНИЕ";
                string Caption = "Упс...";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(Message, Caption, buttons);
                if (result == DialogResult.OK)
                    return;
            }
            else if (Form1.GameScore.Score >= 25)
            {
                NewTree1.Tree1 = true;
                Form1.GameScore.Score -= 25;
                label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - 25);
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

        private void ButtonTree2_Click(object sender, EventArgs e)
        {
            if (NewTree2.Tree2 == true)
            {
                string Message = "У ВАС УЖЕ ЕСТЬ ЭТО УЛУЧШЕНИЕ";
                string Caption = "Упс...";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(Message, Caption, buttons);
                if (result == DialogResult.OK)
                    return;
            }
            else if (Form1.GameScore.Score >= 50)
            {
                NewTree2.Tree2 = true;
                Form1.GameScore.Score -= 50;
                label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - 50);
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

        private void ButtonTree3_Click(object sender, EventArgs e)
        {
            if (NewTree3.Tree3 == true)
            {
                string Message = "У ВАС УЖЕ ЕСТЬ ЭТО УЛУЧШЕНИЕ";
                string Caption = "Упс...";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(Message, Caption, buttons);
                if (result == DialogResult.OK)
                    return;
            }
            else if (Form1.GameScore.Score >= 75)
            {
                NewTree3.Tree3 = true;
                Form1.GameScore.Score -= 75;
                label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - 75);
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
    }
}
