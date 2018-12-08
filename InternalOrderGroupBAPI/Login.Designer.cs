namespace InternalOrderGroupBAPI
{
    partial class Login
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
            this.loginbtn = new System.Windows.Forms.Button();
            this.connectionlbl = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Infolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(140, 254);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(84, 29);
            this.loginbtn.TabIndex = 1;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // connectionlbl
            // 
            this.connectionlbl.AutoSize = true;
            this.connectionlbl.Location = new System.Drawing.Point(266, 254);
            this.connectionlbl.Name = "connectionlbl";
            this.connectionlbl.Size = new System.Drawing.Size(0, 20);
            this.connectionlbl.TabIndex = 2;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(140, 98);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(148, 26);
            this.NameBox.TabIndex = 3;
            this.NameBox.Text = "IDES-046";
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged_2);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(140, 172);
            this.PassBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(148, 26);
            this.PassBox.TabIndex = 4;
            this.PassBox.Text = "99so{HYc~\\nhzZs=hY}+~2BMw%GGz3oBoMY%)bF~";
            this.PassBox.TextChanged += new System.EventHandler(this.PassBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // Infolabel
            // 
            this.Infolabel.AutoSize = true;
            this.Infolabel.Location = new System.Drawing.Point(140, 300);
            this.Infolabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Infolabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.Infolabel.Name = "Infolabel";
            this.Infolabel.Size = new System.Drawing.Size(0, 20);
            this.Infolabel.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 378);
            this.Controls.Add(this.Infolabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.connectionlbl);
            this.Controls.Add(this.loginbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CostCenterGroupBAPI Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label connectionlbl;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Infolabel;
       
    }
}

