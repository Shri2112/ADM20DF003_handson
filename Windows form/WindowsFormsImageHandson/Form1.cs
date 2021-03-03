using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsImageHandson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
           DialogResult dr = openFileDialog1.ShowDialog();
            if(dr==DialogResult.OK)
            {
                pbx.Image = Image.FromFile(openFileDialog1.FileName);

                
                label2.Text = openFileDialog1.FileName + "Opened Sucessfully";
                label2.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
