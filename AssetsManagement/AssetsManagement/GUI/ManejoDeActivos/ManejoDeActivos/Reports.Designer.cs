namespace ManejoDeActivos
{
    partial class Reports
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
            this.report1_panel = new System.Windows.Forms.Panel();
            this.report1Label = new System.Windows.Forms.Label();
            this.assetsByLab_Grid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.report2_label = new System.Windows.Forms.Label();
            this.report1_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsByLab_Grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // report1_panel
            // 
            this.report1_panel.BackColor = System.Drawing.Color.White;
            this.report1_panel.Controls.Add(this.assetsByLab_Grid);
            this.report1_panel.Controls.Add(this.report1Label);
            this.report1_panel.Location = new System.Drawing.Point(12, 12);
            this.report1_panel.Name = "report1_panel";
            this.report1_panel.Size = new System.Drawing.Size(873, 465);
            this.report1_panel.TabIndex = 0;
            // 
            // report1Label
            // 
            this.report1Label.AutoSize = true;
            this.report1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report1Label.Location = new System.Drawing.Point(17, 14);
            this.report1Label.Name = "report1Label";
            this.report1Label.Size = new System.Drawing.Size(338, 37);
            this.report1Label.TabIndex = 0;
            this.report1Label.Text = "Activos por laboratorio";
            // 
            // assetsByLab_Grid
            // 
            this.assetsByLab_Grid.AllowUserToAddRows = false;
            this.assetsByLab_Grid.AllowUserToDeleteRows = false;
            this.assetsByLab_Grid.AllowUserToOrderColumns = true;
            this.assetsByLab_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetsByLab_Grid.Location = new System.Drawing.Point(24, 66);
            this.assetsByLab_Grid.Name = "assetsByLab_Grid";
            this.assetsByLab_Grid.ReadOnly = true;
            this.assetsByLab_Grid.Size = new System.Drawing.Size(834, 378);
            this.assetsByLab_Grid.TabIndex = 1;
            this.assetsByLab_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assetsByLab_Grid_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.report2_label);
            this.panel1.Location = new System.Drawing.Point(12, 498);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 465);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(834, 378);
            this.dataGridView1.TabIndex = 1;
            // 
            // report2_label
            // 
            this.report2_label.AutoSize = true;
            this.report2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report2_label.Location = new System.Drawing.Point(17, 14);
            this.report2_label.Name = "report2_label";
            this.report2_label.Size = new System.Drawing.Size(400, 37);
            this.report2_label.TabIndex = 0;
            this.report2_label.Text = "Transferencias por usuario";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(909, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.report1_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.report1_panel.ResumeLayout(false);
            this.report1_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetsByLab_Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel report1_panel;
        private System.Windows.Forms.Label report1Label;
        private System.Windows.Forms.DataGridView assetsByLab_Grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label report2_label;
    }
}