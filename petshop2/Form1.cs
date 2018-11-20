using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace petshop2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void pass_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin keluar dari aplikasi ini ?", "Informasi Cados Pets", MessageBoxButtons.YesNo) == DialogResult.No) ;
            else
            {
                Application.Exit();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (pass.isPassword == false)
            {
                pass.isPassword = true;
            }
            else
            {
                pass.isPassword = false;
            }
        }
        

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 3)
            {
                imageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"Picture Login\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Width = 371;
            user.Text = "";
            pass.Text = "";
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (Ep.isPassword == false)
            {
                Ep.isPassword = true;
            }
            else
            {
                Ep.isPassword = false;
            }
        }

        private void Ep_Enter(object sender, EventArgs e)
        {
            Ep.isPassword = true;
        }

        private void Ecp_Enter(object sender, EventArgs e)
        {
            Ecp.isPassword = true;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if(Ecp.isPassword == false)
            {
                Ecp.isPassword = true;
            }
            else
            {
                Ecp.isPassword = false;
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if(EeP.Text == "" && Eu.Text == "" && Ep.Text == "" && Ecp.Text == "")
                {
                    p6.Height = 34;
                }
                else if (EeP.Text == "")
                {
                    p2.Height = 34;
                    EeP.Focus();
                }
                else if (Eu.Text == "")
                {
                    p1.Height = 34;
                    Eu.Focus();
                }
                else if (Ep.Text == "")
                {
                    p3.Height = 34;
                    Ep.Focus();
                }
                else if (Ecp.Text == "")
                {
                    p4.Height = 34;
                    Ecp.Focus();
                }
                else
                {
                    if (Ecp.Text != Ep.Text)
                    {
                        p5.Height = 34;
                        Ecp.Focus();
                        Ecp.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Berhasil daftar di Virram Love");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel1.Width = 0;
            p1.Height = 0;
            p2.Height = 0;
            p3.Height = 0;
            p4.Height = 0;
            p5.Height = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
        private void habis()
        {
            user.Text = "";
            pass.Text = "";
        }
        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (user.Text == "" && pass.Text == "")
                {
                    b3.Height = 34;
                }
                else if (user.Text == "")
                {
                    b1.Height = 34;
                    user.Focus();
                    habis();
                }
                else if(pass.Text == "")
                {
                    b2.Height = 34;
                    pass.Focus();
                    habis();
                }
                
                else
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message);
            }
        }

        private void pass_Enter_1(object sender, EventArgs e)
        {
            pass.isPassword = true;
            groupBox2.Height = 0;
        }

        private void user_MouseEnter(object sender, EventArgs e)
        {
            if(b1.Height == 34)
            {
                groupBox1.Height = 0;
            }
            else if(user.Text != "")
            {
                groupBox1.Height = 0;
            }
            else
            {
                groupBox1.Height = 39;
            }
            
        }

        private void user_MouseMove(object sender, MouseEventArgs e)
        {
            groupBox1.Height = 0;
        }

        private void pass_MouseEnter_1(object sender, EventArgs e)
        {
            if (b2.Height == 34)
            {
                groupBox2.Height = 0;
            }
            else if (pass.Text != "")
            {
                groupBox1.Height = 0;
            }
            else
            {
                groupBox2.Height = 39;
            }
           
        }

        private void pass_MouseMove(object sender, MouseEventArgs e)
        {
            groupBox2.Height = 0;
        }

        private void user_Enter(object sender, EventArgs e)
        {
            groupBox1.Height = 0;
        }

        private void user_OnValueChanged(object sender, EventArgs e)
        {
            if(user.Text != "")
            {
                b1.Height = 0;
                b3.Height = 0;
                groupBox1.Height = 0;
            }
        }

        private void pass_OnValueChanged(object sender, EventArgs e)
        {
            if (user.Text != "")
            {
                b2.Height = 0;
                b3.Height = 0;
                groupBox2.Height = 0;
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Height = 0;
            groupBox2.Height = 0;
        }

        private void Eu_OnValueChanged(object sender, EventArgs e)
        {
            if(Eu.Text != "")
            {
                p1.Height = 0;
                p6.Height = 0;
            }
        }

        private void Ee_OnValueChanged(object sender, EventArgs e)
        {
            if (EeP.Text != "")
            {
                p2.Height = 0;
                p6.Height = 0;
            }
        }

        private void Ecp_OnValueChanged(object sender, EventArgs e)
        {
            if(Ecp.Text != "")
            {
                p4.Height = 0;
                p6.Height = 0;
                p5.Height = 0;
            }
        }

        private void Ep_OnValueChanged(object sender, EventArgs e)
        {
            if (Ep.Text != "")
            {
                p3.Height = 0;
                p6.Height = 0;
            }
        }
    }
}
