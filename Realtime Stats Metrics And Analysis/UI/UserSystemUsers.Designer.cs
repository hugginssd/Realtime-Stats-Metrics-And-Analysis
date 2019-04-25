﻿namespace Realtime_Stats_Metrics_And_Analysis.UI
{
    partial class UserSystemUsers
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
            this.label3 = new System.Windows.Forms.Label();
            this.CmbRoles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesignation = new Windows.Forms.HintTextBox(this.components);
            this.txtUsername = new Windows.Forms.HintTextBox(this.components);
            this.txtConfirmPassword = new Windows.Forms.HintTextBox(this.components);
            this.txtPassword = new Windows.Forms.HintTextBox(this.components);
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new Windows.Forms.HintTextBox(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.txtEmail = new Windows.Forms.HintTextBox(this.components);
            this.txtLastname = new Windows.Forms.HintTextBox(this.components);
            this.txtFirstname = new Windows.Forms.HintTextBox(this.components);
            this.txtID = new Windows.Forms.HintTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.label3.Font = new System.Drawing.Font("Humanst521 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(983, 43);
            this.label3.TabIndex = 74;
            this.label3.Text = "System Users";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbRoles
            // 
            this.CmbRoles.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbRoles.FormattingEnabled = true;
            this.CmbRoles.Items.AddRange(new object[] {
            "User",
            "Super User"});
            this.CmbRoles.Location = new System.Drawing.Point(13, 376);
            this.CmbRoles.Name = "CmbRoles";
            this.CmbRoles.Size = new System.Drawing.Size(198, 22);
            this.CmbRoles.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(42, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(901, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Developed by Mambo Chami";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDesignation
            // 
            this.txtDesignation.EnterToTab = false;
            this.txtDesignation.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.ForeColor = System.Drawing.Color.Gray;
            this.txtDesignation.HintColor = System.Drawing.Color.Gray;
            this.txtDesignation.HintValue = "Designation";
            this.txtDesignation.Location = new System.Drawing.Point(221, 207);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(199, 23);
            this.txtDesignation.TabIndex = 71;
            this.txtDesignation.Text = "Designation";
            this.txtDesignation.TextForeColor = System.Drawing.Color.Black;
            this.txtDesignation.Value = "";
            // 
            // txtUsername
            // 
            this.txtUsername.EnterToTab = false;
            this.txtUsername.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.HintColor = System.Drawing.Color.Gray;
            this.txtUsername.HintValue = "Username";
            this.txtUsername.Location = new System.Drawing.Point(221, 265);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(199, 23);
            this.txtUsername.TabIndex = 70;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextForeColor = System.Drawing.Color.Black;
            this.txtUsername.Value = "";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.EnterToTab = false;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.HintColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.HintValue = "Confirm Password";
            this.txtConfirmPassword.Location = new System.Drawing.Point(221, 376);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(199, 23);
            this.txtConfirmPassword.TabIndex = 69;
            this.txtConfirmPassword.TextForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.Value = "";
            // 
            // txtPassword
            // 
            this.txtPassword.EnterToTab = false;
            this.txtPassword.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.HintColor = System.Drawing.Color.Gray;
            this.txtPassword.HintValue = "Password";
            this.txtPassword.Location = new System.Drawing.Point(221, 326);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(199, 23);
            this.txtPassword.TabIndex = 68;
            this.txtPassword.TextForeColor = System.Drawing.Color.Black;
            this.txtPassword.Value = "";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSearch.Location = new System.Drawing.Point(894, 155);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(86, 23);
            this.BtnSearch.TabIndex = 67;
            this.BtnSearch.Text = "SEARCH";
            this.BtnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.EnterToTab = false;
            this.txtSearch.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.HintColor = System.Drawing.Color.Gray;
            this.txtSearch.HintValue = "Search here....";
            this.txtSearch.Location = new System.Drawing.Point(426, 156);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(462, 23);
            this.txtSearch.TabIndex = 66;
            this.txtSearch.Text = "Search here....";
            this.txtSearch.TextForeColor = System.Drawing.Color.Black;
            this.txtSearch.Value = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(426, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 270);
            this.dataGridView1.TabIndex = 65;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.BtnReset.FlatAppearance.BorderSize = 0;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReset.Location = new System.Drawing.Point(221, 426);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(119, 29);
            this.BtnReset.TabIndex = 64;
            this.BtnReset.Text = "RESET";
            this.BtnReset.UseVisualStyleBackColor = false;
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.BtnCreate.FlatAppearance.BorderSize = 0;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCreate.Location = new System.Drawing.Point(13, 426);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(119, 29);
            this.BtnCreate.TabIndex = 63;
            this.BtnCreate.Text = "CREATE";
            this.BtnCreate.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.EnterToTab = false;
            this.txtEmail.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.HintColor = System.Drawing.Color.Gray;
            this.txtEmail.HintValue = "Email ID";
            this.txtEmail.Location = new System.Drawing.Point(12, 326);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 23);
            this.txtEmail.TabIndex = 62;
            this.txtEmail.Text = "Email ID";
            this.txtEmail.TextForeColor = System.Drawing.Color.Black;
            this.txtEmail.Value = "";
            // 
            // txtLastname
            // 
            this.txtLastname.EnterToTab = false;
            this.txtLastname.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.ForeColor = System.Drawing.Color.Gray;
            this.txtLastname.HintColor = System.Drawing.Color.Gray;
            this.txtLastname.HintValue = "Lastname";
            this.txtLastname.Location = new System.Drawing.Point(13, 265);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(199, 23);
            this.txtLastname.TabIndex = 61;
            this.txtLastname.Text = "Lastname";
            this.txtLastname.TextForeColor = System.Drawing.Color.Black;
            this.txtLastname.Value = "";
            // 
            // txtFirstname
            // 
            this.txtFirstname.EnterToTab = false;
            this.txtFirstname.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstname.HintColor = System.Drawing.Color.Gray;
            this.txtFirstname.HintValue = "Firstname";
            this.txtFirstname.Location = new System.Drawing.Point(13, 207);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(199, 23);
            this.txtFirstname.TabIndex = 60;
            this.txtFirstname.Text = "Firstname";
            this.txtFirstname.TextForeColor = System.Drawing.Color.Black;
            this.txtFirstname.Value = "";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.EnterToTab = false;
            this.txtID.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Gray;
            this.txtID.HintColor = System.Drawing.Color.Gray;
            this.txtID.HintValue = "ID";
            this.txtID.Location = new System.Drawing.Point(13, 157);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(199, 23);
            this.txtID.TabIndex = 59;
            this.txtID.Text = "ID";
            this.txtID.TextForeColor = System.Drawing.Color.Black;
            this.txtID.Value = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humanst521 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(9, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 58;
            this.label1.Text = "New System Users";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(986, 22);
            this.label4.TabIndex = 87;
            this.label4.Text = "Developed by Mambo Chami";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserSystemUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbRoles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "UserSystemUsers";
            this.Size = new System.Drawing.Size(984, 489);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbRoles;
        private System.Windows.Forms.Label label2;
        private Windows.Forms.HintTextBox txtDesignation;
        private Windows.Forms.HintTextBox txtUsername;
        private Windows.Forms.HintTextBox txtConfirmPassword;
        private Windows.Forms.HintTextBox txtPassword;
        private System.Windows.Forms.Button BtnSearch;
        private Windows.Forms.HintTextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnCreate;
        private Windows.Forms.HintTextBox txtEmail;
        private Windows.Forms.HintTextBox txtLastname;
        private Windows.Forms.HintTextBox txtFirstname;
        private Windows.Forms.HintTextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
