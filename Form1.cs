using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIS_Test_WinForms_dotnet4._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int y = Screen.PrimaryScreen.Bounds.Height;
            int x = Screen.PrimaryScreen.Bounds.Width;
            this.Height = y - 40;
            this.Width = x;
            this.Left = 0;
            this.Top = 0;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ResidentRecords_Click(object sender, EventArgs e)
        {

        }
    }
}
