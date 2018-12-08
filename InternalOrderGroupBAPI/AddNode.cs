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
            String[] row = { "A0815", "A0850"};
            AddGridView.Rows.Add(row);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                RfcRepository rfcRepository = rfcDestination.Repository;
                var AddNode = rfcRepository.CreateFunction("BAPI_INTERNALORDRGRP_ADDNODE");
                AddNode.Invoke(rfcDestination);

                
                String groupName = AddGridView.Rows[0].Cells[0].Value.ToString();
                String subgroupName = AddGridView.Rows[0].Cells[1].Value.ToString();

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
