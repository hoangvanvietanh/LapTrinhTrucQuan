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
    public partial class Bai19 : Form
    {
        public Bai19()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
