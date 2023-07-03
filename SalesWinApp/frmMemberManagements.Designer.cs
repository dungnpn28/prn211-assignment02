
namespace MyStoreWinApp
{
    partial class frmMemberManagements
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbMemberID = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbMemberName = new System.Windows.Forms.Label();
            lbCountry = new System.Windows.Forms.Label();
            lbCity = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtMemberID = new System.Windows.Forms.TextBox();
            txtMemberName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnDelete = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            dgvMemberList = new System.Windows.Forms.DataGridView();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            btnFind = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txtCountry = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtSearchCountry = new System.Windows.Forms.TextBox();
            txtSearchCity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(51, 17);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(66, 15);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(51, 88);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(57, 15);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(51, 54);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(87, 15);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "Member Name";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(362, 56);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(50, 15);
            lbCountry.TabIndex = 3;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(362, 91);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(28, 15);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(362, 17);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(36, 15);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(438, 17);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new System.Drawing.Size(219, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(150, 17);
            txtMemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.ReadOnly = true;
            txtMemberID.Size = new System.Drawing.Size(192, 23);
            txtMemberID.TabIndex = 8;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new System.Drawing.Point(150, 51);
            txtMemberName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.ReadOnly = true;
            txtMemberName.Size = new System.Drawing.Size(192, 23);
            txtMemberName.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(150, 88);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ReadOnly = true;
            txtPassword.Size = new System.Drawing.Size(192, 23);
            txtPassword.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(238, 130);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(82, 22);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(150, 130);
            btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(82, 22);
            btnNew.TabIndex = 13;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(51, 130);
            btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(82, 22);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(308, 350);
            btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(82, 22);
            btnClose.TabIndex = 15;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new System.Drawing.Point(10, 185);
            dgvMemberList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvMemberList.MultiSelect = false;
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new System.Drawing.Size(680, 161);
            dgvMemberList.TabIndex = 16;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(150, 158);
            txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Seach member";
            txtSearch.Size = new System.Drawing.Size(403, 23);
            txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(586, 157);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(82, 22);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new System.Drawing.Point(586, 129);
            btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnFind.Name = "btnFind";
            btnFind.Size = new System.Drawing.Size(82, 22);
            btnFind.TabIndex = 22;
            btnFind.Text = "&Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(51, 161);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 15);
            label1.TabIndex = 23;
            label1.Text = "ID and/or Name";
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(438, 51);
            txtCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new System.Drawing.Size(219, 23);
            txtCountry.TabIndex = 24;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(438, 88);
            txtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new System.Drawing.Size(219, 23);
            txtCity.TabIndex = 25;
            // 
            // txtSearchCountry
            // 
            txtSearchCountry.Location = new System.Drawing.Point(344, 130);
            txtSearchCountry.Name = "txtSearchCountry";
            txtSearchCountry.PlaceholderText = "Country";
            txtSearchCountry.Size = new System.Drawing.Size(100, 23);
            txtSearchCountry.TabIndex = 26;
            // 
            // txtSearchCity
            // 
            txtSearchCity.Location = new System.Drawing.Point(453, 131);
            txtSearchCity.Name = "txtSearchCity";
            txtSearchCity.PlaceholderText = "City";
            txtSearchCity.Size = new System.Drawing.Size(100, 23);
            txtSearchCity.TabIndex = 27;
            // 
            // frmMemberManagements
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(697, 380);
            Controls.Add(txtSearchCity);
            Controls.Add(txtSearchCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCountry);
            Controls.Add(label1);
            Controls.Add(btnFind);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvMemberList);
            Controls.Add(btnClose);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(txtPassword);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(lbCity);
            Controls.Add(lbCountry);
            Controls.Add(lbMemberName);
            Controls.Add(lbPassword);
            Controls.Add(lbMemberID);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmMemberManagements";
            Text = "Member Management";
            Load += frmMemberManagements_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSearchCountry;
        private System.Windows.Forms.TextBox txtSearchCity;
    }
}

