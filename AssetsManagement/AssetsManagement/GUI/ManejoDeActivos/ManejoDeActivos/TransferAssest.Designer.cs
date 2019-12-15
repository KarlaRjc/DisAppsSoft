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
            this.components = new System.ComponentModel.Container();
            this.assetTransferHistoryEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AssetsManagement_DbModelDataSet2 = new ManejoDeActivos._AssetsManagement_DbModelDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.labCbx = new System.Windows.Forms.ComboBox();
            this.TransferAssetBtn = new System.Windows.Forms.Button();
            this.assetTransferHistoryEntitiesTableAdapter = new ManejoDeActivos._AssetsManagement_DbModelDataSet2TableAdapters.AssetTransferHistoryEntitiesTableAdapter();
            this.transferedToLabidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferedFromLabidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferedByUseridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetTransferedidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetsTransferTable = new System.Windows.Forms.DataGridView();
            this.transferDescriptionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransferHistoryEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsTransferTable)).BeginInit();
            this.SuspendLayout();
            // 
            // assetTransferHistoryEntitiesBindingSource
            // 
            this.assetTransferHistoryEntitiesBindingSource.DataMember = "AssetTransferHistoryEntities";
            this.assetTransferHistoryEntitiesBindingSource.DataSource = this._AssetsManagement_DbModelDataSet2;
            // 
            // _AssetsManagement_DbModelDataSet2
            // 
            this._AssetsManagement_DbModelDataSet2.DataSetName = "_AssetsManagement_DbModelDataSet2";
            this._AssetsManagement_DbModelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(864, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Laboratorio de Destino";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labCbx
            // 
            this.labCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.labCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCbx.FormattingEnabled = true;
            this.labCbx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.labCbx.Location = new System.Drawing.Point(812, 192);
            this.labCbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labCbx.Name = "labCbx";
            this.labCbx.Size = new System.Drawing.Size(321, 33);
            this.labCbx.TabIndex = 8;
            // 
            // TransferAssetBtn
            // 
            this.TransferAssetBtn.FlatAppearance.BorderSize = 0;
            this.TransferAssetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferAssetBtn.Image = global::ManejoDeActivos.Properties.Resources.TransferirBtn;
            this.TransferAssetBtn.Location = new System.Drawing.Point(888, 429);
            this.TransferAssetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransferAssetBtn.Name = "TransferAssetBtn";
            this.TransferAssetBtn.Size = new System.Drawing.Size(184, 65);
            this.TransferAssetBtn.TabIndex = 13;
            this.TransferAssetBtn.UseVisualStyleBackColor = true;
            this.TransferAssetBtn.Click += new System.EventHandler(this.TransferAssetBtn_Click);
            // 
            // assetTransferHistoryEntitiesTableAdapter
            // 
            this.assetTransferHistoryEntitiesTableAdapter.ClearBeforeFill = true;
            // 
            // transferedToLabidDataGridViewTextBoxColumn
            // 
            this.transferedToLabidDataGridViewTextBoxColumn.DataPropertyName = "transferedToLab_id";
            this.transferedToLabidDataGridViewTextBoxColumn.HeaderText = "Id Laboratorio Transferido";
            this.transferedToLabidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transferedToLabidDataGridViewTextBoxColumn.Name = "transferedToLabidDataGridViewTextBoxColumn";
            this.transferedToLabidDataGridViewTextBoxColumn.ReadOnly = true;
            this.transferedToLabidDataGridViewTextBoxColumn.Width = 125;
            // 
            // transferedFromLabidDataGridViewTextBoxColumn
            // 
            this.transferedFromLabidDataGridViewTextBoxColumn.DataPropertyName = "transferedFromLab_id";
            this.transferedFromLabidDataGridViewTextBoxColumn.HeaderText = "Id Laboratio Transferiencia";
            this.transferedFromLabidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transferedFromLabidDataGridViewTextBoxColumn.Name = "transferedFromLabidDataGridViewTextBoxColumn";
            this.transferedFromLabidDataGridViewTextBoxColumn.ReadOnly = true;
            this.transferedFromLabidDataGridViewTextBoxColumn.Width = 125;
            // 
            // transferedByUseridDataGridViewTextBoxColumn
            // 
            this.transferedByUseridDataGridViewTextBoxColumn.DataPropertyName = "transferedByUser_id";
            this.transferedByUseridDataGridViewTextBoxColumn.HeaderText = "Id Usuario Transferencia";
            this.transferedByUseridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transferedByUseridDataGridViewTextBoxColumn.Name = "transferedByUseridDataGridViewTextBoxColumn";
            this.transferedByUseridDataGridViewTextBoxColumn.ReadOnly = true;
            this.transferedByUseridDataGridViewTextBoxColumn.Width = 125;
            // 
            // assetTransferedidDataGridViewTextBoxColumn
            // 
            this.assetTransferedidDataGridViewTextBoxColumn.DataPropertyName = "assetTransfered_id";
            this.assetTransferedidDataGridViewTextBoxColumn.HeaderText = "Id ActivoTransferido";
            this.assetTransferedidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assetTransferedidDataGridViewTextBoxColumn.Name = "assetTransferedidDataGridViewTextBoxColumn";
            this.assetTransferedidDataGridViewTextBoxColumn.ReadOnly = true;
            this.assetTransferedidDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // transferDateDataGridViewTextBoxColumn
            // 
            this.transferDateDataGridViewTextBoxColumn.DataPropertyName = "transferDate";
            this.transferDateDataGridViewTextBoxColumn.HeaderText = "Fecha Transferencia";
            this.transferDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transferDateDataGridViewTextBoxColumn.Name = "transferDateDataGridViewTextBoxColumn";
            this.transferDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.transferDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id Activo";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // assetsTransferTable
            // 
            this.assetsTransferTable.AllowUserToDeleteRows = false;
            this.assetsTransferTable.AutoGenerateColumns = false;
            this.assetsTransferTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetsTransferTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.transferDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.assetTransferedidDataGridViewTextBoxColumn,
            this.transferedByUseridDataGridViewTextBoxColumn,
            this.transferedFromLabidDataGridViewTextBoxColumn,
            this.transferedToLabidDataGridViewTextBoxColumn});
            this.assetsTransferTable.DataSource = this.assetTransferHistoryEntitiesBindingSource;
            this.assetsTransferTable.Location = new System.Drawing.Point(76, 111);
            this.assetsTransferTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.assetsTransferTable.Name = "assetsTransferTable";
            this.assetsTransferTable.ReadOnly = true;
            this.assetsTransferTable.RowHeadersWidth = 51;
            this.assetsTransferTable.RowTemplate.Height = 24;
            this.assetsTransferTable.Size = new System.Drawing.Size(672, 395);
            this.assetsTransferTable.TabIndex = 0;
            // 
            // transferDescriptionTxt
            // 
            this.transferDescriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferDescriptionTxt.Location = new System.Drawing.Point(812, 272);
            this.transferDescriptionTxt.Multiline = true;
            this.transferDescriptionTxt.Name = "transferDescriptionTxt";
            this.transferDescriptionTxt.Size = new System.Drawing.Size(321, 136);
            this.transferDescriptionTxt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(857, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Razón de Transferencia";
            // 
            // TransferAssest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1195, 745);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transferDescriptionTxt);
            this.Controls.Add(this.TransferAssetBtn);
            this.Controls.Add(this.labCbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assetsTransferTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransferAssest";
            this.Text = "TransferAssest";
            this.Load += new System.EventHandler(this.TransferAssest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetTransferHistoryEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsTransferTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox labCbx;
        private System.Windows.Forms.Button TransferAssetBtn;
        private _AssetsManagement_DbModelDataSet2 _AssetsManagement_DbModelDataSet2;
        private System.Windows.Forms.BindingSource assetTransferHistoryEntitiesBindingSource;
        private _AssetsManagement_DbModelDataSet2TableAdapters.AssetTransferHistoryEntitiesTableAdapter assetTransferHistoryEntitiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferedToLabidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferedFromLabidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferedByUseridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetTransferedidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView assetsTransferTable;
        private System.Windows.Forms.TextBox transferDescriptionTxt;
        private System.Windows.Forms.Label label2;
    }
}