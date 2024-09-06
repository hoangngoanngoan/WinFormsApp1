using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        double so;
        List<double> numbers = new List<double>();

        private bool checkInfo()
        {

            if (!double.TryParse(textBox1.Text, out so))
            {

                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkInfo())
            {
                numbers.Add(Convert.ToDouble(textBox1.Text));
                txtNhapSo.Text = "";

                double tong = 0;
                double tongChan = 0;
                double tongLe = 0;

                foreach (var item in numbers)
                {
                    txtNhapSo.Text += item + ", ";
                    tong += item;
                    txtTongDaySo.Text = tong.ToString();
                    if(item % 2 == 0)
                    {
                        tongChan += item;
                        txtTongChan.Text = tongChan.ToString();
                    }else
                    {
                        tongLe += item;
                        txtTongLe.Text = tongLe.ToString();
                    }
                }
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Phai nhap so");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
