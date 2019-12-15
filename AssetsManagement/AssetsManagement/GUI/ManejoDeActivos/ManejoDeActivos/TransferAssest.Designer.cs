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
            this.assetsTransferTable = new System.Windows.Forms.DataGridView();
            this.assetTransferHistoryEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AssetsManagement_DbModelDataSet2 = new ManejoDeActivos._AssetsManagement_DbModelDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.labCbx = new System.Windows.Forms.ComboBox();
            this.TransferAssetBtn = new System.Windows.Forms.Button();
            this.assetTransferHistoryEntitiesTableAdapter = new ManejoDeActivos._AssetsManagement_DbModelDataSet2TableAdapters.AssetTransferHistoryEntitiesTableAdapter();
            this._AssetsManagement_DbModelDataSet3 = new ManejoDeActivos._AssetsManagement_DbModelDataSet3();
            this.assetEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetEntitiesTableAdapter = new ManejoDeActivos._AssetsManagement_DbModelDataSet3TableAdapters.AssetEntitiesTableAdapter();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.assetsTransferTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransferHistoryEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assetsTransferTable
            // 
            this.assetsTransferTable.AllowUserToDeleteRows = false;
            this.assetsTransferTable.AutoGenerateColumns = false;
            this.assetsTransferTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetsTransferTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serie,
            this.descriptionDataGridViewTextBoxColumn,
            this.Marca,
            this.Modelo});
            this.assetsTransferTable.DataSource = this.assetEntitiesBindingSource;
            this.assetsTransferTable.Location = new System.Drawing.Point(76, 111);
            this.assetsTransferTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.assetsTransferTable.Name = "assetsTransferTable";
            this.assetsTransferTable.ReadOnly = true;
            this.assetsTransferTable.RowHeadersWidth = 51;
            this.assetsTransferTable.RowTemplate.Height = 24;
            this.assetsTransferTable.Size = new System.Drawing.Size(672, 395);
            this.assetsTransferTable.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(843, 155);
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
            this.labCbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // _AssetsManagement_DbModelDataSet3
            // 
            this._AssetsManagement_DbModelDataSet3.DataSetName = "_AssetsManagement_DbModelDataSet3";
            this._AssetsManagement_DbModelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetEntitiesBindingSource
            // 
            this.assetEntitiesBindingSource.DataMember = "AssetEntities";
            this.assetEntitiesBindingSource.DataSource = this._AssetsManagement_DbModelDataSet3;
            // 
            // assetEntitiesTableAdapter
            // 
            this.assetEntitiesTableAdapter.ClearBeforeFill = true;
            // 
            // Serie
            // 
            this.Serie.DataPropertyName = "series";
            this.Serie.HeaderText = "No. Identificacion";
            this.Serie.MinimumWidth = 6;
            this.Serie.Name = "Serie";
            this.Serie.ReadOnly = true;
            this.Serie.Width = 125;
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
            // Marca
            // 
            this.Marca.DataPropertyName = "brand";
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 125;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "model";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 125;
            // 
            // TransferAssest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1195, 745);
            this.Controls.Add(this.TransferAssetBtn);
            this.Controls.Add(this.labCbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assetsTransferTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransferAssest";
            this.Text = "TransferAssest";
            this.Load += new System.EventHandler(this.TransferAssest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetsTransferTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransferHistoryEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView assetsTransferTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox labCbx;
        private System.Windows.Forms.Button TransferAssetBtn;
        private _AssetsManagement_DbModelDataSet2 _AssetsManagement_DbModelDataSet2;
        private System.Windows.Forms.BindingSource assetTransferHistoryEntitiesBindingSource;
        private _AssetsManagement_DbModelDataSet2TableAdapters.AssetTransferHistoryEntitiesTableAdapter assetTransferHistoryEntitiesTableAdapter;
        private _AssetsManagement_DbModelDataSet3 _AssetsManagement_DbModelDataSet3;
        private System.Windows.Forms.BindingSource assetEntitiesBindingSource;
        private _AssetsManagement_DbModelDataSet3TableAdapters.AssetEntitiesTableAdapter assetEntitiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
    }
}