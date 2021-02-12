using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeHesapMakinesi
{
    public partial class HesapMak : Form
    {
        public HesapMak()
        {
            InitializeComponent();
            
        }
        int check = 0;
        
        void numbercheck()
        {
            if (check == 2)
            {
                txtData1.Text = string.Empty;
                txtgöster.Text = girdi3.ToString();
                girdi1 = girdi3;
                check = 1;
            }
        }
        double girdi1 = 0;
        double girdi2 = 0;
        double girdi3 = 0;
        public void numbercheck2()
        {
            

            if (txtData1.TextLength == 0) return;
            
            else if (check == 0)
            {
                girdi1 = Convert.ToInt64(txtData1.Text);
                txtgöster.Text = txtData1.Text ;
                txtData1.Text = string.Empty;
                check = 1;
            }
            else if (check == 1)
            {
                
                girdi2 = Convert.ToInt64(txtData1.Text);
                txtgöster.Text = txtgöster.Text+ txtislem.Text+ txtData1.Text;
                txtData1.Text = string.Empty;

                if (txtislem.Text == "x")
                {
                    girdi3 = girdi1 * girdi2;
                    txtData1.Text = (girdi3).ToString();
                    listhistory.Items.Add(girdi1 + "*" + girdi2 + "=" + girdi3);
                }
                else if (txtislem.Text == "/")
                {
                    girdi3 = girdi1 / girdi2;
                    txtData1.Text = (girdi3).ToString();
                    listhistory.Items.Add(girdi1 + "/" + girdi2 + "=" + girdi3);
                }
                else if (txtislem.Text == "+")
                {
                    girdi3 = girdi1 + girdi2;
                    txtData1.Text = (girdi3).ToString();
                    listhistory.Items.Add(girdi1 + "+" + girdi2 + "=" + girdi3);
                }
                else if (txtislem.Text == "-")
                {
                    girdi3 = girdi1 - girdi2; 
                    txtData1.Text = (girdi3).ToString();
                    listhistory.Items.Add(girdi1 + "-" + girdi2 + "=" + girdi3);
                }
                
                check = 2;
            }

            
        }
        void hesapla()
        {
            if (txtData1.TextLength == 0) return;
            else
            {
                
                
            }
        }
        void enableallbtn()
        {
            button2.BackColor = Color.DarkSlateGray;
            button3.BackColor = Color.DarkSlateGray;
            button4.BackColor = Color.DarkSlateGray;
            button5.BackColor = Color.DarkSlateGray;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
                  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtislem.Text = "-";
            enableallbtn();           
            button4.BackColor = Color.DarkTurquoise;
            numbercheck2();             
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtislem.Text = "x";
            enableallbtn();
            button2.BackColor = Color.DarkTurquoise;
            numbercheck2();
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtislem.Text = "/";
            enableallbtn();
            button5.BackColor = Color.DarkTurquoise;
            numbercheck2(); 
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtislem.Text = "+";
            enableallbtn();
            button3.BackColor = Color.DarkTurquoise;
            numbercheck2();
            
        }

        private void HesapMak_Load(object sender, EventArgs e)
        {
            txtislem.Visible = false;
            panelHist.Visible = false;
            this.Height = 358;
            this.Width = 244;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void txtData1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))e.Handled = true;

        }

        private void txtData1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtData2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            numbercheck();
            txtData1.Text = txtData1.Text + "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            numbercheck2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numbercheck();
            txtData1.Text = txtData1.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numbercheck(); 
            txtData1.Text = txtData1.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            numbercheck(); 
            txtData1.Text = txtData1.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numbercheck(); 
            txtData1.Text = txtData1.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numbercheck(); 
            txtData1.Text = txtData1.Text + "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            numbercheck(); 
            txtData1.Text = txtData1.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            numbercheck(); 
            txtData1.Text = txtData1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numbercheck(); 
            txtData1.Text = txtData1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            numbercheck(); 
            txtData1.Text = txtData1.Text + "0";
        }

        private void txtData2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtData1.Text = string.Empty;
            txtgöster.Text = string.Empty;
            check = 0;
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            
            panelCalc.Visible = false;
            panelHist.Visible = true;
            this.Height = 386;
            this.Width = 328;
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            panelHist.Visible = false;
            panelCalc.Visible = true;
            this.Height = 348;
            this.Width = 234;

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            listhistory.Items.Clear();
        }

        private void listhistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listhistory_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void listhistory_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (listhistory.SelectedItem != null) Clipboard.SetText(string.Join(Environment.NewLine, listhistory.SelectedItems.OfType<string>()));
            else return;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listhistory_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }
    }
}
