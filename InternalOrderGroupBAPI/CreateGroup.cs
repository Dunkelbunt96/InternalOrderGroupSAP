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
    public partial class CreateGroup : Form
    {
        RfcDestination rfcDestination = Connection.rfcDestination;
        public CreateGroup()
        {
            
            InitializeComponent();
            String[] row = { "1000", "ATEST", "0", "TestTest2" };
            createGridView.Rows.Add(row);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RfcRepository rfcRepository = rfcDestination.Repository;
                var create = rfcRepository.CreateFunction("BAPI_COSTCENTERGROUP_CREATE");
                create.Invoke(rfcDestination);


                String contrArea = createGridView.Rows[0].Cells[0].Value.ToString();


                var hierarchyTable = create.GetTable("HIERARCHYNODES");
                hierarchyTable.Append();
                
                String groupName = createGridView.Rows[0].Cells[1].Value.ToString();
                String hierLevel = "0";
                String valcount = createGridView.Rows[0].Cells[2].Value.ToString();
                String descript = createGridView.Rows[0].Cells[3].Value.ToString();

                hierarchyTable.SetValue("GROUPNAME", groupName);
                hierarchyTable.SetValue("HIERLEVEL", hierLevel);
                hierarchyTable.SetValue("VALCOUNT", valcount);
                hierarchyTable.SetValue("DESCRIPT", descript);


                IRfcTable hierarchyValuesTable = create.GetTable("HIERARCHYVALUES");
                //Ohne Append können die Values nicht gesetzt werden
                hierarchyValuesTable.Append();
                for(int i = 0; i+1 < valueDataGrid.RowCount; i++)
                {
                    hierarchyValuesTable.Insert();
                    hierarchyValuesTable.CurrentIndex = hierarchyValuesTable.Count - 1;

                    hierarchyValuesTable[i].SetValue("VALFROM", valueDataGrid.Rows[i].Cells[0].Value.ToString());
                    hierarchyValuesTable[i].SetValue("VALTO", valueDataGrid.Rows[i].Cells[1].Value.ToString());
                }

                for (int i = 0; i + 1 < valueDataGrid.RowCount; i++)
                {
                    Console.Out.WriteLine(hierarchyValuesTable[i].GetString("VALFROM"));
                    
                }


                create.SetValue("HIERARCHYNODES", hierarchyTable);
                create.SetValue("HIERARCHYVALUES", hierarchyValuesTable);
                create.SetValue("CONTROLLINGAREAIMP", contrArea);
                create.Invoke(rfcDestination);
                this.Close();
            }
            /*catch (RfcCommunicationException ex)
            {
                Console.Out.WriteLine(ex.Message);
            }
            catch (RfcLogonException ex)
            {
                Console.Out.WriteLine(ex.Message);
            }
            catch (RfcAbapRuntimeException ex)
            {
                Console.Out.WriteLine(ex.Message);
            }*/
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                Console.Out.WriteLine(ex.StackTrace);
            }
        }

        private void valueDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void valueDataGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            createGridView.Rows[0].Cells[2].Value = valueDataGrid.Rows.Count -1;
            
        }

        private void createGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
