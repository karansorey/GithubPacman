using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanRemasterdHHS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var Winformx = new WinForm();
            Winformx.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close(); //closing the app
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://dev.azure.com/PacmanHHS/");
        }
    }
}
