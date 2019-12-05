namespace ManejoDeActivos
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.transferHisotryBtn = new System.Windows.Forms.Button();
            this.transferAssestBtn = new System.Windows.Forms.Button();
            this.userManagmentBtn = new System.Windows.Forms.Button();
            this.assestManagmentBtn = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CurrentRoleText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LoginErrorBox = new System.Windows.Forms.RichTextBox();
            this.LoginButton = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.LoginButton.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.homePanel);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1539, 874);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.panel3.Controls.Add(this.transferHisotryBtn);
            this.panel3.Controls.Add(this.transferAssestBtn);
            this.panel3.Controls.Add(this.assestManagmentBtn);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.userManagmentBtn);
            this.panel3.Controls.Add(this.reportsBtn);
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 912);
            this.panel3.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::ManejoDeActivos.Properties.Resources.SalirBtn;
            this.button6.Location = new System.Drawing.Point(17, 706);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(193, 74);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // reportsBtn
            // 
            this.reportsBtn.FlatAppearance.BorderSize = 0;
            this.reportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsBtn.Image = global::ManejoDeActivos.Properties.Resources.ReportesBtn;
            this.reportsBtn.Location = new System.Drawing.Point(19, 27);
            this.reportsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(289, 98);
            this.reportsBtn.TabIndex = 2;
            this.reportsBtn.UseVisualStyleBackColor = true;
            this.reportsBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // transferHisotryBtn
            // 
            this.transferHisotryBtn.FlatAppearance.BorderSize = 0;
            this.transferHisotryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferHisotryBtn.Image = global::ManejoDeActivos.Properties.Resources.HistorialTransferenciasBtn;
            this.transferHisotryBtn.Location = new System.Drawing.Point(17, 196);
            this.transferHisotryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.transferHisotryBtn.Name = "transferHisotryBtn";
            this.transferHisotryBtn.Size = new System.Drawing.Size(287, 98);
            this.transferHisotryBtn.TabIndex = 4;
            this.transferHisotryBtn.UseVisualStyleBackColor = true;
            this.transferHisotryBtn.Click += new System.EventHandler(this.transferHisotryBtn_Click);
            // 
            // transferAssestBtn
            // 
            this.transferAssestBtn.FlatAppearance.BorderSize = 0;
            this.transferAssestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferAssestBtn.Image = global::ManejoDeActivos.Properties.Resources.RealizarTransferenciasBtn;
            this.transferAssestBtn.Location = new System.Drawing.Point(19, 98);
            this.transferAssestBtn.Margin = new System.Windows.Forms.Padding(4);
            this.transferAssestBtn.Name = "transferAssestBtn";
            this.transferAssestBtn.Size = new System.Drawing.Size(287, 98);
            this.transferAssestBtn.TabIndex = 3;
            this.transferAssestBtn.UseVisualStyleBackColor = true;
            this.transferAssestBtn.Click += new System.EventHandler(this.transferAssestBtn_Click);
            // 
            // userManagmentBtn
            // 
            this.userManagmentBtn.FlatAppearance.BorderSize = 0;
            this.userManagmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userManagmentBtn.Image = global::ManejoDeActivos.Properties.Resources.ManejoUsuariosBtn;
            this.userManagmentBtn.Location = new System.Drawing.Point(17, 378);
            this.userManagmentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.userManagmentBtn.Name = "userManagmentBtn";
            this.userManagmentBtn.Size = new System.Drawing.Size(287, 96);
            this.userManagmentBtn.TabIndex = 2;
            this.userManagmentBtn.UseVisualStyleBackColor = true;
            this.userManagmentBtn.Click += new System.EventHandler(this.userManagmentBtn_Click);
            // 
            // assestManagmentBtn
            // 
            this.assestManagmentBtn.FlatAppearance.BorderSize = 0;
            this.assestManagmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assestManagmentBtn.Image = global::ManejoDeActivos.Properties.Resources.ManejoActivosBtn;
            this.assestManagmentBtn.Location = new System.Drawing.Point(17, 289);
            this.assestManagmentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.assestManagmentBtn.Name = "assestManagmentBtn";
            this.assestManagmentBtn.Size = new System.Drawing.Size(292, 90);
            this.assestManagmentBtn.TabIndex = 2;
            this.assestManagmentBtn.UseVisualStyleBackColor = true;
            this.assestManagmentBtn.Click += new System.EventHandler(this.assestManagmentBtn_Click);
            // 
            // homePanel
            // 
            this.homePanel.Location = new System.Drawing.Point(327, 82);
            this.homePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1212, 791);
            this.homePanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.panel2.Controls.Add(this.CurrentRoleText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1539, 86);
            this.panel2.TabIndex = 0;
            // 
            // CurrentRoleText
            // 
            this.CurrentRoleText.AutoSize = true;
            this.CurrentRoleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentRoleText.ForeColor = System.Drawing.Color.White;
            this.CurrentRoleText.Location = new System.Drawing.Point(1356, 25);
            this.CurrentRoleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentRoleText.Name = "CurrentRoleText";
            this.CurrentRoleText.Size = new System.Drawing.Size(162, 29);
            this.CurrentRoleText.TabIndex = 1;
            this.CurrentRoleText.Text = "Administrador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manejo de Activos";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LoginPanel.Controls.Add(this.panel5);
            this.LoginPanel.Location = new System.Drawing.Point(1, 2);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1539, 3212);
            this.LoginPanel.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.LoginErrorBox);
            this.panel5.Controls.Add(this.LoginButton);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.passwordInput);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.UserNameInput);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(509, 94);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(580, 649);
            this.panel5.TabIndex = 0;
            // 
            // LoginErrorBox
            // 
            this.LoginErrorBox.Location = new System.Drawing.Point(99, 448);
            this.LoginErrorBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginErrorBox.Name = "LoginErrorBox";
            this.LoginErrorBox.Size = new System.Drawing.Size(405, 109);
            this.LoginErrorBox.TabIndex = 6;
            this.LoginErrorBox.Text = "";
            this.LoginErrorBox.Visible = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.LoginButton.Controls.Add(this.label7);
            this.LoginButton.Location = new System.Drawing.Point(99, 373);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(407, 68);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginButton_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(149, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ingresar";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.panel8.Location = new System.Drawing.Point(0, 84);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(580, 49);
            this.panel8.TabIndex = 2;
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(92, 305);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(4);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(412, 34);
            this.passwordInput.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(87, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(93, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre de usuario";
            // 
            // UserNameInput
            // 
            this.UserNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameInput.Location = new System.Drawing.Point(92, 215);
            this.UserNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(412, 34);
            this.UserNameInput.TabIndex = 3;
            this.UserNameInput.TextChanged += new System.EventHandler(this.UserNameInput_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(0, 565);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(580, 84);
            this.panel7.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(145, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "¿Olvidaste tu constraseña?";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(580, 84);
            this.panel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(248, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Login";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 876);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LoginPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.LoginButton.ResumeLayout(false);
            this.LoginButton.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentRoleText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button transferHisotryBtn;
        private System.Windows.Forms.Button transferAssestBtn;
        private System.Windows.Forms.Button userManagmentBtn;
        private System.Windows.Forms.Button assestManagmentBtn;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel LoginButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox LoginErrorBox;
    }
}

