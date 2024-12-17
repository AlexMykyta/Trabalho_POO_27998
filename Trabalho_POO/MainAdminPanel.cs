using Objects;

namespace Trabalho_POO
{
    public partial class MainAdminPanel : Form
    {
        AdminPanelClient adminpanelclient;
        AdminPanelReservation adminpanelreservations;
        AdminPanelClientReserv adminpanelclientreserv;
        public MainAdminPanel()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            SessionClient.EndSession();

            Login Login = new Login();

            this.Hide();
            Login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adminpanelclient == null)
            {
                adminpanelclient = new AdminPanelClient();
                adminpanelclient.FormClosed += Adminpanelclient_FormClosed;
                adminpanelclient.MdiParent = this;
                adminpanelclient.Dock = DockStyle.Fill;
                adminpanelclient.Show();
            }
            else
            {
                adminpanelclient.Activate();
            }
        }

        private void Adminpanelclient_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }

        private void btClientManagement_Click(object sender, EventArgs e)
        {
            if (adminpanelreservations == null)
            {
                adminpanelreservations = new AdminPanelReservation();
                adminpanelreservations.FormClosed += Adminpanelreservations_FormClosed;
                adminpanelreservations.MdiParent = this;
                adminpanelreservations.Dock = DockStyle.Fill;
                adminpanelreservations.Show();
            }
            else
            {
                adminpanelreservations.Activate();
            }
        }

        private void Adminpanelreservations_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }

        private void MainAdminPanel_Load(object sender, EventArgs e)
        {
            if (adminpanelclient == null)
            {
                adminpanelclient = new AdminPanelClient();
                adminpanelclient.FormClosed += Adminpanelclient_FormClosed;
                adminpanelclient.MdiParent = this;
                adminpanelclient.Dock = DockStyle.Fill;
                adminpanelclient.Show();
            }
            else
            {
                adminpanelclient.Activate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (adminpanelclientreserv == null)
            {
                adminpanelclientreserv = new AdminPanelClientReserv();
                adminpanelclientreserv.FormClosed += Adminpanelclientreserv_FormClosed; 
                adminpanelclientreserv.MdiParent = this;
                adminpanelclientreserv.Dock = DockStyle.Fill;
                adminpanelclientreserv.Show();
            }
            else
            {
                adminpanelclientreserv.Activate();
            }
        }

        private void Adminpanelclientreserv_FormClosed(object? sender, FormClosedEventArgs e)
        {
           
        }
    }
}
