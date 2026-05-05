using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Дневник
{
    public partial class Form1 : Form
    {
        private bool isActive = false;
        bool save;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if(save == true && text != "")
            {
                label1.Text = text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isActive == false)
            {
                // Включаем
                isActive = true;
                save = true;
                button1.Text = "Выключить";
                textBox1.Enabled = true;

            }
            else
            {
                // Выключаем
                isActive = false;
                button1.Text = "Включить";
                save = false;
                textBox1.Enabled = false;

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            label2.Visible = true;
            this.BackColor = Color.Gray;
            label1.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label2.Visible = false;
            this.BackColor = Color.White;
            label1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
            button3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа сделана VovaProKiller. Все права защищены.");
        }

    }
}
