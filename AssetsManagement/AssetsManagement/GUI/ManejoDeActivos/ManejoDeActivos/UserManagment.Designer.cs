﻿namespace ManejoDeActivos
{
    partial class UserManagment
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
            this.nameUserTxt = new System.Windows.Forms.TextBox();
            this.userRolCbx = new System.Windows.Forms.ComboBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usersTable = new System.Windows.Forms.DataGridView();
            this.userEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AssetsManagement_DbModelDataSet = new ManejoDeActivos._AssetsManagement_DbModelDataSet();
            this.errorNameUserLbl = new System.Windows.Forms.Label();
            this.errorUsernameLbl = new System.Windows.Forms.Label();
            this.errorPasswordLbl = new System.Windows.Forms.Label();
            this.errorUserRoleLbl = new System.Windows.Forms.Label();
            this.outputUserLbl = new System.Windows.Forms.Label();
            this.removeUserBtn = new System.Windows.Forms.Button();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.userEntitiesTableAdapter = new ManejoDeActivos._AssetsManagement_DbModelDataSetTableAdapters.UserEntitiesTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameUserTxt
            // 
            this.nameUserTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameUserTxt.Location = new System.Drawing.Point(584, 94);
            this.nameUserTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameUserTxt.Name = "nameUserTxt";
            this.nameUserTxt.Size = new System.Drawing.Size(216, 26);
            this.nameUserTxt.TabIndex = 1;
            // 
            // userRolCbx
            // 
            this.userRolCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRolCbx.FormattingEnabled = true;
            this.userRolCbx.Items.AddRange(new object[] {
            "Administrador",
            "Profesor",
            "Observador"});
            this.userRolCbx.Location = new System.Drawing.Point(584, 314);
            this.userRolCbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userRolCbx.Name = "userRolCbx";
            this.userRolCbx.Size = new System.Drawing.Size(216, 28);
            this.userRolCbx.TabIndex = 4;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(584, 240);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(216, 26);
            this.passwordTxt.TabIndex = 3;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(584, 167);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(216, 26);
            this.usernameTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(646, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(658, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(646, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(669, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rol";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // usersTable
            // 
            this.usersTable.AutoGenerateColumns = false;
            this.usersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.usersTable.DataSource = this.userEntitiesBindingSource;
            this.usersTable.Enabled = false;
            this.usersTable.Location = new System.Drawing.Point(54, 74);
            this.usersTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usersTable.Name = "usersTable";
            this.usersTable.RowHeadersWidth = 51;
            this.usersTable.RowTemplate.Height = 24;
            this.usersTable.Size = new System.Drawing.Size(428, 349);
            this.usersTable.TabIndex = 10;
            // 
            // userEntitiesBindingSource
            // 
            this.userEntitiesBindingSource.DataMember = "UserEntities";
            this.userEntitiesBindingSource.DataSource = this._AssetsManagement_DbModelDataSet;
            // 
            // _AssetsManagement_DbModelDataSet
            // 
            this._AssetsManagement_DbModelDataSet.DataSetName = "_AssetsManagement_DbModelDataSet";
            this._AssetsManagement_DbModelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorNameUserLbl
            // 
            this.errorNameUserLbl.AutoSize = true;
            this.errorNameUserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNameUserLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.errorNameUserLbl.Location = new System.Drawing.Point(587, 121);
            this.errorNameUserLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorNameUserLbl.Name = "errorNameUserLbl";
            this.errorNameUserLbl.Size = new System.Drawing.Size(0, 17);
            this.errorNameUserLbl.TabIndex = 14;
            // 
            // errorUsernameLbl
            // 
            this.errorUsernameLbl.AutoSize = true;
            this.errorUsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorUsernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.errorUsernameLbl.Location = new System.Drawing.Point(587, 193);
            this.errorUsernameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorUsernameLbl.Name = "errorUsernameLbl";
            this.errorUsernameLbl.Size = new System.Drawing.Size(0, 17);
            this.errorUsernameLbl.TabIndex = 15;
            // 
            // errorPasswordLbl
            // 
            this.errorPasswordLbl.AutoSize = true;
            this.errorPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorPasswordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.errorPasswordLbl.Location = new System.Drawing.Point(587, 266);
            this.errorPasswordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorPasswordLbl.Name = "errorPasswordLbl";
            this.errorPasswordLbl.Size = new System.Drawing.Size(0, 17);
            this.errorPasswordLbl.TabIndex = 16;
            // 
            // errorUserRoleLbl
            // 
            this.errorUserRoleLbl.AutoSize = true;
            this.errorUserRoleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorUserRoleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.errorUserRoleLbl.Location = new System.Drawing.Point(587, 343);
            this.errorUserRoleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorUserRoleLbl.Name = "errorUserRoleLbl";
            this.errorUserRoleLbl.Size = new System.Drawing.Size(0, 17);
            this.errorUserRoleLbl.TabIndex = 17;
            // 
            // outputUserLbl
            // 
            this.outputUserLbl.AutoSize = true;
            this.outputUserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputUserLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.outputUserLbl.Location = new System.Drawing.Point(620, 451);
            this.outputUserLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputUserLbl.Name = "outputUserLbl";
            this.outputUserLbl.Size = new System.Drawing.Size(0, 17);
            this.outputUserLbl.TabIndex = 18;
            this.outputUserLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // removeUserBtn
            // 
            this.removeUserBtn.FlatAppearance.BorderSize = 0;
            this.removeUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeUserBtn.Image = global::ManejoDeActivos.Properties.Resources.EliminarBtn;
            this.removeUserBtn.Location = new System.Drawing.Point(216, 451);
            this.removeUserBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeUserBtn.Name = "removeUserBtn";
            this.removeUserBtn.Size = new System.Drawing.Size(106, 41);
            this.removeUserBtn.TabIndex = 13;
            this.removeUserBtn.UseVisualStyleBackColor = true;
            // 
            // editUserBtn
            // 
            this.editUserBtn.FlatAppearance.BorderSize = 0;
            this.editUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserBtn.Image = global::ManejoDeActivos.Properties.Resources.EdiarBtn;
            this.editUserBtn.Location = new System.Drawing.Point(584, 379);
            this.editUserBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(106, 41);
            this.editUserBtn.TabIndex = 12;
            this.editUserBtn.UseVisualStyleBackColor = true;
            // 
            // addUserBtn
            // 
            this.addUserBtn.FlatAppearance.BorderSize = 0;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Image = global::ManejoDeActivos.Properties.Resources.AgregarBtn;
            this.addUserBtn.Location = new System.Drawing.Point(693, 379);
            this.addUserBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(106, 41);
            this.addUserBtn.TabIndex = 9;
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // userEntitiesTableAdapter
            // 
            this.userEntitiesTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Nombre Usuario";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // UserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(909, 640);
            this.Controls.Add(this.outputUserLbl);
            this.Controls.Add(this.errorUserRoleLbl);
            this.Controls.Add(this.errorPasswordLbl);
            this.Controls.Add(this.errorUsernameLbl);
            this.Controls.Add(this.errorNameUserLbl);
            this.Controls.Add(this.removeUserBtn);
            this.Controls.Add(this.editUserBtn);
            this.Controls.Add(this.usersTable);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userRolCbx);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.nameUserTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserManagment";
            this.Text = "UserManagment";
            this.Load += new System.EventHandler(this.UserManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameUserTxt;
        private System.Windows.Forms.ComboBox userRolCbx;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.DataGridView usersTable;
        private System.Windows.Forms.Button editUserBtn;
        private System.Windows.Forms.Button removeUserBtn;
        private System.Windows.Forms.Label errorNameUserLbl;
        private System.Windows.Forms.Label errorUsernameLbl;
        private System.Windows.Forms.Label errorPasswordLbl;
        private System.Windows.Forms.Label errorUserRoleLbl;
        private System.Windows.Forms.Label outputUserLbl;
        private _AssetsManagement_DbModelDataSet _AssetsManagement_DbModelDataSet;
        private System.Windows.Forms.BindingSource userEntitiesBindingSource;
        private _AssetsManagement_DbModelDataSetTableAdapters.UserEntitiesTableAdapter userEntitiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
    }
}