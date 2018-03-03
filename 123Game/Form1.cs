using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _123Game
{
    public partial class Form1 : Form
    {
        private int counter = 1, choice;
        public Form1()
        {
            InitializeComponent();
            this.label2.Left = (this.label2.Parent.Width - this.label2.Width) / 2 - 10;
            this.label2.Top = (this.label2.Parent.Height - this.label2.Height) / 2;
            this.label3.Left = (this.label3.Parent.Width - this.label3.Width) / 2;
            this.label3.Top = (this.label3.Parent.Height - this.label3.Height) / 2 - 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chossen()
        {
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = true;
            this.timer1.Enabled = true;
            this.timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chossen();
            choice = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chossen();
            choice = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chossen();
            choice = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = false;
            this.button5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 3)
            {
                this.label2.Visible = false;
                this.label3.Visible = true;
                Random rd = new Random();
                int computerChoice = rd.Next(1, 3);
                if (choice == computerChoice) this.label3.Text = "Draw! :)))";
                else if ((choice == 1 && computerChoice == 2) ||
                    (choice == 2 && computerChoice == 3) ||
                    (choice == 3 && computerChoice == 1)) this.label3.Text = "You lose!";
                else this.label3.Text = "You win :))";
                this.label4.Visible = true;
                this.label5.Visible = true;
                this.label4.Text = "You choose: " + (choice == 1 ? "the scissors" : choice == 2 ? "the rock" : "the paper");
                this.label5.Text = "Computer choose: " + (computerChoice == 1 ? "scissors" : computerChoice == 2 ? "the rock" : "the paper");
                this.timer1.Stop();
                this.timer1.Enabled = false;
                this.button4.Visible = true;
                this.button5.Visible = true;
                counter = 1;
            }
            else ++counter;
            this.label2.Text = counter.ToString();
        }
    }
}
