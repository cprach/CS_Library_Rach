using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Library_Rach.RachDate.addHoursToUTCDate(10));
            MessageBox.Show(Library_Rach.RachDate.addHoursToUTCTime(10));
            this.Close();
        }
    }
}
