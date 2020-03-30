using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            square objSquare = new square();
            int lenght = Convert.ToInt32(textBox1.Text);
            //int width = Convert.ToInt32(textBox2.Text);
            //int height = Convert.ToInt32(textBox3.Text);
            objSquare.setLenght(lenght);
            //objSquare.setHeight(height);
            //objSquare.setwidht(width);
            int area = objSquare.calculateSquare(lenght);
            //int area1 = objSquare.calculateRectangle(lenght,width);
            //int area2 = objSquare.calculateCube(lenght,width,height);
            MessageBox.Show("Area of square is "+area);
            //MessageBox.Show("Area of square is " + area1);
            //MessageBox.Show("Area of square is " + area2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
