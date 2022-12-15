using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Link_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Link_Click(object sender, EventArgs e)
        {

        }

        private void Get_Info_button_Click(object sender, EventArgs e)
        {
            string new_link = Link_textbox.Text;
            PeInfoObject new_pe = new PeInfoObject(new_link);
            if (new_pe != null)
            {
                SHA1_textbox.Text = new_pe.SHA_1;
                SHA256_textbox.Text = new_pe.SHA_256;
                File_Size_textbox.Text = new_pe.Size;
                File_Type_textbox.Text = new_pe.Type;
                File_Bit_Rate_textbox.Text = new_pe.Bit_Rate;
                Bites_richtextbox.Text = new_pe.Bites;
            }
            else
            {
                MessageBox.Show("Enter a link to the file");
            }
        }
    }
}
