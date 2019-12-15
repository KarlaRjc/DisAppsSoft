namespace ManejoDeActivos
{
    partial class TransferHistory
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
            this.assestTransferHsitoryTable = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnteriorLAB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.assestTransferHsitoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // assestTransferHsitoryTable
            // 
            this.assestTransferHsitoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assestTransferHsitoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Usuario,
            this.Tipo,
            this.AnteriorLAB,
            this.actualLab});
            this.assestTransferHsitoryTable.Location = new System.Drawing.Point(154, 54);
            this.assestTransferHsitoryTable.Margin = new System.Windows.Forms.Padding(2);
            this.assestTransferHsitoryTable.Name = "assestTransferHsitoryTable";
            this.assestTransferHsitoryTable.RowHeadersWidth = 51;
            this.assestTransferHsitoryTable.RowTemplate.Height = 24;
            this.assestTransferHsitoryTable.Size = new System.Drawing.Size(596, 516);
            this.assestTransferHsitoryTable.TabIndex = 11;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Activo";
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
            this.Tipo.HeaderText = "Fecha";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // AnteriorLAB
            // 
            this.AnteriorLAB.HeaderText = "LAB Anterior";
            this.AnteriorLAB.MinimumWidth = 6;
            this.AnteriorLAB.Name = "AnteriorLAB";
            this.AnteriorLAB.Width = 125;
            // 
            // actualLab
            // 
            this.actualLab.HeaderText = "LAB Actual";
            this.actualLab.MinimumWidth = 6;
            this.actualLab.Name = "actualLab";
            this.actualLab.Width = 125;
            // 
            // TransferHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(909, 640);
            this.Controls.Add(this.assestTransferHsitoryTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TransferHistory";
            this.Text = "TransferHistory";
            this.Load += new System.EventHandler(this.TransferHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assestTransferHsitoryTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView assestTransferHsitoryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnteriorLAB;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualLab;
    }
}