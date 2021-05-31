using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Generator
{
    public partial class Form1 : Form
    {
        // Koden
        Random numGen = new Random();
        int val = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stängAvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void kreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alpers program", "Om");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateNumbers();

        }

        private void generateNumbers()
        {
            val = numGen.Next(1, 50); // Väljer ut tal mellan 1-50
            num1.Text = val.ToString();

            val = numGen.Next(1, 50);
            while (val.ToString().Equals(num1.Text))
                val = numGen.Next(1, 50);
            num2.Text = val.ToString();// Ser till att ruta två har inte samma ruta som ruta ett.

            val = numGen.Next(1, 50);
            while (val.ToString().Equals(num1.Text) || val.ToString().Equals(num2.Text))
                val = numGen.Next(1, 50);
            num3.Text = val.ToString(); //ser till att Ruta tre har inte samma värde som resten av rutorna

            val = numGen.Next(1, 50);
            while (val.ToString().Equals(num1.Text) || val.ToString().Equals(num2.Text) || val.ToString().Equals(num3.Text))
                val = numGen.Next(1, 50);
            num4.Text = val.ToString(); //ser till att Ruta fyra har inte samma värde som resten av rutorna

            val = numGen.Next(1, 50);
            while (val.ToString().Equals(num1.Text) || val.ToString().Equals(num2.Text) || val.ToString().Equals(num3.Text) || val.ToString().Equals(num4.Text))
                val = numGen.Next(1, 50);
            num5.Text = val.ToString(); //ser till att Ruta fem har inte samma värde som resten av rutorna


            //Red Ball koden

            val = numGen.Next(1, 40); // Samma funktion som åvan.
            num6.Text = val.ToString();
            
            if (num6.Text == num1.Text || num6.Text == num2.Text || num6.Text == num3.Text || num6.Text == num4.Text || num6.Text == num5.Text) 
            {

                MessageBox.Show("Grattis" + 
                    "´Du fick"+" "+ num6.Text +" "+ "två gånger");
            }
                
                else
    {
                 
                }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void num5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Tryck Enter för att köra");
            
        }

        private void slot6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void enternumber_TextChanged(object sender, EventArgs e)
        {
 

            
           
        }
    }
}
