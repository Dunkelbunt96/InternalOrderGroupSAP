using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternalOrderGroupBAPI;
using SAP.Middleware.Connector;
namespace InternalGroupOrderBAPI
{


    public partial class Overview : Form
    {
        RfcDestination rfcDestination= Connection.rfcDestination;
        public Overview()
        {
            InitializeComponent();
        }

        

        private void getListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RfcRepository rfcRepository = rfcDestination.Repository;
                var getList = rfcRepository.CreateFunction("BAPI_COSTCENTERGROUP_GETLIST");
                getList.Invoke(rfcDestination);
                getList.SetValue("CONTROLLINGAREAMASK", CostAreaSearch.Text);
                if (topNodesCheckBox.Checked)
                {
                    getList.SetValue("TOPNODESONLY", "X");
                }
                getList.Invoke(rfcDestination);

                var table = getList.GetTable("GROUPLIST");
                getListGridView.Rows.Clear();
                for (int i = 0; i < table.RowCount; i++)
                {
                    String costArea = table[i].GetString("CO_AREA");
                    String groupname = table[i].GetString("GROUPNAME");
                    String descript = table[i].GetString("DESCRIPT");
                    String[] row = { costArea, groupname, descript };
                    getListGridView.Rows.Add(row);
                }
            }
            catch (RfcCommunicationException ex)
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
            }
            catch(Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
            }



        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void getDetailBtn_Click(object sender, EventArgs e)
        {
            getDetail();
        }

        void DataWindow_Closing(object sender, CancelEventArgs e)
        {
            this.Close();

        }

        private void CreateGroupBtn_Click(object sender, EventArgs e)
        {
            new CreateGroup().ShowDialog();
        }

        private void AddNodeBtn_Click(object sender, EventArgs e)
        {
            new AddNode().ShowDialog();
        }

        private void getListGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            getDetail();
        }

        private void getDetail()
        {
            try
            {
                RfcRepository rfcRepository = rfcDestination.Repository;
                var getDetail = rfcRepository.CreateFunction("BAPI_COSTCENTERGROUP_GETDETAIL");
                getDetail.Invoke(rfcDestination);


                String contrArea = getListGridView.SelectedRows[0].Cells[0].Value.ToString();
                String groupName = getListGridView.SelectedRows[0].Cells[1].Value.ToString();

                getDetail.SetValue("CONTROLLINGAREA", contrArea);
                getDetail.SetValue("GROUPNAME", groupName);
                getDetail.Invoke(rfcDestination);

                var table = getDetail.GetTable("HIERARCHYNODES");
                
                getDetailGridView.Rows.Clear();
                for (int i = 0; i < table.RowCount; i++)
                {
                    String hierlevel = table[i].GetString("HIERLEVEL");
                    String groupname = table[i].GetString("GROUPNAME");
                    String valcount = table[i].GetString("VALCOUNT");
                    String descript = table[i].GetString("DESCRIPT");
                    String[] row = { groupname, hierlevel, valcount, descript };
                    getDetailGridView.Rows.Add(row);
                }

                var valueTable = getDetail.GetTable("HIERARCHYVALUES");
                valueDataGrid.Rows.Clear();
                for (int i = 0; i < valueTable.RowCount; i++)
                {
                    String valFrom = valueTable[i].GetString("VALFROM");
                    String valTo = valueTable[i].GetString("VALTO");
                    String[] row = { valFrom, valTo};
                    valueDataGrid.Rows.Add(row);
                }

            }
            catch (RfcCommunicationException ex)
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
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
