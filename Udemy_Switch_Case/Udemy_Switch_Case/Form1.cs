using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy_Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2,sonuc; 
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);

            char islemSembolKarakter;
            islemSembolKarakter = Convert.ToChar(textBox3.Text);

            switch (islemSembolKarakter)
            {
                case '+':
                    sonuc = s1 + s2;
                    label4.Text = sonuc.ToString("0.00");
                    break;

                case '-':
                    sonuc = s1 - s2;
                    label4.Text = sonuc.ToString("0.00");
                    break;

                case '*':
                    sonuc = s1 * s2;
                    label4.Text = sonuc.ToString("0.00");
                    break;

                case '/':
                    sonuc = s1 / s2;
                    label4.Text = sonuc.ToString("0.00");
                    break;

                default:
                    MessageBox.Show("Lütfen + , - , * veya / gibi bir sembol giriniz!");
                    break;
            }
        }
    }
}
