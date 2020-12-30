using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX_oyunu
{
    public partial class Form1 : Form
    {
        
        string oyuncu = "X";
        int hamlesayisi = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Text = oyuncu;
            label.Enabled = false;


            if (oyuncu == "X")
            {
                oyuncu = "O";

            }

            else
            {
                oyuncu = "X";
            }
            if( label1.Text +  label2.Text +label3.Text==  "XXX" ||
                label4.Text +  label5.Text +label6.Text == "XXX" ||
                label7.Text +  label8.Text +label9.Text == "XXX" ||
                label1.Text +  label4.Text +label7.Text == "XXX" ||
                label2.Text +  label5.Text +label8.Text == "XXX" ||
                label3.Text +  label6.Text +label9.Text == "XXX" ||
                label1.Text +  label5.Text +label9.Text == "XXX" ||
                label3.Text +  label5.Text +label7.Text == "XXX")
            {
                hamlesayisi = hamlesayisi + 1;
                MessageBox.Show("X Kazandı");
                Close();
            }

            if(label1.Text + label2.Text + label3.Text == "OOO" ||
               label4.Text + label5.Text + label6.Text == "OOO" ||
               label7.Text + label8.Text + label9.Text == "OOO" ||
               label1.Text + label4.Text + label7.Text == "OOO" ||
               label2.Text + label5.Text + label8.Text == "OOO" ||
               label3.Text + label6.Text + label9.Text == "OOO" ||
               label1.Text + label5.Text + label9.Text == "OOO" ||
               label3.Text + label5.Text + label7.Text == "OOO")
            {
                hamlesayisi = hamlesayisi + 1;
                MessageBox.Show("O Kazandı");
                Close();
            }
            hamlesayisi=hamlesayisi+1;
            if(hamlesayisi==9)
            {
                MessageBox.Show("BERABERE");
                Close();
            }

        }
    }
}
