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
    public partial class FormTSLN : Form
    {
        public FormTSLN()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int soA;
        int soB;
        int soC;
        private bool GetInfo()
        {
            if (!int.TryParse(textBox1.Text, out soA) || !int.TryParse(textBox2.Text, out soB) || !int.TryParse(textBox3.Text, out soC))
            {
                MessageBox.Show("Lỗi kiểu dữ liệu nhập không đúng: Vui lòng nhập số nguyên để chạy chương trình");
                return false;
            }
            return true;
        }

        private string TimSoLonNhat()
        {
            if (GetInfo())
            {
                int soLonNhat = soA;
                if (soA < soB || soA < soC)
                {
                    if (soB < soC)
                    {
                        soLonNhat = soC;
                    }
                    else soLonNhat = soB;
                }
                return String.Format("Số lớn nhất là " + soLonNhat.ToString());
            }
            return "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = TimSoLonNhat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
