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
            string[] lines = File.ReadAllLines(textBox_InputFile.Text);
            List<string> verts = new List<string>();
            List<string> faces = new List<string>();
            List<string> vertnormals = new List<string>();
            List<string> texturecoords = new List<string>();

            int vertexCount = 0;
            int faceCount = 0;
            foreach (string line in lines)
            {
                if (line != "")
                {
                    if (line.Substring(0,2) == "v ")
                    {
                        verts.Add(line);
                        vertexCount++;
                    }
                    if (line.Substring(0, 2) == "vn")
                    {
                        vertnormals.Add(line);
                    }
                    if (line.Substring(0, 2) == "vt")
                    {
                        texturecoords.Add(line);
                    }
                    else if (line[0] == 'f')
                    {
                        faces.Add(line);
                        faceCount++;
                    }
                }
            }



            //CHECK FOR PROBLEMS IN MODEL

            //ABORT - NON-TRIANGULATED FACES

            //WARN - FILE TOO LARGE

            //WARN - OPEN GEOMETRY
            
            //WARN - NO TEXTURE MAPPING

            //WARN - VERY LARGE DIMENSIONS

            

            label_VertCount.Text = vertexCount.ToString() + " Points";
            label_FaceCount.Text = faceCount.ToString() + " Polys";




            //CREATE GEO FILE
            using (StreamWriter sw = File.CreateText("NewModel.geo"))
            {
                //CREATE GEO HEADER
                sw.WriteLine("PGEOMETRY V5"); //No idea what this line does or if neccessary.
                sw.WriteLine("NPoints " + vertexCount + " NPrims " + faceCount);
                sw.WriteLine("NPointGroups 0 NPrimGroups 1");
                sw.WriteLine("NPointAttrib 3 NVertexAttrib 0 NPrimAttrib 1 NAttrib 1");

                //DEFINE POINT ATTRIBUTES
                sw.WriteLine("PointAttrib");
                sw.WriteLine("N 3 vector 0 0 0");
                sw.WriteLine("uv 3 float 0 0 0");
                sw.WriteLine("tangentu 3 vector 0 0 0");              

                //POINT LIST
                //format: x y z w (TANGENTU x y z, UV u v w, N x y z); 
                for(int i = 0; i < verts.Count; i++)
                {
                    sw.WriteLine(verts[i].Substring(2) + (" 1 (") + vertnormals[i].Substring(3) + " " + texturecoords[i].Substring(3)+" 1 1 1)" ); //tangentu not calculated
                } 

                //DEFINE FACE ATTRIBUTES
                sw.WriteLine("PrimitiveAttrib");
                sw.WriteLine("physicsid 1 int 0");
                sw.WriteLine("Run " + faceCount + " Poly");

                //FACE LIST
                //format: # of points, open or closed (< for closed, : for open), point #s [attribute data];
                //attribute data for physicsid always set to 4 for HQM models 
                //OBJ Faces not zero-indexed
                foreach (string face in faces)
                {
                    string fS = face.Substring(2);
                    string[] f = fS.Split(' ');
                    string fNew = string.Empty;

                    foreach (string str in f)
                    {
                        string ptS = str.Substring(0, str.IndexOf('/'));
                        int pt = Convert.ToInt32(ptS);
                        pt--; //subtract one because geo faces are zero-indexed
                        pt.ToString();
                        fNew += (pt + " ");

                    }

                    //rearrange face order to fix inverted faces
                    string[] fN = fNew.Split(' ');
                    string fNewRearranged = fN[0] + " " + fN[2] + " " + fN[1];

                    sw.WriteLine(" 3 < "+ fNewRearranged + " [4]");
                }


                //EXTRA INFORMATION
                //no idea what most of this does, but it's the same for all HQM models
                sw.WriteLine("DetailAttrib");
                sw.WriteLine("varmap 1 index 1 \"physicsid->PHYSICSID\"");
                sw.WriteLine(" (0)");
                sw.WriteLine("_clean unordered");

                string faceZeroes = new String('0', faceCount); //you need as many zeroes here as faces, no idea why.
                sw.WriteLine(faceCount + " " + faceZeroes);

                sw.WriteLine("beginExtra");
                sw.WriteLine("endExtra");




            }

            
            
        }
    }
}
