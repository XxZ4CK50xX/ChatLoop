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

        int uppy = 0;

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
            SendKeys.Send(richTextBox1.Lines[(this.uppy)]);
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
            timer1.Interval = Convert.ToInt32(textBox1.Text);
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
    }
}

<<<<<<< HEAD
        private void button5_Click(object sender, EventArgs e)
        {
            SafeFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save File";
            saveFileDialog.Filter = "Text Files (*.txt) |*.txt | All Files (*.*) | *.*";

                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(saveFileDialog.FileName));

                object txtArea = null;
                write.Write(txtArea.Text);

            }



        }
=======
>>>>>>> 572f217743df3b61971a9a092f210dbcd73808b3
