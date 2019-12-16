namespace ManejoDeActivos
{
    partial class AssetManagment
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
            this.outputAssestLbl = new System.Windows.Forms.Label();
            this.errorAssestBrandLbl = new System.Windows.Forms.Label();
            this.errorAssestDescriptionLbl = new System.Windows.Forms.Label();
            this.errorAssestModelLbl = new System.Windows.Forms.Label();
            this.assetsManagmentTable = new System.Windows.Forms.DataGridView();
            this.assetEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._AssetsManagement_DbModelDataSet1 = new ManejoDeActivos._AssetsManagement_DbModelDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assestBrandTxt = new System.Windows.Forms.TextBox();
            this.assestDescriptionTxt = new System.Windows.Forms.TextBox();
            this.errorAssestSerialNumLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.assestSerialNumberTxt = new System.Windows.Forms.TextBox();
            this.errorAssestStateLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorAssestLocationLbl = new System.Windows.Forms.Label();
            this.assestModelTxt = new System.Windows.Forms.TextBox();
            this.assestStateCbx = new System.Windows.Forms.ComboBox();
            this.removeAssetBtn = new System.Windows.Forms.Button();
            this.editAssestBtn = new System.Windows.Forms.Button();
            this.addAssestBtn = new System.Windows.Forms.Button();
            this.assetEntitiesTableAdapter = new ManejoDeActivos._AssetsManagement_DbModelDataSet1TableAdapters.AssetEntitiesTableAdapter();
            this.assestIdNumberTxt_ErrorLabel = new System.Windows.Forms.Label();
            this.assestDescriptionTxt_ErrorLabel = new System.Windows.Forms.Label();
            this.assestBrandTxt_ErrorLabel = new System.Windows.Forms.Label();
            this.assestModelTxt_ErrorLabel = new System.Windows.Forms.Label();
            this.assestSerialNumberTxt_ErrorLabel = new System.Windows.Forms.Label();
            this.assestStateCbx_ErrorLabel = new System.Windows.Forms.Label();
            this.assetLocationCbx_ErrorLabel = new System.Windows.Forms.Label();
            this.cleanFormBtn = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.assetsManagmentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // outputAssestLbl
            // 
            this.outputAssestLbl.AutoSize = true;
            this.outputAssestLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputAssestLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.outputAssestLbl.Location = new System.Drawing.Point(621, 549);
            this.outputAssestLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputAssestLbl.Name = "outputAssestLbl";
            this.outputAssestLbl.Size = new System.Drawing.Size(0, 20);
            this.outputAssestLbl.TabIndex = 35;
            this.outputAssestLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorAssestBrandLbl
            // 
            this.errorAssestBrandLbl.AutoSize = true;
            this.errorAssestBrandLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAssestBrandLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.errorAssestBrandLbl.Location = new System.Drawing.Point(624, 187);
            this.errorAssestBrandLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorAssestBrandLbl.Name = "errorAssestBrandLbl";
            this.errorAssestBrandLbl.Size = new System.Drawing.Size(0, 17);
            this.errorAssestBrandLbl.TabIndex = 33;
            // 
            // errorAssestDescriptionLbl
            // 
            this.errorAssestDescriptionLbl.AutoSize = true;
            this.errorAssestDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAssestDescriptionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.errorAssestDescriptionLbl.Location = new System.Drawing.Point(624, 114);
            this.errorAssestDescriptionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorAssestDescriptionLbl.Name = "errorAssestDescriptionLbl";
            this.errorAssestDescriptionLbl.Size = new System.Drawing.Size(0, 17);
            this.errorAssestDescriptionLbl.TabIndex = 32;
            // 
            // errorAssestModelLbl
            // 
            this.errorAssestModelLbl.AutoSize = true;
            this.errorAssestModelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAssestModelLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.errorAssestModelLbl.Location = new System.Drawing.Point(624, 263);
            this.errorAssestModelLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorAssestModelLbl.Name = "errorAssestModelLbl";
            this.errorAssestModelLbl.Size = new System.Drawing.Size(0, 17);
            this.errorAssestModelLbl.TabIndex = 34;
            // 
            // assetsManagmentTable
            // 
            this.assetsManagmentTable.AllowUserToAddRows = false;
            this.assetsManagmentTable.AllowUserToDeleteRows = false;
            this.assetsManagmentTable.AutoGenerateColumns = false;
            this.assetsManagmentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetsManagmentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.descriptionDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.seriesDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.assetsManagmentTable.DataSource = this.assetEntitiesBindingSource;
            this.assetsManagmentTable.Location = new System.Drawing.Point(42, 60);
            this.assetsManagmentTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.assetsManagmentTable.Name = "assetsManagmentTable";
            this.assetsManagmentTable.ReadOnly = true;
            this.assetsManagmentTable.RowHeadersWidth = 51;
            this.assetsManagmentTable.RowTemplate.Height = 24;
            this.assetsManagmentTable.Size = new System.Drawing.Size(536, 452);
            this.assetsManagmentTable.TabIndex = 28;
            // 
            // assetEntitiesBindingSource
            // 
            this.assetEntitiesBindingSource.DataMember = "AssetEntities";
            this.assetEntitiesBindingSource.DataSource = this._AssetsManagement_DbModelDataSet1;
            // 
            // _AssetsManagement_DbModelDataSet1
            // 
            this._AssetsManagement_DbModelDataSet1.DataSetName = "_AssetsManagement_DbModelDataSet1";
            this._AssetsManagement_DbModelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(706, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(706, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(683, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Descripción";
            // 
            // assestBrandTxt
            // 
            this.assestBrandTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assestBrandTxt.Location = new System.Drawing.Point(621, 161);
            this.assestBrandTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.assestBrandTxt.Name = "assestBrandTxt";
            this.assestBrandTxt.Size = new System.Drawing.Size(216, 26);
            this.assestBrandTxt.TabIndex = 21;
            // 
            // assestDescriptionTxt
            // 
            this.assestDescriptionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assestDescriptionTxt.Location = new System.Drawing.Point(621, 86);
            this.assestDescriptionTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.assestDescriptionTxt.Name = "assestDescriptionTxt";
            this.assestDescriptionTxt.Size = new System.Drawing.Size(216, 26);
            this.assestDescriptionTxt.TabIndex = 20;
            // 
            // errorAssestSerialNumLbl
            // 
            this.errorAssestSerialNumLbl.AutoSize = true;
            this.errorAssestSerialNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAssestSerialNumLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.errorAssestSerialNumLbl.Location = new System.Drawing.Point(624, 328);
            this.errorAssestSerialNumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorAssestSerialNumLbl.Name = "errorAssestSerialNumLbl";
            this.errorAssestSerialNumLbl.Size = new System.Drawing.Size(0, 17);
            this.errorAssestSerialNumLbl.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(673, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Número Serial";
            // 
            // assestSerialNumberTxt
            // 
            this.assestSerialNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assestSerialNumberTxt.Location = new System.Drawing.Point(621, 301);
            this.assestSerialNumberTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.assestSerialNumberTxt.Name = "assestSerialNumberTxt";
            this.assestSerialNumberTxt.Size = new System.Drawing.Size(216, 26);
            this.assestSerialNumberTxt.TabIndex = 36;
            // 
            // errorAssestStateLbl
            // 
            this.errorAssestStateLbl.AutoSize = true;
            this.errorAssestStateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAssestStateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.errorAssestStateLbl.Location = new System.Drawing.Point(624, 422);
            this.errorAssestStateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorAssestStateLbl.Name = "errorAssestStateLbl";
            this.errorAssestStateLbl.Size = new System.Drawing.Size(0, 17);
            this.errorAssestStateLbl.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(698, 350);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Estado";
            // 
            // errorAssestLocationLbl
            // 
            this.errorAssestLocationLbl.AutoSize = true;
            this.errorAssestLocationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAssestLocationLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(63)))), ((int)(((byte)(140)))));
            this.errorAssestLocationLbl.Location = new System.Drawing.Point(622, 557);
            this.errorAssestLocationLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorAssestLocationLbl.Name = "errorAssestLocationLbl";
            this.errorAssestLocationLbl.Size = new System.Drawing.Size(0, 17);
            this.errorAssestLocationLbl.TabIndex = 44;
            // 
            // assestModelTxt
            // 
            this.assestModelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assestModelTxt.Location = new System.Drawing.Point(618, 235);
            this.assestModelTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.assestModelTxt.Name = "assestModelTxt";
            this.assestModelTxt.Size = new System.Drawing.Size(216, 26);
            this.assestModelTxt.TabIndex = 46;
            // 
            // assestStateCbx
            // 
            this.assestStateCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assestStateCbx.FormattingEnabled = true;
            this.assestStateCbx.Items.AddRange(new object[] {
            "Bueno",
            "Regular",
            "Malo",
            "Reparación",
            "Otro"});
            this.assestStateCbx.Location = new System.Drawing.Point(618, 370);
            this.assestStateCbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.assestStateCbx.Name = "assestStateCbx";
            this.assestStateCbx.Size = new System.Drawing.Size(216, 28);
            this.assestStateCbx.TabIndex = 47;
            // 
            // removeAssetBtn
            // 
            this.removeAssetBtn.FlatAppearance.BorderSize = 0;
            this.removeAssetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAssetBtn.Image = global::ManejoDeActivos.Properties.Resources.EliminarBtn;
            this.removeAssetBtn.Location = new System.Drawing.Point(243, 544);
            this.removeAssetBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeAssetBtn.Name = "removeAssetBtn";
            this.removeAssetBtn.Size = new System.Drawing.Size(106, 41);
            this.removeAssetBtn.TabIndex = 30;
            this.removeAssetBtn.UseVisualStyleBackColor = true;
            this.removeAssetBtn.Click += new System.EventHandler(this.RemoveAssetBtn_Click);
            // 
            // editAssestBtn
            // 
            this.editAssestBtn.FlatAppearance.BorderSize = 0;
            this.editAssestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAssestBtn.Image = global::ManejoDeActivos.Properties.Resources.EdiarBtn;
            this.editAssestBtn.Location = new System.Drawing.Point(618, 448);
            this.editAssestBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editAssestBtn.Name = "editAssestBtn";
            this.editAssestBtn.Size = new System.Drawing.Size(106, 42);
            this.editAssestBtn.TabIndex = 29;
            this.editAssestBtn.UseVisualStyleBackColor = true;
            // 
            // addAssestBtn
            // 
            this.addAssestBtn.FlatAppearance.BorderSize = 0;
            this.addAssestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAssestBtn.Image = global::ManejoDeActivos.Properties.Resources.AgregarBtn;
            this.addAssestBtn.Location = new System.Drawing.Point(726, 448);
            this.addAssestBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addAssestBtn.Name = "addAssestBtn";
            this.addAssestBtn.Size = new System.Drawing.Size(106, 42);
            this.addAssestBtn.TabIndex = 27;
            this.addAssestBtn.UseVisualStyleBackColor = true;
            this.addAssestBtn.Click += new System.EventHandler(this.addAssestBtn_Click);
            // 
            // assetEntitiesTableAdapter
            // 
            this.assetEntitiesTableAdapter.ClearBeforeFill = true;
            // 
            // assestIdNumberTxt_ErrorLabel
            // 
            this.assestIdNumberTxt_ErrorLabel.AutoSize = true;
            this.assestIdNumberTxt_ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.assestIdNumberTxt_ErrorLabel.Location = new System.Drawing.Point(622, 42);
            this.assestIdNumberTxt_ErrorLabel.Name = "assestIdNumberTxt_ErrorLabel";
            this.assestIdNumberTxt_ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.assestIdNumberTxt_ErrorLabel.TabIndex = 48;
            // 
            // assestDescriptionTxt_ErrorLabel
            // 
            this.assestDescriptionTxt_ErrorLabel.AutoSize = true;
            this.assestDescriptionTxt_ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.assestDescriptionTxt_ErrorLabel.Location = new System.Drawing.Point(622, 116);
            this.assestDescriptionTxt_ErrorLabel.Name = "assestDescriptionTxt_ErrorLabel";
            this.assestDescriptionTxt_ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.assestDescriptionTxt_ErrorLabel.TabIndex = 49;
            // 
            // assestBrandTxt_ErrorLabel
            // 
            this.assestBrandTxt_ErrorLabel.AutoSize = true;
            this.assestBrandTxt_ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.assestBrandTxt_ErrorLabel.Location = new System.Drawing.Point(622, 190);
            this.assestBrandTxt_ErrorLabel.Name = "assestBrandTxt_ErrorLabel";
            this.assestBrandTxt_ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.assestBrandTxt_ErrorLabel.TabIndex = 50;
            // 
            // assestModelTxt_ErrorLabel
            // 
            this.assestModelTxt_ErrorLabel.AutoSize = true;
            this.assestModelTxt_ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.assestModelTxt_ErrorLabel.Location = new System.Drawing.Point(618, 262);
            this.assestModelTxt_ErrorLabel.Name = "assestModelTxt_ErrorLabel";
            this.assestModelTxt_ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.assestModelTxt_ErrorLabel.TabIndex = 51;
            // 
            // assestSerialNumberTxt_ErrorLabel
            // 
            this.assestSerialNumberTxt_ErrorLabel.AutoSize = true;
            this.assestSerialNumberTxt_ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.assestSerialNumberTxt_ErrorLabel.Location = new System.Drawing.Point(622, 330);
            this.assestSerialNumberTxt_ErrorLabel.Name = "assestSerialNumberTxt_ErrorLabel";
            this.assestSerialNumberTxt_ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.assestSerialNumberTxt_ErrorLabel.TabIndex = 52;
            // 
            // assestStateCbx_ErrorLabel
            // 
            this.assestStateCbx_ErrorLabel.AutoSize = true;
            this.assestStateCbx_ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.assestStateCbx_ErrorLabel.Location = new System.Drawing.Point(618, 423);
            this.assestStateCbx_ErrorLabel.Name = "assestStateCbx_ErrorLabel";
            this.assestStateCbx_ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.assestStateCbx_ErrorLabel.TabIndex = 53;
            // 
            // assetLocationCbx_ErrorLabel
            // 
            this.assetLocationCbx_ErrorLabel.AutoSize = true;
            this.assetLocationCbx_ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.assetLocationCbx_ErrorLabel.Location = new System.Drawing.Point(620, 557);
            this.assetLocationCbx_ErrorLabel.Name = "assetLocationCbx_ErrorLabel";
            this.assetLocationCbx_ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.assetLocationCbx_ErrorLabel.TabIndex = 54;
            // 
            // cleanFormBtn
            // 
            this.cleanFormBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cleanFormBtn.FlatAppearance.BorderSize = 0;
            this.cleanFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleanFormBtn.Image = global::ManejoDeActivos.Properties.Resources.LimpiarFormularioBtn;
            this.cleanFormBtn.Location = new System.Drawing.Point(618, 494);
            this.cleanFormBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cleanFormBtn.Name = "cleanFormBtn";
            this.cleanFormBtn.Size = new System.Drawing.Size(215, 44);
            this.cleanFormBtn.TabIndex = 55;
            this.cleanFormBtn.UseVisualStyleBackColor = true;
            this.cleanFormBtn.Click += new System.EventHandler(this.cleanFormBtn_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "No. Identificación";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
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
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // seriesDataGridViewTextBoxColumn
            // 
            this.seriesDataGridViewTextBoxColumn.DataPropertyName = "series";
            this.seriesDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.seriesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seriesDataGridViewTextBoxColumn.Name = "seriesDataGridViewTextBoxColumn";
            this.seriesDataGridViewTextBoxColumn.ReadOnly = true;
            this.seriesDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // AssetManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(909, 640);
            this.Controls.Add(this.cleanFormBtn);
            this.Controls.Add(this.assetLocationCbx_ErrorLabel);
            this.Controls.Add(this.assestStateCbx_ErrorLabel);
            this.Controls.Add(this.assestSerialNumberTxt_ErrorLabel);
            this.Controls.Add(this.assestModelTxt_ErrorLabel);
            this.Controls.Add(this.assestBrandTxt_ErrorLabel);
            this.Controls.Add(this.assestDescriptionTxt_ErrorLabel);
            this.Controls.Add(this.assestIdNumberTxt_ErrorLabel);
            this.Controls.Add(this.assestStateCbx);
            this.Controls.Add(this.assestModelTxt);
            this.Controls.Add(this.errorAssestLocationLbl);
            this.Controls.Add(this.errorAssestStateLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.errorAssestSerialNumLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.assestSerialNumberTxt);
            this.Controls.Add(this.outputAssestLbl);
            this.Controls.Add(this.errorAssestBrandLbl);
            this.Controls.Add(this.errorAssestDescriptionLbl);
            this.Controls.Add(this.removeAssetBtn);
            this.Controls.Add(this.editAssestBtn);
            this.Controls.Add(this.addAssestBtn);
            this.Controls.Add(this.errorAssestModelLbl);
            this.Controls.Add(this.assetsManagmentTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assestBrandTxt);
            this.Controls.Add(this.assestDescriptionTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AssetManagment";
            this.Text = "AssetManagment";
            this.Load += new System.EventHandler(this.AssetManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetsManagmentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._AssetsManagement_DbModelDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputAssestLbl;
        private System.Windows.Forms.Label errorAssestBrandLbl;
        private System.Windows.Forms.Label errorAssestDescriptionLbl;
        private System.Windows.Forms.Button removeAssetBtn;
        private System.Windows.Forms.Button editAssestBtn;
        private System.Windows.Forms.Button addAssestBtn;
        private System.Windows.Forms.Label errorAssestModelLbl;
        private System.Windows.Forms.DataGridView assetsManagmentTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox assestBrandTxt;
        private System.Windows.Forms.TextBox assestDescriptionTxt;
        private System.Windows.Forms.Label errorAssestSerialNumLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox assestSerialNumberTxt;
        private System.Windows.Forms.Label errorAssestStateLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label errorAssestLocationLbl;
        private System.Windows.Forms.TextBox assestModelTxt;
        private System.Windows.Forms.ComboBox assestStateCbx;
        private _AssetsManagement_DbModelDataSet1 _AssetsManagement_DbModelDataSet1;
        private System.Windows.Forms.BindingSource assetEntitiesBindingSource;
        private _AssetsManagement_DbModelDataSet1TableAdapters.AssetEntitiesTableAdapter assetEntitiesTableAdapter;
        private System.Windows.Forms.Label assestIdNumberTxt_ErrorLabel;
        private System.Windows.Forms.Label assestDescriptionTxt_ErrorLabel;
        private System.Windows.Forms.Label assestBrandTxt_ErrorLabel;
        private System.Windows.Forms.Label assestModelTxt_ErrorLabel;
        private System.Windows.Forms.Label assestSerialNumberTxt_ErrorLabel;
        private System.Windows.Forms.Label assestStateCbx_ErrorLabel;
        private System.Windows.Forms.Label assetLocationCbx_ErrorLabel;
        private System.Windows.Forms.Button cleanFormBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
    }
}