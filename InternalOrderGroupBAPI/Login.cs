using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAP.Middleware.Connector;
using System.Configuration;
using InternalGroupOrderBAPI;

namespace InternalOrderGroupBAPI
{
    public partial class Login : Form
    {
        static connector sapconnector = new connector();

        public Login()
        {
            InitializeComponent();

            RfcDestinationManager.RegisterDestinationConfiguration(sapconnector);

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.rfcDestination = RfcDestinationManager.GetDestination("costCenter");
                connectionlbl.Text = "connecting ...";
                connectionlbl.BackColor = Color.Transparent;
                this.Refresh();

                Connection.rfcDestination.Ping();
                connectionlbl.Text = "connected";
                this.Hide();
                new Overview().ShowDialog();
                this.Close();
            }
            catch (SAP.Middleware.Connector.RfcLogonException ex)
            {
                Infolabel.Text = ex.Message;
                Console.WriteLine(ex.Message);
                connectionlbl.Text = "failed";
                connectionlbl.BackColor = Color.Red;
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
                connectionlbl.Text = "failed";
                connectionlbl.BackColor = Color.Red;

            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["SAP_USERNAME"] = NameBox.Text;
        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["SAP_PASSWORD"] = PassBox.Text;
        }

        private void NameBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
