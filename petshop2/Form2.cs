using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
using System.IO;

namespace petshop2
{
    public partial class Form2 : Form
    {
        NpgsqlConnection koneksi = new NpgsqlConnection("Server=localhost;Port=5432;Userid=postgres;Password=allah;Database=oddbods");
        public Form2()
        {
            InitializeComponent();
            
        }
        
        private void bunifuImageButton2_MouseEnter(object sender, EventArgs e)
        {
            beranda.Height = 47;
        }

        private void bunifuImageButton2_Move(object sender, EventArgs e)
        {
            beranda.Height = 0;
        }
        
        private void bunifuImageButton1_Move(object sender, EventArgs e)
        {
            Keranjang.Height = 0;
        }

        private void bunifuImageButton1_MouseEnter(object sender, EventArgs e)
        {
            Keranjang.Height = 45;
        }
        
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
        

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            se.Width = bunifuImageButton8.Width;
            se.Left = bunifuImageButton8.Left;
            laporan.Height = 0;
        }
        private void bunifuImageButton12_MouseEnter(object sender, EventArgs e)
        {
            groupBox2.Height = 53;
        }

        private void bunifuImageButton12_Move(object sender, EventArgs e)
        {
            groupBox2.Height = 0;
        }
        
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(panel2.Height == 0)
            {
                panel2.Height = 389;
            }
            else
            {
                panel2.Height = 0;
            }
        }

        private void bunifuImageButton5_Move(object sender, EventArgs e)
        {
            groupBox1.Height = 0;
        }

        private void bunifuImageButton5_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Height = 50;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            laporan.Height = 392;
            se.Width = bunifuImageButton5.Width;
            se.Left = bunifuImageButton5.Left;
        }

        private void bunifuImageButton3_MouseEnter(object sender, EventArgs e)
        {
            more.Height = 37;
        }

        private void bunifuImageButton3_Move(object sender, EventArgs e)
        {
            more.Height = 0;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            P2.Width = label9.Width;
            P2.Left = label9.Left;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            P2.Width = label12.Width;
            P2.Left = label12.Left;
        }
    }
}
