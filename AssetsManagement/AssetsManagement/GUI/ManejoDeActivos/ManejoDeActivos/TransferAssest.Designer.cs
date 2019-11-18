namespace ManejoDeActivos
{
    partial class TransferAssest
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
            this.assetsTransferTable = new System.Windows.Forms.DataGridView();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labCbx = new System.Windows.Forms.ComboBox();
            this.TransferAssetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.assetsTransferTable)).BeginInit();
            this.SuspendLayout();
            // 
            // assetsTransferTable
            // 
            this.assetsTransferTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetsTransferTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Activo,
            this.Tipo,
            this.Laboratorio});
            this.assetsTransferTable.Location = new System.Drawing.Point(104, 155);
            this.assetsTransferTable.Name = "assetsTransferTable";
            this.assetsTransferTable.RowHeadersWidth = 51;
            this.assetsTransferTable.RowTemplate.Height = 24;
            this.assetsTransferTable.Size = new System.Drawing.Size(569, 150);
            this.assetsTransferTable.TabIndex = 0;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 6;
            this.Activo.Name = "Activo";
            this.Activo.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // Laboratorio
            // 
            this.Laboratorio.HeaderText = "Laboratorio";
            this.Laboratorio.MinimumWidth = 6;
            this.Laboratorio.Name = "Laboratorio";
            this.Laboratorio.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(842, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Laboratorio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labCbx
            // 
            this.labCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCbx.FormattingEnabled = true;
            this.labCbx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.labCbx.Location = new System.Drawing.Point(841, 192);
            this.labCbx.Name = "labCbx";
            this.labCbx.Size = new System.Drawing.Size(117, 33);
            this.labCbx.TabIndex = 8;
            // 
            // TransferAssetBtn
            // 
            this.TransferAssetBtn.FlatAppearance.BorderSize = 0;
            this.TransferAssetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferAssetBtn.Image = global::ManejoDeActivos.Properties.Resources.TransferirBtn;
            this.TransferAssetBtn.Location = new System.Drawing.Point(807, 249);
            this.TransferAssetBtn.Name = "TransferAssetBtn";
            this.TransferAssetBtn.Size = new System.Drawing.Size(184, 65);
            this.TransferAssetBtn.TabIndex = 13;
            this.TransferAssetBtn.UseVisualStyleBackColor = true;
            // 
            // TransferAssest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1194, 745);
            this.Controls.Add(this.TransferAssetBtn);
            this.Controls.Add(this.labCbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assetsTransferTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransferAssest";
            this.Text = "TransferAssest";
            ((System.ComponentModel.ISupportInitialize)(this.assetsTransferTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView assetsTransferTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox labCbx;
        private System.Windows.Forms.Button TransferAssetBtn;
    }
}