using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Запомни_карту
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool t6 = false, t7 = false, t8 = false, t9 = false, t10 = false, t11 = false, t12 = false, t13 = false, t14 = false;
        private bool k6 = false, k7 = false, k8 = false, k9 = false, k10 = false, k11 = false, k12 = false, k13 = false, k14 = false;
        private bool h6 = false, h7 = false, h8 = false, h9 = false, h10 = false, h11 = false, h12 = false, h13 = false, h14 = false;
        private bool q6 = false, q7 = false, q8 = false, q9 = false, q10 = false, q11 = false, q12 = false, q13 = false, q14 = false;

        private int i=0,znak=0;

        private void button_clicks(Button btn,int igr)
        {
            if (igr == 4)
            {
                btn.FlatStyle = FlatStyle.System;
                znak--;
                btn_znach(false);
            }
            else if (igr == 5)
            {
                btn.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 5;
            }
            if (igr == 0)
                {
                btn.FlatAppearance.BorderColor = Color.Black;
                znak++;
            }
                else if (igr == 1)
                {
                btn.FlatAppearance.BorderColor = Color.Blue;
                znak--;
                btn_znach(false);
            }
                else if (igr == 2)
                {     
                btn.FlatAppearance.BorderColor = Color.Red;
                znak--;
                btn_znach(false);
            }
                else if (igr == 3)
                {
                btn.FlatAppearance.BorderColor = Color.Yellow;
                znak--;
                btn_znach(false);
            }
         }

        private void btn_znach(bool bl)
        {
            if (znak < 1)
            {
                t6 = bl; t7 = bl; t8 = bl; t9 = bl; t10 = bl; t11 = bl; t12 = bl; t13 = bl; t14 = bl;
                k6 = bl; k7 = bl; k8 = bl; k9 = bl; k10 = bl; k11 = bl; k12 = bl; k13 = bl; k14 = bl;
                h6 = bl; h7 = bl; h8 = bl; h9 = bl; h10 = bl; h11 = bl; h12 = bl; h13 = bl; h14 = bl;
                q6 = bl; q7 = bl; q8 = bl; q9 = bl; q10 = bl; q11 = bl; q12 = bl; q13 = bl; q14 = bl;
            }
        }

        private void igrok_sel(int igr)
        {
            if (t14 == true)
            {
                button_clicks(button7, igr);
            }
            if (t13 == true)
            {
                button_clicks(button14, igr);
            }
            if (t12 == true)
            {
                button_clicks(button15, igr);
            }
            if (t11 == true)
            {
                button_clicks(button16, igr);
            }
            if (t10 == true)
            {
                button_clicks(button17, igr);
            }
            if (t9 == true)
            {
                button_clicks(button18, igr);
            }
            if (t8 == true)
            {
                button_clicks(button19, igr);
            }
            if (t7 == true)
            {
                button_clicks(button20, igr);
            }
            if (t6 == true)
            {
                button_clicks(button42, igr);
            }
            if (k14 == true)
            {
                button_clicks(button8, igr);
            }
            if (k13 == true)
            {
                button_clicks(button21, igr);
            }
            if (k12 == true)
            {
                button_clicks(button22, igr);
            }
            if (k11 == true)
            {
                button_clicks(button23, igr);
            }
            if (k10 == true)
            {
                button_clicks(button24, igr);
            }
            if (k9 == true)
            {
                button_clicks(button25, igr);
            }
            if (k8 == true)
            {
                button_clicks(button26, igr);
            }
            if (k7 == true)
            {
                button_clicks(button27, igr);
            }
            if (k6 == true)
            {
                button_clicks(button43, igr);
            }
            if (h14 == true)
            {
                button_clicks(button9, igr);
            }
            if (h13 == true)
            {
                button_clicks(button28, igr);
            }
            if (h12 == true)
            {
                button_clicks(button29, igr);
            }
            if (h11 == true)
            {
                button_clicks(button30, igr);
            }
            if (h10 == true)
            {
                button_clicks(button31, igr);
            }
            if (h9 == true)
            {
                button_clicks(button32, igr);
            }
            if (h8 == true)
            {
                button_clicks(button33, igr);
            }
            if (h7 == true)
            {
                button_clicks(button34, igr);
            }
            if (h6 == true)
            {
                button_clicks(button44, igr);
            }
            if (q14 == true)
            {
                button_clicks(button10, igr);
            }
            if (q13 == true)
            {
                button_clicks(button35, igr);
            }
            if (q12 == true)
            {
                button_clicks(button36, igr);
            }
            if (q11 == true)
            {
                button_clicks(button37, igr);
            }
            if (q10 == true)
            {
                button_clicks(button38, igr);
            }
            if (q9 == true)
            {
                button_clicks(button39, igr);
            }
            if (q8 == true)
            {
                button_clicks(button40, igr);
            }
            if (q7 == true)
            {
                button_clicks(button41, igr);
            }
            if (q6 == true)
            {
                button_clicks(button45, igr);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 1;
            igrok_sel(i);
            i = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            i = 2;
            igrok_sel(i);
            i = 0;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            i = 3;
            igrok_sel(i);
            i = 0;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            i = 4;
            igrok_sel(i);
            i = 0;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            i = 5;
            znak = 0;
            btn_znach(true);
            igrok_sel(i);
            btn_znach(false);
            i = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (t14 == false)
            {
                t14 = true;
                button_clicks(button7, i);
            }
            else
            {
                t14 = false;
                button_clicks(button7, 5);
                znak--;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (k14 == false)
            {
                k14 = true;
                button_clicks(button8, i);
            }
            else
            {
                k14 = false;
                button_clicks(button8, 5);
                znak--;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (h14 == false)
            {
                h14 = true;
                button_clicks(button9, i);
            }
            else
            {
                h14 = false;
                button_clicks(button9, 5);
                znak--;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (q14 == false)
            {
                q14 = true;
                button_clicks(button10, i);
            }
            else
            {
                q14 = false;
                button_clicks(button10, 5);
                znak--;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (t13 == false)
            {
                t13 = true;
                button_clicks(button14, i);
            }
            else
            {
                t13 = false;
                button_clicks(button14, 5);
                znak--;
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (t12 == false)
            {
                t12 = true;
                button_clicks(button15, i);
            }
            else
            {
                t12 = false;
                button_clicks(button15, 5);
                znak--;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (t11 == false)
            {
                t11 = true;
                button_clicks(button16, i);
            }
            else
            {
                t11 = false;
                button_clicks(button16, 5);
                znak--;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (t10 == false)
            {
                t10 = true;
                button_clicks(button17, i);
            }
            else
            {
                t10 = false;
                button_clicks(button17, 5);
                znak--;
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (t9 == false)
            {
                t9 = true;
                button_clicks(button18, i);
            }
            else
            {
                t9 = false;
                button_clicks(button18, 5);
                znak--;
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (t8 == false)
            {
                t8 = true;
                button_clicks(button19, i);
            }
            else
            {
                t8 = false;
                button_clicks(button19, 5);
                znak--;
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (t7 == false)
            {
                t7 = true;
                button_clicks(button20, i);
            }
            else
            {
                t7 = false;
                button_clicks(button20, 5);
                znak--;
            }
        }
        private void button42_Click(object sender, EventArgs e)
        {
            if (t6 == false)
            {
                t6 = true;
                button_clicks(button42, i);
            }
            else
            {
                t6 = false;
                button_clicks(button42, 5);
                znak--;
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            if (k13 == false)
            {
                k13 = true;
                button_clicks(button21, i);
            }
            else
            {
                k13 = false;
                button_clicks(button21, 5);
                znak--;
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (k12 == false)
            {
                k12 = true;
                button_clicks(button22, i);
            }
            else
            {
                k12 = false;
                button_clicks(button22, 5);
                znak--;
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            if (k11 == false)
            {
                k11 = true;
                button_clicks(button23, i);
            }
            else
            {
                k11 = false;
                button_clicks(button23, 5);
                znak--;
            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            if (k10 == false)
            {
                k10 = true;
                button_clicks(button24, i);
            }
            else
            {
                k10 = false;
                button_clicks(button24, 5);
                znak--;
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            if (k9 == false)
            {
                k9 = true;
                button_clicks(button25, i);
            }
            else
            {
                k9 = false;
                button_clicks(button25, 5);
                znak--;
            }
        }
        private void button26_Click(object sender, EventArgs e)
        {
            if (k8 == false)
            {
                k8 = true;
                button_clicks(button26, i);
            }
            else
            {
                k8 = false;
                button_clicks(button26, 5);
                znak--;
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            if (k7 == false)
            {
                k7 = true;
                button_clicks(button27, i);
            }
            else
            {
                k7 = false;
                button_clicks(button27, 5);
                znak--;
            }
        }
        private void button43_Click(object sender, EventArgs e)
        {
            if (k6 == false)
            {
                k6 = true;
                button_clicks(button43, i);
            }
            else
            {
                k6 = false;
                button_clicks(button43, 5);
                znak--;
            }
        }
        private void button28_Click(object sender, EventArgs e)
        {
            if (h13 == false)
            {
                h13 = true;
                button_clicks(button28, i);
            }
            else
            {
                h13 = false;
                button_clicks(button28, 5);
                znak--;
            }
        }
        private void button29_Click(object sender, EventArgs e)
        {
            if (h12 == false)
            {
                h12 = true;
                button_clicks(button29, i);
            }
            else
            {
                h12 = false;
                button_clicks(button29, 5);
                znak--;
            }
        }
        private void button30_Click(object sender, EventArgs e)
        {
            if (h11 == false)
            {
                h11 = true;
                button_clicks(button30, i);
            }
            else
            {
                h11 = false;
                button_clicks(button30, 5);
                znak--;
            }
        }
        private void button31_Click(object sender, EventArgs e)
        {
            if (h10 == false)
            {
                h10 = true;
                button_clicks(button31, i);
            }
            else
            {
                h10 = false;
                button_clicks(button31, 5);
                znak--;
            }
        }
        private void button32_Click(object sender, EventArgs e)
        {
            if (h9 == false)
            {
                h9 = true;
                button_clicks(button32, i);
            }
            else
            {
                h9 = false;
                button_clicks(button32, 5);
                znak--;
            }
        }
        private void button33_Click(object sender, EventArgs e)
        {
            if (h8 == false)
            {
                h8 = true;
                button_clicks(button33, i);
            }
            else
            {
                h8 = false;
                button_clicks(button33, 5);
                znak--;
            }
        }
        private void button34_Click(object sender, EventArgs e)
        {
            if (h7 == false)
            {
                h7 = true;
                button_clicks(button34, i);
            }
            else
            {
                h7 = false;
                button_clicks(button34, 5);
                znak--;
            }
        }
        private void button44_Click(object sender, EventArgs e)
        {
            if (h6 == false)
            {
                h6 = true;
                button_clicks(button44, i);
            }
            else
            {
                h6 = false;
                button_clicks(button44, 5);
                znak--;
            }
        }
        private void button35_Click(object sender, EventArgs e)
        {
            if (q13 == false)
            {
                q13 = true;
                button_clicks(button35, i);
            }
            else
            {
                q13 = false;
                button_clicks(button35, 5);
                znak--;
            }
        }
        private void button36_Click(object sender, EventArgs e)
        {
            if (q12 == false)
            {
                q12 = true;
                button_clicks(button36, i);
            }
            else
            {
                q12 = false;
                button_clicks(button36, 5);
                znak--;
            }
        }
        private void button37_Click(object sender, EventArgs e)
        {
            if (q11 == false)
            {
                q11 = true;
                button_clicks(button37, i);
            }
            else
            {
                q11 = false;
                button_clicks(button37, 5);
                znak--;
            }
        }
        private void button38_Click(object sender, EventArgs e)
        {
            if (q10 == false)
            {
                q10 = true;
                button_clicks(button38, i);
            }
            else
            {
                q10 = false;
                button_clicks(button38, 5);
                znak--;
            }
        }
        private void button39_Click(object sender, EventArgs e)
        {
            if (q9 == false)
            {
                q9 = true;
                button_clicks(button39, i);
            }
            else
            {
                q9 = false;
                button_clicks(button39, 5);
                znak--;
            }
        }
        private void button40_Click(object sender, EventArgs e)
        {
            if (q8 == false)
            {
                q8 = true;
                button_clicks(button40, i);
            }
            else
            {
                q8 = false;
                button_clicks(button40, 5);
                znak--;
            }
        }
        private void button41_Click(object sender, EventArgs e)
        {
            if (q7 == false)
            {
                q7 = true;
                button_clicks(button41, i);
            }
            else
            {
                q7 = false;
                button_clicks(button41, 5);
                znak--;
            }
        }
        private void button45_Click(object sender, EventArgs e)
        {
            if (q6 == false)
            {
                q6 = true;
                button_clicks(button45, i);
            }
            else
            {
                q6 = false;
                button_clicks(button45, 5);
                znak--;
            }
        }
    }
}
