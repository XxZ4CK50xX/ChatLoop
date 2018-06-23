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





        private void button4_Click(object sender, EventArgs e)
        {


            {

            }
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

        private void button5_Click(object sender, EventArgs e)}

    namespace SaveFileDialog

    {
        class  SaveFileDialog 
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog  saveFile1  = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Preset |*.txt";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }
