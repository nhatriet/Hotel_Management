namespace HotelManagement.All_User_Control
{
    partial class UC_CustomerDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgwCustomerDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomerDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin chi tiết khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(924, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSearchBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBy.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtSearchBy.ForeColor = System.Drawing.Color.Black;
            this.txtSearchBy.ItemHeight = 30;
            this.txtSearchBy.Items.AddRange(new object[] {
            "All Customer Details",
            "In Hotel Customer",
            "Checkout Customer"});
            this.txtSearchBy.Location = new System.Drawing.Point(928, 164);
            this.txtSearchBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(609, 36);
            this.txtSearchBy.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchBy.TabIndex = 11;
            this.txtSearchBy.SelectedIndexChanged += new System.EventHandler(this.txtSearchBy_SelectedIndexChanged);
            // 
            // dgwCustomerDetail
            // 
            this.dgwCustomerDetail.AllowUserToAddRows = false;
            this.dgwCustomerDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgwCustomerDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwCustomerDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwCustomerDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwCustomerDetail.ColumnHeadersHeight = 4;
            this.dgwCustomerDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwCustomerDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwCustomerDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwCustomerDetail.Location = new System.Drawing.Point(49, 252);
            this.dgwCustomerDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgwCustomerDetail.Name = "dgwCustomerDetail";
            this.dgwCustomerDetail.RowHeadersVisible = false;
            this.dgwCustomerDetail.RowHeadersWidth = 51;
            this.dgwCustomerDetail.Size = new System.Drawing.Size(2351, 603);
            this.dgwCustomerDetail.TabIndex = 12;
            this.dgwCustomerDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgwCustomerDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgwCustomerDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgwCustomerDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgwCustomerDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgwCustomerDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgwCustomerDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwCustomerDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgwCustomerDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwCustomerDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgwCustomerDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgwCustomerDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgwCustomerDetail.ThemeStyle.HeaderStyle.Height = 4;
            this.dgwCustomerDetail.ThemeStyle.ReadOnly = false;
            this.dgwCustomerDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgwCustomerDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwCustomerDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgwCustomerDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgwCustomerDetail.ThemeStyle.RowsStyle.Height = 22;
            this.dgwCustomerDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwCustomerDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // UC_CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgwCustomerDetail);
            this.Controls.Add(this.txtSearchBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_CustomerDetails";
            this.Size = new System.Drawing.Size(2504, 1044);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomerDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox txtSearchBy;
        private Guna.UI2.WinForms.Guna2DataGridView dgwCustomerDetail;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}