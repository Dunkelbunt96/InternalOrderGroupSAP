namespace InternalOrderGroupBAPI
{
    partial class CreateGroup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGroup));
            this.createGridView = new System.Windows.Forms.DataGridView();
            this.createBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.valueDataGrid = new System.Windows.Forms.DataGridView();
            this.ValueFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.createGroupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createValcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDescript = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.createGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // createGridView
            // 
            this.createGridView.AllowUserToAddRows = false;
            this.createGridView.AllowUserToDeleteRows = false;
            this.createGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.createGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.createGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createGroupname,
            this.createValcount,
            this.createDescript});
            this.createGridView.EnableHeadersVisualStyles = false;
            this.createGridView.Location = new System.Drawing.Point(3, 3);
            this.createGridView.Name = "createGridView";
            this.createGridView.RowHeadersVisible = false;
            this.createGridView.RowTemplate.Height = 24;
            this.createGridView.ShowCellToolTips = false;
            this.createGridView.Size = new System.Drawing.Size(988, 111);
            this.createGridView.TabIndex = 11;
            this.toolTip1.SetToolTip(this.createGridView, resources.GetString("createGridView.ToolTip"));
            this.createGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.createGridView_CellContentClick);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(3, 332);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(218, 29);
            this.createBtn.TabIndex = 12;
            this.createBtn.Text = "create CostCenter Group";
            this.toolTip1.SetToolTip(this.createBtn, "creates a new group with the specified attributes");
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.valueDataGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.createGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.createBtn, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 18);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 374);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // valueDataGrid
            // 
            this.valueDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valueDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ValueFrom,
            this.ValueTo});
            this.valueDataGrid.Location = new System.Drawing.Point(4, 122);
            this.valueDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valueDataGrid.Name = "valueDataGrid";
            this.valueDataGrid.ShowCellToolTips = false;
            this.valueDataGrid.Size = new System.Drawing.Size(360, 202);
            this.valueDataGrid.TabIndex = 14;
            this.toolTip1.SetToolTip(this.valueDataGrid, "specifies the values of the new group.\r\nThe number of rows must be equal to the v" +
        "alue of \"Valcount\".\r\nEqual rows are forbidden.");
            this.valueDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.valueDataGrid_CellContentClick);
            this.valueDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.valueDataGrid_RowsAdded);
            // 
            // ValueFrom
            // 
            this.ValueFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValueFrom.HeaderText = "Value From";
            this.ValueFrom.Name = "ValueFrom";
            // 
            // ValueTo
            // 
            this.ValueTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValueTo.HeaderText = "Value To";
            this.ValueTo.Name = "ValueTo";
            // 
            // createGroupname
            // 
            this.createGroupname.Frozen = true;
            this.createGroupname.HeaderText = "Groupname";
            this.createGroupname.Name = "createGroupname";
            // 
            // createValcount
            // 
            this.createValcount.Frozen = true;
            this.createValcount.HeaderText = "Valcount";
            this.createValcount.Name = "createValcount";
            // 
            // createDescript
            // 
            this.createDescript.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createDescript.HeaderText = "Descript";
            this.createDescript.Name = "createDescript";
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateGroup";
            ((System.ComponentModel.ISupportInitialize)(this.createGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valueDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView createGridView;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView valueDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueTo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createGroupname;
        private System.Windows.Forms.DataGridViewTextBoxColumn createValcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDescript;
    }
}