using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace MLMOUAD
{
    public partial class Form1 : Form
    {
        FaceRec facerec = new FaceRec();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            facerec.openCamera(pictureBox1,pictureBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            facerec.Save_IMAGE(textBox1.Text);
            MessageBox.Show("Save success");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            facerec.isTrained = true;
            facerec.getPersonName(label4);
        }
    }
}
