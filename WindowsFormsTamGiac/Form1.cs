using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsTamGiac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown2.Value;    
            double c = (double)numericUpDown3.Value;

            {

                Lib_HinhHoc.TamGiac tg = new Lib_HinhHoc.TamGiac();
                tg.a = a; tg.b = b; tg.c = c;
                tg.TinhChuViHinhTamGiac();

                if (tg.ok)
                {
                    textBox1_kq.Text = $"Chu Vi Hình Tam Giác = {tg.chuvi}";
                }
                else
                {
                    textBox1_kq.Text = "3 cạnh không tạo thành một tam giác";
                }
            }
        }
    }
}
