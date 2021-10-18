using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFramework.S19.D7.DinamikFormElemanlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSkor.Text = "0";
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count < 50)
            {

                int mine1 = 0;
                int mine2 = 0;
                int mine3 = 0;

                Random rnd = new Random();
                mine1 = rnd.Next(1, 20);
                mine2 = rnd.Next(21, 40);
                mine3 = rnd.Next(41, 50);


                for (int i = 1; i <= 50; i++)
                {
                    Button btnTemp = new Button();
                    btnTemp.Name = "btn" + i.ToString();
                    btnTemp.Size = new System.Drawing.Size(35, 35);
                    btnTemp.Text = "";
                    btnTemp.UseVisualStyleBackColor = true;
                    if (mine1 == i || mine2 == i || mine3 == i)
                    {
                        btnTemp.Tag = true;
                    }
                    else
                    {
                        btnTemp.Tag = false;
                    }
                    btnTemp.Click += BtnTemp_Click;
                    flowLayoutPanel1.Controls.Add(btnTemp);
                }
            }
        }

        private void BtnTemp_Click(object sender, EventArgs e)
        {

            Button basilanButon = ((Button)sender);
            bool mayinBulundumu = (bool)basilanButon.Tag;
            if (mayinBulundumu)
            {
                MessageBox.Show("Mayını buldunuz tebrikler");
                basilanButon.BackColor = Color.Red;
                int mineint = int.Parse(lblmayin.Text);
                mineint++;

                lblmayin.Text = mineint.ToString();
                if (lblmayin.Text == "3")
                {
                    flowLayoutPanel1.Enabled = false;
                }

            }
            else
            {
                basilanButon.BackColor = Color.Green;
                int skorInt = int.Parse(lblSkor.Text);
                skorInt++;
                lblSkor.Text = skorInt.ToString();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


