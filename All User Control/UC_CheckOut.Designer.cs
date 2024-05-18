namespace HotelManagement.All_User_Control
{
    partial class UC_CheckOut
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
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgwCheckOut = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtCName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.txtCheckOutDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnReport = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(455, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(458, 130);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Enter fullname";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(458, 64);
            this.txtName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // dgwCheckOut
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgwCheckOut.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwCheckOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwCheckOut.ColumnHeadersHeight = 4;
            this.dgwCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwCheckOut.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwCheckOut.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwCheckOut.Location = new System.Drawing.Point(43, 237);
            this.dgwCheckOut.Name = "dgwCheckOut";
            this.dgwCheckOut.RowHeadersVisible = false;
            this.dgwCheckOut.Size = new System.Drawing.Size(1732, 336);
            this.dgwCheckOut.TabIndex = 4;
            this.dgwCheckOut.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgwCheckOut.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgwCheckOut.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgwCheckOut.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgwCheckOut.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgwCheckOut.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgwCheckOut.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwCheckOut.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgwCheckOut.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgwCheckOut.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgwCheckOut.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgwCheckOut.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgwCheckOut.ThemeStyle.HeaderStyle.Height = 4;
            this.dgwCheckOut.ThemeStyle.ReadOnly = false;
            this.dgwCheckOut.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgwCheckOut.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwCheckOut.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgwCheckOut.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgwCheckOut.ThemeStyle.RowsStyle.Height = 22;
            this.dgwCheckOut.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgwCheckOut.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgwCheckOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCheckOut_CellContentClick);
            // 
            // txtCName
            // 
            this.txtCName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCName.DefaultText = "";
            this.txtCName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCName.ForeColor = System.Drawing.Color.Black;
            this.txtCName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCName.Location = new System.Drawing.Point(604, 655);
            this.txtCName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCName.Name = "txtCName";
            this.txtCName.PasswordChar = '\0';
            this.txtCName.PlaceholderText = "Enter fullname";
            this.txtCName.SelectedText = "";
            this.txtCName.Size = new System.Drawing.Size(458, 64);
            this.txtCName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên";
            // 
            // txtRoom
            // 
            this.txtRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoom.DefaultText = "";
            this.txtRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtRoom.ForeColor = System.Drawing.Color.Black;
            this.txtRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoom.Location = new System.Drawing.Point(43, 655);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.PasswordChar = '\0';
            this.txtRoom.PlaceholderText = "Enter room no";
            this.txtRoom.ReadOnly = true;
            this.txtRoom.SelectedText = "";
            this.txtRoom.Size = new System.Drawing.Size(458, 64);
            this.txtRoom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRoom.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(600, 598);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1149, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày thanh toán";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderRadius = 18;
            this.btnCheckOut.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnCheckOut.BorderThickness = 1;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.Location = new System.Drawing.Point(1570, 664);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(180, 45);
            this.btnCheckOut.TabIndex = 28;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtCheckOutDate
            // 
            this.txtCheckOutDate.Checked = true;
            this.txtCheckOutDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.txtCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCheckOutDate.Location = new System.Drawing.Point(1152, 655);
            this.txtCheckOutDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtCheckOutDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtCheckOutDate.Name = "txtCheckOutDate";
            this.txtCheckOutDate.Size = new System.Drawing.Size(340, 64);
            this.txtCheckOutDate.TabIndex = 29;
            this.txtCheckOutDate.Value = new System.DateTime(2024, 4, 24, 18, 57, 20, 393);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnReport
            // 
            this.btnReport.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Location = new System.Drawing.Point(1075, 130);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(180, 45);
            this.btnReport.TabIndex = 30;
            this.btnReport.Text = "In hóa đơn";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // UC_CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtCheckOutDate);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgwCheckOut);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_CheckOut";
            this.Size = new System.Drawing.Size(1878, 848);
            this.Load += new System.EventHandler(this.UC_CheckOut_Load);
            this.Leave += new System.EventHandler(this.UC_CheckOut_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2DataGridView dgwCheckOut;
        private Guna.UI2.WinForms.Guna2TextBox txtCName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtCheckOutDate;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnReport;
    }
}
