using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string arr = textBox1.Text;
            string[] arrSplit = arr.Split(' ');
            Circle circle = new Circle(int.Parse(arrSplit[0]), int.Parse(arrSplit[1]), int.Parse(arrSplit[2]), this);
            circle.MoveRight(int.Parse(arrSplit[3]));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string arr = textBox2.Text;
            string[] arrSplit = arr.Split(' ');

            Square square = new Square(int.Parse(arrSplit[0]), int.Parse(arrSplit[1]), int.Parse(arrSplit[2]), this);
            square.MoveRight(int.Parse(arrSplit[3]));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string arr = textBox3.Text;
            string[] arrSplit = arr.Split(' ');
            Rhomb rhomb = new Rhomb(int.Parse(arrSplit[0]), int.Parse(arrSplit[1]), int.Parse(arrSplit[2]), int.Parse(arrSplit[3]), this);
            rhomb.MoveRight(int.Parse(arrSplit[4]));

        }
    }
}
