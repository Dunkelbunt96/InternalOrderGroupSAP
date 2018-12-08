using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternalOrderGroupBAPI
{
    public partial class AddNode : Form
    {
        RfcDestination rfcDestination = Connection.rfcDestination;
        public AddNode()
        {
            InitializeComponent();
            String[] row = { "1000", "ATEST", "TEST"};
            AddGridView.Rows.Add(row);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RfcRepository rfcRepository = rfcDestination.Repository;
                var AddNode = rfcRepository.CreateFunction("BAPI_COSTCENTERGROUP_ADDNODE");
                AddNode.Invoke(rfcDestination);

                String contrArea = AddGridView.Rows[0].Cells[0].Value.ToString();
                String groupName = AddGridView.Rows[0].Cells[1].Value.ToString();
                String subgroupName = AddGridView.Rows[0].Cells[2].Value.ToString();

                AddNode.SetValue("CONTROLLINGAREA", contrArea);
                AddNode.SetValue("GROUPNAME", groupName);
                AddNode.SetValue("SUBGROUPNAME", subgroupName);
                AddNode.Invoke(rfcDestination);
                this.Close();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                Console.Out.WriteLine(ex.StackTrace);
            }
        }
    }
}
