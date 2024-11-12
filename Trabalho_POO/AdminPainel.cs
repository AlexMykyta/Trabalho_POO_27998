using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO
{
    public partial class AdminPainel : Form
    {
        public AdminPainel()
        {
            InitializeComponent();
        }

        bool sideBarExpand = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width -= 5;
                if (sideBar.Width <= 75)
                {
                    sideBarExpand = false;
                    SideBarTime.Stop();
                }
            }
            else
            {
                sideBar.Width += 5;
                if (sideBar.Width >= 206)
                {
                    sideBarExpand = true;
                    SideBarTime.Stop();
                }
            }
        }

        private void btSideBar_Click(object sender, EventArgs e)
        {
            SideBarTime.Start();
        }
    }
}
