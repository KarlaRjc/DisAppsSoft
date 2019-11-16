namespace ManejoDeActivos
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
            this.nameUserTxt = new System.Windows.Forms.TextBox();
            this.userTypeCbx = new System.Windows.Forms.ComboBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeUserBtn = new System.Windows.Forms.Button();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameUserTxt
            // 
            this.nameUserTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameUserTxt.Location = new System.Drawing.Point(779, 116);
            this.nameUserTxt.Name = "nameUserTxt";
            this.nameUserTxt.Size = new System.Drawing.Size(286, 30);
            this.nameUserTxt.TabIndex = 1;
            // 
            // userTypeCbx
            // 
            this.userTypeCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeCbx.FormattingEnabled = true;
            this.userTypeCbx.Items.AddRange(new object[] {
            "Administrador",
            "Profesor",
            "Observador"});
            this.userTypeCbx.Location = new System.Drawing.Point(779, 386);
            this.userTypeCbx.Name = "userTypeCbx";
            this.userTypeCbx.Size = new System.Drawing.Size(286, 33);
            this.userTypeCbx.TabIndex = 4;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(779, 295);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(286, 30);
            this.passwordTxt.TabIndex = 3;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(779, 205);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(286, 30);
            this.usernameTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(862, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(878, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(862, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(892, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Usuario,
            this.Tipo});
            this.dataGridView1.Location = new System.Drawing.Point(72, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 430);
            this.dataGridView1.TabIndex = 10;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // removeUserBtn
            // 
            this.removeUserBtn.FlatAppearance.BorderSize = 0;
            this.removeUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeUserBtn.Image = global::ManejoDeActivos.Properties.Resources.EliminarBtn;
            this.removeUserBtn.Location = new System.Drawing.Point(288, 555);
            this.removeUserBtn.Name = "removeUserBtn";
            this.removeUserBtn.Size = new System.Drawing.Size(141, 50);
            this.removeUserBtn.TabIndex = 13;
            this.removeUserBtn.UseVisualStyleBackColor = true;
            // 
            // editUserBtn
            // 
            this.editUserBtn.FlatAppearance.BorderSize = 0;
            this.editUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserBtn.Image = global::ManejoDeActivos.Properties.Resources.EdiarBtn;
            this.editUserBtn.Location = new System.Drawing.Point(779, 466);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(141, 50);
            this.editUserBtn.TabIndex = 12;
            this.editUserBtn.UseVisualStyleBackColor = true;
            // 
            // addUserBtn
            // 
            this.addUserBtn.FlatAppearance.BorderSize = 0;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Image = global::ManejoDeActivos.Properties.Resources.AgregarBtn;
            this.addUserBtn.Location = new System.Drawing.Point(924, 466);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(141, 50);
            this.addUserBtn.TabIndex = 9;
            this.addUserBtn.UseVisualStyleBackColor = true;
            // 
            // UserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1212, 792);
            this.Controls.Add(this.removeUserBtn);
            this.Controls.Add(this.editUserBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userTypeCbx);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.nameUserTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManagment";
            this.Text = "UserManagment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameUserTxt;
        private System.Windows.Forms.ComboBox userTypeCbx;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button editUserBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.Button removeUserBtn;
    }
}