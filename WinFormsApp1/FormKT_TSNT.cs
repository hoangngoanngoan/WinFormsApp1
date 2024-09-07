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
    public partial class FormKT_TSNT : Form
    {
        public FormKT_TSNT()
        {
            InitializeComponent();
        }

        private int GetInput()
        {
            int input = 0;
            if(!int.TryParse(textBox1.Text, out input))
            {
                MessageBox.Show("Lỗi kiểu dữ liệu không đúng: Vui lòng nhập số nguyên để chạy chương trình");
                return input;
            }
            return input;
        }

        private string KiemTraSNT()
        {
            string ketQua = "";
            int input = GetInput();
            int dem = 0;
            if(input == 1)
            {
                return ketQua = "1 là số nguyên tố";
            }else
            {
                for (int i = 1; i <= input; i++)
                {
                    if (input % i == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2) ketQua = input.ToString() + " là số nguyên tố";
                else ketQua = input.ToString() + " không phải là số nguyên tố";
            }            
            return ketQua;
        }

        private string TimSNT()
        {
            int input = GetInput();
            string ketQua = "";
            int dem = 0;
            if (input == 2) return ketQua = "1";
            else if(input == 1) return ketQua = "0";
            else
            {
                ketQua = "1 ";
                for (int i = 1; i < input; i++)
                {
                    dem = 0;
                    for(int j = 1; j <= i; j++)
                    {
                        if(i % j == 0) dem ++;
                    }
                    if (dem == 2) ketQua += i + " ";
                }                
            }
            return ketQua;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Text = KiemTraSNT();
            textBox3.Text = TimSNT();
        }
    }
}
