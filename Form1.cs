using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileConvertGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_InputFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Wavefront OBJ Files (.OBJ)|*.OBJ";
            openFileDialog1.ShowDialog();
            textBox_InputFile.Text = openFileDialog1.FileName;
        }

        private void textBox_InputFile_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(textBox_InputFile.Text);
            int vertexCount = 0;
            int faceCount = 0;
            foreach (string line in lines)
            {
                if (line != "")
                {
                    if (line[0] == 'v')
                    {
                        vertexCount++;
                    }         
                    else if (line[0] == 'f')
                    {
                        faceCount++;
                    }           
                }
            }
            label_VertCount.Text = vertexCount.ToString() + " Points";
            label_FaceCount.Text = faceCount.ToString() + " Polys";
        }
    }
}
