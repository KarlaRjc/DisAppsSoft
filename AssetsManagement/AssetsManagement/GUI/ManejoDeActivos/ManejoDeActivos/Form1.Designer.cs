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
            this.homePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.transferAssestBtn = new System.Windows.Forms.Button();
            this.userManagmentBtn = new System.Windows.Forms.Button();
            this.assestManagmentBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.homePanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1539, 875);
            this.panel1.TabIndex = 0;
            // 
            // homePanel
            // 
            this.homePanel.Location = new System.Drawing.Point(327, 83);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1212, 792);
            this.homePanel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.transferAssestBtn);
            this.panel3.Controls.Add(this.userManagmentBtn);
            this.panel3.Controls.Add(this.assestManagmentBtn);
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 912);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1539, 86);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1356, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administrador";
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
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::ManejoDeActivos.Properties.Resources.ReportesBtn;
            this.button5.Location = new System.Drawing.Point(17, 447);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(289, 98);
            this.button5.TabIndex = 2;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::ManejoDeActivos.Properties.Resources.HistorialTransferenciasBtn;
            this.button4.Location = new System.Drawing.Point(17, 341);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(287, 98);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // transferAssestBtn
            // 
            this.transferAssestBtn.FlatAppearance.BorderSize = 0;
            this.transferAssestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferAssestBtn.Image = global::ManejoDeActivos.Properties.Resources.RealizarTransferenciasBtn;
            this.transferAssestBtn.Location = new System.Drawing.Point(17, 235);
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
            this.userManagmentBtn.Location = new System.Drawing.Point(17, 138);
            this.userManagmentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.userManagmentBtn.Name = "userManagmentBtn";
            this.userManagmentBtn.Size = new System.Drawing.Size(287, 90);
            this.userManagmentBtn.TabIndex = 2;
            this.userManagmentBtn.UseVisualStyleBackColor = true;
            this.userManagmentBtn.Click += new System.EventHandler(this.userManagmentBtn_Click);
            // 
            // assestManagmentBtn
            // 
            this.assestManagmentBtn.FlatAppearance.BorderSize = 0;
            this.assestManagmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assestManagmentBtn.Image = global::ManejoDeActivos.Properties.Resources.ManejoActivosBtn;
            this.assestManagmentBtn.Location = new System.Drawing.Point(17, 41);
            this.assestManagmentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.assestManagmentBtn.Name = "assestManagmentBtn";
            this.assestManagmentBtn.Size = new System.Drawing.Size(292, 90);
            this.assestManagmentBtn.TabIndex = 2;
            this.assestManagmentBtn.UseVisualStyleBackColor = true;
            this.assestManagmentBtn.Click += new System.EventHandler(this.assestManagmentBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 876);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button transferAssestBtn;
        private System.Windows.Forms.Button userManagmentBtn;
        private System.Windows.Forms.Button assestManagmentBtn;
        private System.Windows.Forms.Panel homePanel;
    }
}

