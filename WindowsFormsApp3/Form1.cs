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
namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        int uppy = 1;
        int lineCount = 0;
        private int result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string textcheck = (richTextBox1.Lines[(this.uppy)]);
            if (string.IsNullOrEmpty(textcheck))
            {
                uppy = 0; 
            }
            string text = (richTextBox1.Lines[(this.uppy)]);
            Clipboard.SetText(text);
            SendKeys.Send("^{v}");
            SendKeys.Send("{ENTER}");
            uppy = uppy + 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out result))
            {
                if (int.Parse(textBox1.Text) > 0)
                {
                    timer1.Interval = Convert.ToInt32(textBox1.Text);
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) ;
            {
                if ((myStream = openFileDialog1.OpenFile()) != null) ;
                string strfilename = openFileDialog1.FileName;
                string filetext = File.ReadAllText(strfilename);
                richTextBox1.Text = filetext;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filename = textBox2.Text + ".txt";
            File.WriteAllText(filename, richTextBox1.Text);
        }
    }
}

