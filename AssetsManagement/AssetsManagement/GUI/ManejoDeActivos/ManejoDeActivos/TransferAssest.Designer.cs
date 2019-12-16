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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labEntityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetEntitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._AssetsManagement_assets = new ManejoDeActivos._AssetsManagement_assets();
            this.assetEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AssetsManagement_DbModelDataSet3 = new ManejoDeActivos._AssetsManagement_DbModelDataSet3();
            this.assetTransferHistoryEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AssetsManagement_DbModelDataSet2 = new ManejoDeActivos._AssetsManagement_DbModelDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.labCbx = new System.Windows.Forms.ComboBox();
            this.TransferAssetBtn = new System.Windows.Forms.Button();
            this.assetTransferHistoryEntitiesTableAdapter = new ManejoDeActivos._AssetsManagement_DbModelDataSet2TableAdapters.AssetTransferHistoryEntitiesTableAdapter();
            this.assetEntitiesTableAdapter = new ManejoDeActivos._AssetsManagement_DbModelDataSet3TableAdapters.AssetEntitiesTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.transfer_comment_text = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.asset_to_transfer_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.assetTransferHistoryEntitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._AssetsManagement_DbModelDataSet4 = new ManejoDeActivos._AssetsManagement_DbModelDataSet4();
            this.assetTransferHistoryEntitiesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.assetTransferHistoryEntitiesTableAdapter1 = new ManejoDeActivos._AssetsManagement_DbModelDataSet4TableAdapters.AssetTransferHistoryEntitiesTableAdapter();
            this.assetEntitiesTableAdapter1 = new ManejoDeActivos._AssetsManagement_assetsTableAdapters.AssetEntitiesTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trasnfer_comment_label = new System.Windows.Forms.Label();
            this.cmbx_lab_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assetsTransferTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetEntitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_assets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransferHistoryEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransferHistoryEntitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransferHistoryEntitiesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // assetsTransferTable
            // 
            this.assetsTransferTable.AllowUserToAddRows = false;
            this.assetsTransferTable.AllowUserToDeleteRows = false;
            this.assetsTransferTable.AutoGenerateColumns = false;
            this.assetsTransferTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetsTransferTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.description,
            this.brand,
            this.model,
            this.series,
            this.state,
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.seriesDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.labEntityidDataGridViewTextBoxColumn});
            this.assetsTransferTable.DataSource = this.assetEntitiesBindingSource1;
            this.assetsTransferTable.Location = new System.Drawing.Point(57, 90);
            this.assetsTransferTable.Margin = new System.Windows.Forms.Padding(2);
            this.assetsTransferTable.Name = "assetsTransferTable";
            this.assetsTransferTable.ReadOnly = true;
            this.assetsTransferTable.RowHeadersWidth = 51;
            this.assetsTransferTable.RowTemplate.Height = 24;
            this.assetsTransferTable.Size = new System.Drawing.Size(504, 321);
            this.assetsTransferTable.TabIndex = 0;
            this.assetsTransferTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assetsTransferTable_CellClick);
            this.assetsTransferTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assetsTransferTable_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Activo";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "Marca";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            // 
            // model
            // 
            this.model.DataPropertyName = "model";
            this.model.HeaderText = "Modelo";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // series
            // 
            this.series.DataPropertyName = "series";
            this.series.HeaderText = "Serie";
            this.series.Name = "series";
            this.series.ReadOnly = true;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "Estado";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seriesDataGridViewTextBoxColumn
            // 
            this.seriesDataGridViewTextBoxColumn.DataPropertyName = "series";
            this.seriesDataGridViewTextBoxColumn.HeaderText = "series";
            this.seriesDataGridViewTextBoxColumn.Name = "seriesDataGridViewTextBoxColumn";
            this.seriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // labEntityidDataGridViewTextBoxColumn
            // 
            this.labEntityidDataGridViewTextBoxColumn.DataPropertyName = "LabEntity_id";
            this.labEntityidDataGridViewTextBoxColumn.HeaderText = "LabEntity_id";
            this.labEntityidDataGridViewTextBoxColumn.Name = "labEntityidDataGridViewTextBoxColumn";
            this.labEntityidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assetEntitiesBindingSource1
            // 
            this.assetEntitiesBindingSource1.DataMember = "AssetEntities";
            this.assetEntitiesBindingSource1.DataSource = this._AssetsManagement_assets;
            // 
            // _AssetsManagement_assets
            // 
            this._AssetsManagement_assets.DataSetName = "_AssetsManagement_assets";
            this._AssetsManagement_assets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetEntitiesBindingSource
            // 
            this.assetEntitiesBindingSource.DataMember = "AssetEntities";
            this.assetEntitiesBindingSource.DataSource = this._AssetsManagement_DbModelDataSet3;
            // 
            // _AssetsManagement_DbModelDataSet3
            // 
            this._AssetsManagement_DbModelDataSet3.DataSetName = "_AssetsManagement_DbModelDataSet3";
            this._AssetsManagement_DbModelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Location = new System.Drawing.Point(619, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Laboratorio a transferir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labCbx
            // 
            this.labCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.labCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCbx.FormattingEnabled = true;
            this.labCbx.Location = new System.Drawing.Point(631, 124);
            this.labCbx.Margin = new System.Windows.Forms.Padding(2);
            this.labCbx.Name = "labCbx";
            this.labCbx.Size = new System.Drawing.Size(158, 28);
            this.labCbx.TabIndex = 8;
            this.labCbx.SelectedIndexChanged += new System.EventHandler(this.labCbx_SelectedIndexChanged);
            // 
            // TransferAssetBtn
            // 
            this.TransferAssetBtn.FlatAppearance.BorderSize = 0;
            this.TransferAssetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferAssetBtn.Image = global::ManejoDeActivos.Properties.Resources.TransferirBtn;
            this.TransferAssetBtn.Location = new System.Drawing.Point(664, 366);
            this.TransferAssetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.TransferAssetBtn.Name = "TransferAssetBtn";
            this.TransferAssetBtn.Size = new System.Drawing.Size(142, 53);
            this.TransferAssetBtn.TabIndex = 13;
            this.TransferAssetBtn.UseVisualStyleBackColor = true;
            this.TransferAssetBtn.Click += new System.EventHandler(this.TransferAssetBtn_Click);
            // 
            // assetTransferHistoryEntitiesTableAdapter
            // 
            this.assetTransferHistoryEntitiesTableAdapter.ClearBeforeFill = true;
            // 
            // assetEntitiesTableAdapter
            // 
            this.assetEntitiesTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // transfer_comment_text
            // 
            this.transfer_comment_text.Location = new System.Drawing.Point(610, 247);
            this.transfer_comment_text.Name = "transfer_comment_text";
            this.transfer_comment_text.Size = new System.Drawing.Size(217, 96);
            this.transfer_comment_text.TabIndex = 16;
            this.transfer_comment_text.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(636, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Activo a transferir";
            // 
            // asset_to_transfer_label
            // 
            this.asset_to_transfer_label.AutoSize = true;
            this.asset_to_transfer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asset_to_transfer_label.Location = new System.Drawing.Point(620, 180);
            this.asset_to_transfer_label.Name = "asset_to_transfer_label";
            this.asset_to_transfer_label.Size = new System.Drawing.Size(0, 18);
            this.asset_to_transfer_label.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(619, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Motivo de la transferencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Seleccione un activo";
            // 
            // assetTransferHistoryEntitiesBindingSource1
            // 
            this.assetTransferHistoryEntitiesBindingSource1.DataMember = "AssetTransferHistoryEntities";
            this.assetTransferHistoryEntitiesBindingSource1.DataSource = this._AssetsManagement_DbModelDataSet2;
            // 
            // _AssetsManagement_DbModelDataSet4
            // 
            this._AssetsManagement_DbModelDataSet4.DataSetName = "_AssetsManagement_DbModelDataSet4";
            this._AssetsManagement_DbModelDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetTransferHistoryEntitiesBindingSource2
            // 
            this.assetTransferHistoryEntitiesBindingSource2.DataMember = "AssetTransferHistoryEntities";
            this.assetTransferHistoryEntitiesBindingSource2.DataSource = this._AssetsManagement_DbModelDataSet4;
            // 
            // assetTransferHistoryEntitiesTableAdapter1
            // 
            this.assetTransferHistoryEntitiesTableAdapter1.ClearBeforeFill = true;
            // 
            // assetEntitiesTableAdapter1
            // 
            this.assetEntitiesTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.assetTransferHistoryEntitiesBindingSource;
            // 
            // trasnfer_comment_label
            // 
            this.trasnfer_comment_label.AutoSize = true;
            this.trasnfer_comment_label.ForeColor = System.Drawing.Color.Red;
            this.trasnfer_comment_label.Location = new System.Drawing.Point(620, 345);
            this.trasnfer_comment_label.Name = "trasnfer_comment_label";
            this.trasnfer_comment_label.Size = new System.Drawing.Size(0, 16);
            this.trasnfer_comment_label.TabIndex = 21;
            this.trasnfer_comment_label.UseCompatibleTextRendering = true;
            // 
            // cmbx_lab_error
            // 
            this.cmbx_lab_error.AutoSize = true;
            this.cmbx_lab_error.ForeColor = System.Drawing.Color.Red;
            this.cmbx_lab_error.Location = new System.Drawing.Point(716, 124);
            this.cmbx_lab_error.Name = "cmbx_lab_error";
            this.cmbx_lab_error.Size = new System.Drawing.Size(0, 16);
            this.cmbx_lab_error.TabIndex = 22;
            this.cmbx_lab_error.UseCompatibleTextRendering = true;
            // 
            // TransferAssest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(896, 605);
            this.Controls.Add(this.cmbx_lab_error);
            this.Controls.Add(this.trasnfer_comment_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.asset_to_transfer_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transfer_comment_text);
            this.Controls.Add(this.TransferAssetBtn);
            this.Controls.Add(this.labCbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assetsTransferTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TransferAssest";
            this.Text = "TransferAssest";
            this.Load += new System.EventHandler(this.TransferAssest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetsTransferTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetEntitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_assets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransferHistoryEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransferHistoryEntitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetTransferHistoryEntitiesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox transfer_comment_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label asset_to_transfer_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource assetTransferHistoryEntitiesBindingSource1;
        private _AssetsManagement_DbModelDataSet4 _AssetsManagement_DbModelDataSet4;
        private System.Windows.Forms.BindingSource assetTransferHistoryEntitiesBindingSource2;
        private _AssetsManagement_DbModelDataSet4TableAdapters.AssetTransferHistoryEntitiesTableAdapter assetTransferHistoryEntitiesTableAdapter1;
        private _AssetsManagement_assets _AssetsManagement_assets;
        private System.Windows.Forms.BindingSource assetEntitiesBindingSource1;
        private _AssetsManagement_assetsTableAdapters.AssetEntitiesTableAdapter assetEntitiesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn series;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labEntityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label trasnfer_comment_label;
        private System.Windows.Forms.Label cmbx_lab_error;
    }
}