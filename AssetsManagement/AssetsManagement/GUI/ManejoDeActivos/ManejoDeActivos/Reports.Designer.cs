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
            this.transfers_by_asset_report = new System.Windows.Forms.DataGridView();
            this.report1Label = new System.Windows.Forms.Label();
            this.report2_panel = new System.Windows.Forms.Panel();
            this.tranfers_by_user_report = new System.Windows.Forms.DataGridView();
            this.report2_label = new System.Windows.Forms.Label();
            this.report3_panel = new System.Windows.Forms.Panel();
            this.assets_by_state_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.state_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.assets_comboBox = new System.Windows.Forms.ComboBox();
            this.assets_by_state_btn = new System.Windows.Forms.Button();
            this.tranfers_by_user_btn = new System.Windows.Forms.Button();
            this.transfers_by_asset = new System.Windows.Forms.Button();
            this.report1_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transfers_by_asset_report)).BeginInit();
            this.report2_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tranfers_by_user_report)).BeginInit();
            this.report3_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assets_by_state_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // report1_panel
            // 
            this.report1_panel.BackColor = System.Drawing.Color.White;
            this.report1_panel.Controls.Add(this.transfers_by_asset);
            this.report1_panel.Controls.Add(this.assets_comboBox);
            this.report1_panel.Controls.Add(this.label4);
            this.report1_panel.Controls.Add(this.transfers_by_asset_report);
            this.report1_panel.Controls.Add(this.report1Label);
            this.report1_panel.Location = new System.Drawing.Point(12, 510);
            this.report1_panel.Name = "report1_panel";
            this.report1_panel.Size = new System.Drawing.Size(869, 465);
            this.report1_panel.TabIndex = 0;
            // 
            // transfers_by_asset_report
            // 
            this.transfers_by_asset_report.AllowUserToAddRows = false;
            this.transfers_by_asset_report.AllowUserToDeleteRows = false;
            this.transfers_by_asset_report.AllowUserToOrderColumns = true;
            this.transfers_by_asset_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transfers_by_asset_report.Location = new System.Drawing.Point(16, 66);
            this.transfers_by_asset_report.Name = "transfers_by_asset_report";
            this.transfers_by_asset_report.ReadOnly = true;
            this.transfers_by_asset_report.Size = new System.Drawing.Size(847, 384);
            this.transfers_by_asset_report.TabIndex = 1;
            this.transfers_by_asset_report.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assetsByLab_Grid_CellContentClick);
            // 
            // report1Label
            // 
            this.report1Label.AutoSize = true;
            this.report1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report1Label.Location = new System.Drawing.Point(11, 15);
            this.report1Label.Name = "report1Label";
            this.report1Label.Size = new System.Drawing.Size(532, 37);
            this.report1Label.TabIndex = 0;
            this.report1Label.Text = "Histórico de transferencia de activos";
            // 
            // report2_panel
            // 
            this.report2_panel.BackColor = System.Drawing.Color.White;
            this.report2_panel.Controls.Add(this.tranfers_by_user_btn);
            this.report2_panel.Controls.Add(this.label3);
            this.report2_panel.Controls.Add(this.user_comboBox);
            this.report2_panel.Controls.Add(this.tranfers_by_user_report);
            this.report2_panel.Controls.Add(this.report2_label);
            this.report2_panel.Location = new System.Drawing.Point(461, 12);
            this.report2_panel.Name = "report2_panel";
            this.report2_panel.Size = new System.Drawing.Size(420, 492);
            this.report2_panel.TabIndex = 2;
            // 
            // tranfers_by_user_report
            // 
            this.tranfers_by_user_report.AllowUserToAddRows = false;
            this.tranfers_by_user_report.AllowUserToDeleteRows = false;
            this.tranfers_by_user_report.AllowUserToOrderColumns = true;
            this.tranfers_by_user_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tranfers_by_user_report.Location = new System.Drawing.Point(5, 102);
            this.tranfers_by_user_report.Name = "tranfers_by_user_report";
            this.tranfers_by_user_report.ReadOnly = true;
            this.tranfers_by_user_report.Size = new System.Drawing.Size(411, 384);
            this.tranfers_by_user_report.TabIndex = 1;
            // 
            // report2_label
            // 
            this.report2_label.AutoSize = true;
            this.report2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report2_label.Location = new System.Drawing.Point(14, 14);
            this.report2_label.Name = "report2_label";
            this.report2_label.Size = new System.Drawing.Size(400, 37);
            this.report2_label.TabIndex = 0;
            this.report2_label.Text = "Transferencias por usuario";
            // 
            // report3_panel
            // 
            this.report3_panel.BackColor = System.Drawing.Color.White;
            this.report3_panel.Controls.Add(this.assets_by_state_btn);
            this.report3_panel.Controls.Add(this.label2);
            this.report3_panel.Controls.Add(this.state_ComboBox);
            this.report3_panel.Controls.Add(this.assets_by_state_grid);
            this.report3_panel.Controls.Add(this.label1);
            this.report3_panel.Location = new System.Drawing.Point(12, 12);
            this.report3_panel.Name = "report3_panel";
            this.report3_panel.Size = new System.Drawing.Size(443, 492);
            this.report3_panel.TabIndex = 2;
            // 
            // assets_by_state_grid
            // 
            this.assets_by_state_grid.AllowUserToAddRows = false;
            this.assets_by_state_grid.AllowUserToDeleteRows = false;
            this.assets_by_state_grid.AllowUserToOrderColumns = true;
            this.assets_by_state_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assets_by_state_grid.Location = new System.Drawing.Point(5, 102);
            this.assets_by_state_grid.Name = "assets_by_state_grid";
            this.assets_by_state_grid.ReadOnly = true;
            this.assets_by_state_grid.Size = new System.Drawing.Size(433, 384);
            this.assets_by_state_grid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activos por estado";
            // 
            // state_ComboBox
            // 
            this.state_ComboBox.FormattingEnabled = true;
            this.state_ComboBox.Items.AddRange(new object[] {
            "Bueno",
            "Regular",
            "Malo",
            "Reparación",
            "Otro"});
            this.state_ComboBox.Location = new System.Drawing.Point(5, 75);
            this.state_ComboBox.Name = "state_ComboBox";
            this.state_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.state_ComboBox.TabIndex = 2;
            this.state_ComboBox.SelectedIndexChanged += new System.EventHandler(this.state_ComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado";
            // 
            // user_comboBox
            // 
            this.user_comboBox.FormattingEnabled = true;
            this.user_comboBox.Location = new System.Drawing.Point(5, 73);
            this.user_comboBox.Name = "user_comboBox";
            this.user_comboBox.Size = new System.Drawing.Size(121, 21);
            this.user_comboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(656, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Activo";
            // 
            // assets_comboBox
            // 
            this.assets_comboBox.FormattingEnabled = true;
            this.assets_comboBox.Location = new System.Drawing.Point(656, 39);
            this.assets_comboBox.Name = "assets_comboBox";
            this.assets_comboBox.Size = new System.Drawing.Size(121, 21);
            this.assets_comboBox.TabIndex = 4;
            // 
            // assets_by_state_btn
            // 
            this.assets_by_state_btn.Location = new System.Drawing.Point(363, 73);
            this.assets_by_state_btn.Name = "assets_by_state_btn";
            this.assets_by_state_btn.Size = new System.Drawing.Size(75, 23);
            this.assets_by_state_btn.TabIndex = 4;
            this.assets_by_state_btn.Text = "Filtrar";
            this.assets_by_state_btn.UseVisualStyleBackColor = true;
            this.assets_by_state_btn.Click += new System.EventHandler(this.assets_by_state_btn_Click);
            // 
            // tranfers_by_user_btn
            // 
            this.tranfers_by_user_btn.Location = new System.Drawing.Point(341, 74);
            this.tranfers_by_user_btn.Name = "tranfers_by_user_btn";
            this.tranfers_by_user_btn.Size = new System.Drawing.Size(75, 23);
            this.tranfers_by_user_btn.TabIndex = 5;
            this.tranfers_by_user_btn.Text = "Filtrar";
            this.tranfers_by_user_btn.UseVisualStyleBackColor = true;
            this.tranfers_by_user_btn.Click += new System.EventHandler(this.tranfers_by_user_btn_Click);
            // 
            // transfers_by_asset
            // 
            this.transfers_by_asset.Location = new System.Drawing.Point(789, 38);
            this.transfers_by_asset.Name = "transfers_by_asset";
            this.transfers_by_asset.Size = new System.Drawing.Size(75, 23);
            this.transfers_by_asset.TabIndex = 5;
            this.transfers_by_asset.Text = "Filtrar";
            this.transfers_by_asset.UseVisualStyleBackColor = true;
            this.transfers_by_asset.Click += new System.EventHandler(this.transfers_by_asset_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(164)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(909, 640);
            this.Controls.Add(this.report3_panel);
            this.Controls.Add(this.report2_panel);
            this.Controls.Add(this.report1_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.report1_panel.ResumeLayout(false);
            this.report1_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transfers_by_asset_report)).EndInit();
            this.report2_panel.ResumeLayout(false);
            this.report2_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tranfers_by_user_report)).EndInit();
            this.report3_panel.ResumeLayout(false);
            this.report3_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assets_by_state_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel report1_panel;
        private System.Windows.Forms.Label report1Label;
        private System.Windows.Forms.DataGridView transfers_by_asset_report;
        private System.Windows.Forms.Panel report2_panel;
        private System.Windows.Forms.DataGridView tranfers_by_user_report;
        private System.Windows.Forms.Label report2_label;
        private System.Windows.Forms.Panel report3_panel;
        private System.Windows.Forms.DataGridView assets_by_state_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox assets_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox user_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox state_ComboBox;
        private System.Windows.Forms.Button transfers_by_asset;
        private System.Windows.Forms.Button tranfers_by_user_btn;
        private System.Windows.Forms.Button assets_by_state_btn;
    }
}