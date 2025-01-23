using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyScheduler
{
    public partial class CustomMessageForm : Form
    {
        public CustomMessageForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.AutoSize = true;
            label1.Width = 500;       // Set the width
            label1.Height = 300;       // Set the height
        }
    }
}
