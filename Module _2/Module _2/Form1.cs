using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module__2
{
    public partial class Form1 : Form
    {
        int i = 0;
        List<Button> buttonsAdded = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplayPass.Text = txtEnterPass.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplayPass.Text = "";
            txtEnterPass.Clear();
            txtEnterPass.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, Welcome to C# nha ^^");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hi việt em");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hi đồng chí");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            laHoTen.Text = txtHo.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            laHoTen.Text = txtTen.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            laHoTen.Text = txtHo.Text +" "+ txtTen.Text;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblXuat.ForeColor = Color.Green;
            txtNhapTen.ForeColor = Color.Green;
            lbLoiNhan.ForeColor = Color.Green;
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblXuat.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblXuat.ForeColor = Color.Red;
            txtNhapTen.ForeColor = Color.Red;
            lbLoiNhan.ForeColor = Color.Red;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblXuat.ForeColor = Color.Black;
            txtNhapTen.ForeColor = Color.Black; lbLoiNhan.ForeColor = Color.Black;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblXuat.Font = new Font(lblXuat.Font.Name, lblXuat.Font.Size,lblXuat.Font.Style^FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            lblXuat.Font = new Font(lblXuat.Font.Name, lblXuat.Font.Size, lblXuat.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            lblXuat.Font = new Font(lblXuat.Font.Name, lblXuat.Font.Size, lblXuat.Font.Style ^ FontStyle.Underline);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            lbLoiNhan.Visible = checkBox4.Checked;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lbLoiNhan.Text = textBox1.Text + " : " + textBox2.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            textBox4.Text = textBox3.Text + " Bật đèn nào"; 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            textBox4.Text = textBox3.Text + " Tắt đèn nào";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Button btn = new Button();
                btn.Width = 75;
                btn.Height = 23;
                btn.Top = 130;
                btn.Left = 90;
                btn.Text = "Btn " + i;
                groupBox12.Controls.Add(btn);
                buttonsAdded.Insert(i, btn);
                i++;
            }
            else
            {
                Button btn = new Button();
                btn.Width = 75;
                btn.Height = 23;
                btn.Top = 130 - i * 30;
                btn.Left = 90;
                btn.Text = "Btn " + i;
                groupBox12.Controls.Add(btn);
                buttonsAdded.Insert(i, btn);
                i++;
            }
           
            
            //this.Controls.Add(btn);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (buttonsAdded.Count > 0)
            {
                Button buttonToRemove = buttonsAdded[0];
                buttonsAdded.Remove(buttonToRemove);
                groupBox12.Controls.Remove(buttonToRemove);
                i--;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://daihocgiadinh.vn");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bai21 bai21 = new Bai21();
            bai21.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MDIParent1 mDIParent1 = new MDIParent1();
            mDIParent1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Bai19 bai19 = new Bai19();
            bai19.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MDIParent1 mDIParent1 = new MDIParent1();
            mDIParent1.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Bai16 bai16 = new Bai16();
            bai16.Show();
        }
    }
}
