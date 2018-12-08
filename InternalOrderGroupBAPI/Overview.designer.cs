namespace InternalGroupOrderBAPI
{
    partial class Overview
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.getListBtn = new System.Windows.Forms.Button();
            this.getListGridView = new System.Windows.Forms.DataGridView();
            this.GroupNameSearch = new System.Windows.Forms.TextBox();
            this.getDetailBtn = new System.Windows.Forms.Button();
            this.getDetailGridView = new System.Windows.Forms.DataGridView();
            this.Groupname2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HierarchyLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateGroupBtn = new System.Windows.Forms.Button();
            this.AddNodeBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.valueDataGrid = new System.Windows.Forms.DataGridView();
            this.ValFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.topNodesCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Groupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.getListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDetailGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueDataGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // getListBtn
            // 
            this.getListBtn.Location = new System.Drawing.Point(3, 3);
            this.getListBtn.Name = "getListBtn";
            this.getListBtn.Size = new System.Drawing.Size(84, 29);
            this.getListBtn.TabIndex = 2;
            this.getListBtn.Text = "GetList";
            this.toolTip1.SetToolTip(this.getListBtn, "loads all Groups with the given Cost Area\r\n");
            this.getListBtn.UseVisualStyleBackColor = true;
            this.getListBtn.Click += new System.EventHandler(this.getListBtn_Click);
            // 
            // getListGridView
            // 
            this.getListGridView.AllowUserToAddRows = false;
            this.getListGridView.AllowUserToDeleteRows = false;
            this.getListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getListGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.getListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Groupname,
            this.Description});
            this.getListGridView.EnableHeadersVisualStyles = false;
            this.getListGridView.Location = new System.Drawing.Point(4, 62);
            this.getListGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getListGridView.Name = "getListGridView";
            this.getListGridView.ReadOnly = true;
            this.getListGridView.RowHeadersVisible = false;
            this.getListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.getListGridView.ShowCellToolTips = false;
            this.getListGridView.Size = new System.Drawing.Size(712, 538);
            this.getListGridView.TabIndex = 6;
            this.toolTip1.SetToolTip(this.getListGridView, "Cost_Area: the Cost Area of the loaded Groups\r\nGroupname: the name of the groups\r" +
        "\nDescript: the description of the groups");
            this.getListGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.getListGridView_MouseDoubleClick);
            // 
            // GroupNameSearch
            // 
            this.GroupNameSearch.Location = new System.Drawing.Point(4, 5);
            this.GroupNameSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupNameSearch.Name = "GroupNameSearch";
            this.GroupNameSearch.Size = new System.Drawing.Size(148, 26);
            this.GroupNameSearch.TabIndex = 7;
            this.toolTip1.SetToolTip(this.GroupNameSearch, "Specifies the Cost Area");
            this.GroupNameSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // getDetailBtn
            // 
            this.getDetailBtn.Location = new System.Drawing.Point(724, 5);
            this.getDetailBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getDetailBtn.Name = "getDetailBtn";
            this.getDetailBtn.Size = new System.Drawing.Size(140, 35);
            this.getDetailBtn.TabIndex = 8;
            this.getDetailBtn.Text = "Load Hierarchy";
            this.toolTip1.SetToolTip(this.getDetailBtn, "loads the hierarchy of the selected group (alt. douple click a group)");
            this.getDetailBtn.UseVisualStyleBackColor = true;
            this.getDetailBtn.Click += new System.EventHandler(this.getDetailBtn_Click);
            // 
            // getDetailGridView
            // 
            this.getDetailGridView.AllowUserToAddRows = false;
            this.getDetailGridView.AllowUserToDeleteRows = false;
            this.getDetailGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getDetailGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.getDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getDetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Groupname2,
            this.HierarchyLevel,
            this.ValCount,
            this.Descript});
            this.getDetailGridView.EnableHeadersVisualStyles = false;
            this.getDetailGridView.Location = new System.Drawing.Point(4, 5);
            this.getDetailGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getDetailGridView.Name = "getDetailGridView";
            this.getDetailGridView.ReadOnly = true;
            this.getDetailGridView.RowHeadersVisible = false;
            this.getDetailGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.getDetailGridView.ShowCellToolTips = false;
            this.getDetailGridView.Size = new System.Drawing.Size(702, 270);
            this.getDetailGridView.TabIndex = 9;
            this.toolTip1.SetToolTip(this.getDetailGridView, resources.GetString("getDetailGridView.ToolTip"));
            // 
            // Groupname2
            // 
            this.Groupname2.HeaderText = "Groupname";
            this.Groupname2.Name = "Groupname2";
            this.Groupname2.ReadOnly = true;
            this.Groupname2.Width = 70;
            // 
            // HierarchyLevel
            // 
            this.HierarchyLevel.HeaderText = "Hierarchy Level";
            this.HierarchyLevel.Name = "HierarchyLevel";
            this.HierarchyLevel.ReadOnly = true;
            this.HierarchyLevel.Width = 60;
            // 
            // ValCount
            // 
            this.ValCount.HeaderText = "Value Count";
            this.ValCount.Name = "ValCount";
            this.ValCount.ReadOnly = true;
            this.ValCount.Width = 50;
            // 
            // Descript
            // 
            this.Descript.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descript.HeaderText = "Description";
            this.Descript.Name = "Descript";
            this.Descript.ReadOnly = true;
            // 
            // CreateGroupBtn
            // 
            this.CreateGroupBtn.Location = new System.Drawing.Point(18, 18);
            this.CreateGroupBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateGroupBtn.Name = "CreateGroupBtn";
            this.CreateGroupBtn.Size = new System.Drawing.Size(166, 35);
            this.CreateGroupBtn.TabIndex = 12;
            this.CreateGroupBtn.Text = "Create new Group";
            this.toolTip1.SetToolTip(this.CreateGroupBtn, "opens a new window to specify a new group to create\r\n");
            this.CreateGroupBtn.UseVisualStyleBackColor = true;
            this.CreateGroupBtn.Click += new System.EventHandler(this.CreateGroupBtn_Click);
            // 
            // AddNodeBtn
            // 
            this.AddNodeBtn.Location = new System.Drawing.Point(212, 18);
            this.AddNodeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNodeBtn.Name = "AddNodeBtn";
            this.AddNodeBtn.Size = new System.Drawing.Size(146, 35);
            this.AddNodeBtn.TabIndex = 13;
            this.AddNodeBtn.Text = "Add Subgroup";
            this.toolTip1.SetToolTip(this.AddNodeBtn, "opens a window to add on group to another as an subgroup");
            this.AddNodeBtn.UseVisualStyleBackColor = true;
            this.AddNodeBtn.Click += new System.EventHandler(this.AddNodeBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.getListGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.getDetailBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 89);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.505229F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.49477F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1440, 605);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(724, 62);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.getDetailGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.valueDataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(711, 538);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 15;
            // 
            // valueDataGrid
            // 
            this.valueDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valueDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ValFrom,
            this.ValTo});
            this.valueDataGrid.Location = new System.Drawing.Point(0, -2);
            this.valueDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valueDataGrid.Name = "valueDataGrid";
            this.valueDataGrid.ShowCellToolTips = false;
            this.valueDataGrid.Size = new System.Drawing.Size(706, 249);
            this.valueDataGrid.TabIndex = 0;
            // 
            // ValFrom
            // 
            this.ValFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValFrom.HeaderText = "Value From";
            this.ValFrom.Name = "ValFrom";
            // 
            // ValTo
            // 
            this.ValTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValTo.HeaderText = "Value To";
            this.ValTo.Name = "ValTo";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.getListBtn);
            this.flowLayoutPanel1.Controls.Add(this.splitContainer2);
            this.flowLayoutPanel1.Controls.Add(this.topNodesCheckBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(711, 46);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(94, 5);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.GroupNameSearch);
            this.splitContainer2.Size = new System.Drawing.Size(258, 43);
            this.splitContainer2.SplitterDistance = 88;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 16;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "GroupName:";
            // 
            // topNodesCheckBox
            // 
            this.topNodesCheckBox.AutoSize = true;
            this.topNodesCheckBox.Location = new System.Drawing.Point(360, 5);
            this.topNodesCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.topNodesCheckBox.Name = "topNodesCheckBox";
            this.topNodesCheckBox.Size = new System.Drawing.Size(144, 24);
            this.topNodesCheckBox.TabIndex = 8;
            this.topNodesCheckBox.Text = "only Top Nodes";
            this.toolTip1.SetToolTip(this.topNodesCheckBox, "toggles if groups with higher Hierarchy Level than 0 will be displayed\r\n");
            this.topNodesCheckBox.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Groupname
            // 
            this.Groupname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Groupname.FillWeight = 50F;
            this.Groupname.HeaderText = "Groupname";
            this.Groupname.Name = "Groupname";
            this.Groupname.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 100;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1476, 712);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AddNodeBtn);
            this.Controls.Add(this.CreateGroupBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1489, 739);
            this.Name = "Overview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CostCenterGroupBAPI";
            ((System.ComponentModel.ISupportInitialize)(this.getListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDetailGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valueDataGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button getListBtn;
        private System.Windows.Forms.DataGridView getListGridView;
        private System.Windows.Forms.TextBox GroupNameSearch;
        private System.Windows.Forms.Button getDetailBtn;
        private System.Windows.Forms.DataGridView getDetailGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groupname2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HierarchyLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descript;
        private System.Windows.Forms.Button CreateGroupBtn;
        private System.Windows.Forms.Button AddNodeBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox topNodesCheckBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView valueDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValTo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groupname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

