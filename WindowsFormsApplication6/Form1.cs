using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        int i;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
                button1.Text = "X";
            else button1.Text = "0";
            i++;
            button1.Enabled = false;
            Castigator();
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                Application.Restart();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
                button8.Text = "X";
            else button8.Text = "0";
            i++;
            button8.Enabled = false;
            Castigator();
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
                button5.Text = "X";
            else button5.Text = "0";
            i+;
            button5.Enabled = false;
            Castigator();
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
                button2.Text = "X";
            else button2.Text = "0";
            i+;
            button2.Enabled = false;
            Castigator();
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
                button3.Text = "X";
            else button3.Text = "0";
            i++;
            button3.Enabled = false;
            Castigator();
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
                button4.Text = "X";
            else button4.Text = "0";
            i++;
            button4.Enabled = false;
            Castigator();
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                Application.Restart();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
                button6.Text = "X";
            else button6.Text = "0";
            i++;
            button6.Enabled = false;
            Castigator();
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                Application.Restart();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
                button7.Text = "X";
            else button7.Text = "0";
            i++;
            button7.Enabled = false;
            Castigator();
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                Application.Restart();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (i % 2 == 1)
                button9.Text = "X";
            else button9.Text = "0";
            i++;
            button9.Enabled = false;
            Castigator();
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
                Application.Restart();
        }
        public void Castigator()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "-")
            {
                button1.BackColor = System.Drawing.Color.Lime;
                button2.BackColor = System.Drawing.Color.Lime;
                button3.BackColor = System.Drawing.Color.Lime;
                MessageBox.Show("Castigator " + button1.Text.ToString(), "Castigator!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (button4.Text == button5.Text && button4.Text == button6.Text && button4.Text != "-")
            {
                button4.BackColor = System.Drawing.Color.Lime;
                button5.BackColor = System.Drawing.Color.Lime;
                button6.BackColor = System.Drawing.Color.Lime;
                MessageBox.Show("Castigator " + button4.Text.ToString(), "Castigator!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (button7.Text == button8.Text && button9.Text == button8.Text && button7.Text != "-")
            {
                button9.BackColor = System.Drawing.Color.Lime;
                button7.BackColor = System.Drawing.Color.Lime;
                button8.BackColor = System.Drawing.Color.Lime;
                MessageBox.Show("Castigator " + button7.Text.ToString(), "Castigator!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "-")
            {
                button1.BackColor = System.Drawing.Color.Lime;
                button4.BackColor = System.Drawing.Color.Lime;
                button7.BackColor = System.Drawing.Color.Lime;
                MessageBox.Show("Castigator " + button1.Text.ToString(), "Castigator!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "-")
            {
                button2.BackColor = System.Drawing.Color.Lime;
                button5.BackColor = System.Drawing.Color.Lime;
                button8.BackColor = System.Drawing.Color.Lime;
                MessageBox.Show("Castigator " + button2.Text.ToString(), "Castigator!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (button6.Text == button9.Text && button9.Text == button3.Text && button3.Text != "-")
            {
                button9.BackColor = System.Drawing.Color.Lime;
                button6.BackColor = System.Drawing.Color.Lime;
                button3.BackColor = System.Drawing.Color.Lime;
                MessageBox.Show("Castigator " + button3.Text.ToString(), "Castigator!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (button1.Text == button5.Text && button1.Text == button9.Text && button9.Text != "-")
            {
                button1.BackColor = System.Drawing.Color.Lime;
                button5.BackColor = System.Drawing.Color.Lime;
                button9.BackColor = System.Drawing.Color.Lime;
                MessageBox.Show("Castigator " + button1.Text.ToString(), "Castigator!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (button5.Text == button7.Text && button7.Text == button3.Text && button3.Text != "-")
            {
                button7.BackColor = System.Drawing.Color.Lime;
                button5.BackColor = System.Drawing.Color.Lime;
                button3.BackColor = System.Drawing.Color.Lime;
                MessageBox.Show("Castigator " + button5.Text.ToString(), "Castigator!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
