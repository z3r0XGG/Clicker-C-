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

namespace ClickerC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class GameScore
        {
            public static int Score = 0;
            public static void ScoreFunction()
            {

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
        }
        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            string Nick = textBox1.Text;
            string path = @"ПУТЬ К ФАЙЛУ";
            using (FileStream file = new FileStream(path, FileMode.Append))
                file.Close();
            using (StreamReader Check = new StreamReader(path, Encoding.Default))
            {
                string Text = Check.ReadToEnd();
                Check.Close();
                if (Text.IndexOf(Nick) > -1)
                {
                    string Message = "Нажмите ДА, чтобы изменить никнейм и продолжить играть\nНажмите НЕТ, чтобы закрыть программу";
                    string Caption = "Вы ввели никнейм, который уже сущетсвует в базе";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(Message, Caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        textBox1.Clear();
                        return;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    FileStream file1 = new FileStream(path, FileMode.Open);
                    file1.Seek(0, SeekOrigin.End);
                    using (StreamWriter stream = new StreamWriter(file1))
                        stream.WriteLine(Nick);
                }
            }
            Form2 Enter = new Form2
            {
                Size = new Size(819, 493),
                StartPosition = FormStartPosition.CenterScreen
            };
            Enter.Show();
            Hide();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                ButtonEnter.PerformClick();
            }

        }
    }
}

