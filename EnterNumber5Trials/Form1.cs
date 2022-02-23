using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnterNumber5Trials
{
    public partial class Form1 : Form
    {
        int trials = 5;
        string number;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            number = RNG(0, 99999999);
            number_label.Text = " Lütfen " + number + " sayısını doğru şekilde giriniz.";
        }

        string RNG(int min, int max)
        {
            int number = rand.Next(min, max);
            return number.ToString();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            CheckNumber(number,number_textbox.Text);
        }

        void CheckNumber(string number, string entry)
        {
            trials--;

            if (number == entry)
            {
                MessageBox.Show("Sayıyı doğru girdiniz, tebrikler.");
                enter_button.Enabled = false;
                trial_label.Text = "";
            }

            else if (!entry.All(char.IsNumber))
            {
                MessageBox.Show("Dikkat, sadece sayı girmelisiniz!");
            }

            else if(entry.Trim()=="")
            {
                trials++;
            }

            else if (trials == 0)
            {
                MessageBox.Show("Bilemediniz ve malesef başka hakkınız kalmadı.");
            }

            else
            {
                trial_label.Text = trials.ToString() + " hakkınız kaldı.";
            }
        }
    }
}
