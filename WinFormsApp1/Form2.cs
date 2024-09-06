using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double soA;
        double soB;
        double soC;
        private void getInfo()
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;

            if (!double.TryParse(a, out soA)) MessageBox.Show("a khong phai so");
            if (!double.TryParse(b, out soB)) MessageBox.Show("b khong phai so");
            if (!double.TryParse(c, out soC)) MessageBox.Show("c khong phai so");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getInfo();
            double nghiem1;
            double nghiem2;

            if (soA == 0)
            {
                if (soB == 0)
                {
                    listBox1 = new ListBox();
                    listBox1.Items.Add("Phương trình vô nghiệm");
                }
            }
            else
            {
                double delta = soB * soB - 4 * soA * soC;
                if (delta < 0)
                {
                    listBox1.Items.Add("Phương trình vô nghiệm");
                }
                else if (delta == 0)
                {
                    nghiem1 = -soB / 2 * soA;
                    nghiem2 = nghiem1;
                    listBox1.Items.Add("Phương trình có nghiệm kép:");
                    listBox1.Items.Add($"x1 = x2 = {nghiem1}");
                }
                else
                {
                    nghiem1 = (-soB - 2 * Math.Sqrt(delta)) / 2 * soA;
                    nghiem2 = (-soB + 2 * Math.Sqrt(delta)) / 2 * soA;
                    listBox1.Items.Add("Phương trình có 2 nghiệm:");
                    listBox1.Items.Add($"x1 = {nghiem1}");
                    listBox1.Items.Add($"x2 = {nghiem2}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
