﻿namespace OrtakProje.Forms.StokHareket
{
    partial class frmStokHar
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
            this.firmaLabel = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.sihirbaziac = new System.Windows.Forms.Button();
            this.firmaComboBox = new System.Windows.Forms.ComboBox();
            this.depoLabel = new System.Windows.Forms.Label();
            this.depoComboBox = new System.Windows.Forms.ComboBox();
            this.grdstokhardetail = new System.Windows.Forms.DataGridView();
            this.urunKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addrow = new System.Windows.Forms.Button();
            this.saveButtons = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.fisNoTextBox = new System.Windows.Forms.TextBox();
            this.belgeNoTextBox = new System.Windows.Forms.TextBox();
            this.fisNoLabel = new System.Windows.Forms.Label();
            this.tarihNoLabel = new System.Windows.Forms.Label();
            this.aciklamaTextBox = new System.Windows.Forms.RichTextBox();
            this.belgeNoLabel = new System.Windows.Forms.Label();
            this.tarihBox = new System.Windows.Forms.DateTimePicker();
            this.aciklamaLabel = new System.Windows.Forms.Label();
            this.tblFisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdstokhardetail)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firmaLabel
            // 
            this.firmaLabel.AutoSize = true;
            this.firmaLabel.Location = new System.Drawing.Point(21, 18);
            this.firmaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firmaLabel.Name = "firmaLabel";
            this.firmaLabel.Size = new System.Drawing.Size(69, 20);
            this.firmaLabel.TabIndex = 8;
            this.firmaLabel.Text = "Firma :";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Silver;
            this.panelRight.Controls.Add(this.sihirbaziac);
            this.panelRight.Controls.Add(this.firmaComboBox);
            this.panelRight.Controls.Add(this.firmaLabel);
            this.panelRight.Controls.Add(this.depoLabel);
            this.panelRight.Controls.Add(this.depoComboBox);
            this.panelRight.Location = new System.Drawing.Point(536, 4);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(400, 168);
            this.panelRight.TabIndex = 13;
            // 
            // sihirbaziac
            // 
            this.sihirbaziac.Location = new System.Drawing.Point(120, 92);
            this.sihirbaziac.Margin = new System.Windows.Forms.Padding(4);
            this.sihirbaziac.Name = "sihirbaziac";
            this.sihirbaziac.Size = new System.Drawing.Size(219, 35);
            this.sihirbaziac.TabIndex = 11;
            this.sihirbaziac.Text = "Sihirbazı Aç";
            this.sihirbaziac.UseVisualStyleBackColor = true;
            this.sihirbaziac.Visible = false;
            // 
            // firmaComboBox
            // 
            this.firmaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.firmaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.firmaComboBox.FormattingEnabled = true;
            this.firmaComboBox.Location = new System.Drawing.Point(121, 15);
            this.firmaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.firmaComboBox.Name = "firmaComboBox";
            this.firmaComboBox.Size = new System.Drawing.Size(223, 28);
            this.firmaComboBox.TabIndex = 10;
            // 
            // depoLabel
            // 
            this.depoLabel.AutoSize = true;
            this.depoLabel.Location = new System.Drawing.Point(20, 51);
            this.depoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depoLabel.Name = "depoLabel";
            this.depoLabel.Size = new System.Drawing.Size(65, 20);
            this.depoLabel.TabIndex = 9;
            this.depoLabel.Text = "Depo :";
            // 
            // depoComboBox
            // 
            this.depoComboBox.FormattingEnabled = true;
            this.depoComboBox.Location = new System.Drawing.Point(120, 48);
            this.depoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.depoComboBox.Name = "depoComboBox";
            this.depoComboBox.Size = new System.Drawing.Size(224, 28);
            this.depoComboBox.TabIndex = 4;
            // 
            // grdstokhardetail
            // 
            this.grdstokhardetail.AllowUserToAddRows = false;
            this.grdstokhardetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdstokhardetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdstokhardetail.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdstokhardetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdstokhardetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunKod,
            this.renkKod,
            this.birimKod,
            this.miktar,
            this.id,
            this.mainId,
            this.urunId,
            this.renkId,
            this.birimId});
            this.grdstokhardetail.Location = new System.Drawing.Point(0, 200);
            this.grdstokhardetail.Margin = new System.Windows.Forms.Padding(4);
            this.grdstokhardetail.MultiSelect = false;
            this.grdstokhardetail.Name = "grdstokhardetail";
            this.grdstokhardetail.ReadOnly = true;
            this.grdstokhardetail.RowHeadersWidth = 51;
            this.grdstokhardetail.RowTemplate.Height = 24;
            this.grdstokhardetail.Size = new System.Drawing.Size(939, 177);
            this.grdstokhardetail.TabIndex = 14;
            this.grdstokhardetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdstokhardetail_CellDoubleClick);
            // 
            // urunKod
            // 
            this.urunKod.DataPropertyName = "urunKod";
            this.urunKod.HeaderText = "Ürün";
            this.urunKod.MinimumWidth = 6;
            this.urunKod.Name = "urunKod";
            this.urunKod.ReadOnly = true;
            // 
            // renkKod
            // 
            this.renkKod.DataPropertyName = "renkKod";
            this.renkKod.HeaderText = "Renk";
            this.renkKod.MinimumWidth = 6;
            this.renkKod.Name = "renkKod";
            this.renkKod.ReadOnly = true;
            this.renkKod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.renkKod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // birimKod
            // 
            this.birimKod.DataPropertyName = "birimKod";
            this.birimKod.HeaderText = "Birim";
            this.birimKod.MinimumWidth = 6;
            this.birimKod.Name = "birimKod";
            this.birimKod.ReadOnly = true;
            this.birimKod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.birimKod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // miktar
            // 
            this.miktar.DataPropertyName = "miktar";
            this.miktar.HeaderText = "Miktar";
            this.miktar.MinimumWidth = 6;
            this.miktar.Name = "miktar";
            this.miktar.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // mainId
            // 
            this.mainId.DataPropertyName = "mainId";
            this.mainId.HeaderText = "MainId";
            this.mainId.MinimumWidth = 6;
            this.mainId.Name = "mainId";
            this.mainId.ReadOnly = true;
            this.mainId.Visible = false;
            // 
            // urunId
            // 
            this.urunId.DataPropertyName = "urunId";
            this.urunId.HeaderText = "UrunId";
            this.urunId.MinimumWidth = 6;
            this.urunId.Name = "urunId";
            this.urunId.ReadOnly = true;
            this.urunId.Visible = false;
            // 
            // renkId
            // 
            this.renkId.DataPropertyName = "renkId";
            this.renkId.HeaderText = "RenkId";
            this.renkId.MinimumWidth = 6;
            this.renkId.Name = "renkId";
            this.renkId.ReadOnly = true;
            this.renkId.Visible = false;
            // 
            // birimId
            // 
            this.birimId.DataPropertyName = "birimId";
            this.birimId.HeaderText = "BirimId";
            this.birimId.MinimumWidth = 6;
            this.birimId.Name = "birimId";
            this.birimId.ReadOnly = true;
            this.birimId.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.AutoSize = true;
            this.deleteButton.Location = new System.Drawing.Point(511, 384);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(204, 40);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(285, 384);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(213, 40);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Kapat";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addrow
            // 
            this.addrow.Location = new System.Drawing.Point(0, 180);
            this.addrow.Margin = new System.Windows.Forms.Padding(4);
            this.addrow.Name = "addrow";
            this.addrow.Size = new System.Drawing.Size(28, 22);
            this.addrow.TabIndex = 20;
            this.addrow.Text = "+";
            this.toolTip1.SetToolTip(this.addrow, "Satır Ekle");
            this.addrow.UseVisualStyleBackColor = true;
            this.addrow.Click += new System.EventHandler(this.addrow_Click);
            // 
            // saveButtons
            // 
            this.saveButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButtons.AutoSize = true;
            this.saveButtons.Location = new System.Drawing.Point(725, 384);
            this.saveButtons.Margin = new System.Windows.Forms.Padding(4);
            this.saveButtons.Name = "saveButtons";
            this.saveButtons.Size = new System.Drawing.Size(213, 40);
            this.saveButtons.TabIndex = 16;
            this.saveButtons.Text = "Kaydet";
            this.saveButtons.UseVisualStyleBackColor = true;
            this.saveButtons.Click += new System.EventHandler(this.saveButtons_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Silver;
            this.panelLeft.Controls.Add(this.fisNoTextBox);
            this.panelLeft.Controls.Add(this.belgeNoTextBox);
            this.panelLeft.Controls.Add(this.fisNoLabel);
            this.panelLeft.Controls.Add(this.tarihNoLabel);
            this.panelLeft.Controls.Add(this.aciklamaTextBox);
            this.panelLeft.Controls.Add(this.belgeNoLabel);
            this.panelLeft.Controls.Add(this.tarihBox);
            this.panelLeft.Controls.Add(this.aciklamaLabel);
            this.panelLeft.Location = new System.Drawing.Point(6, 5);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(522, 167);
            this.panelLeft.TabIndex = 19;
            // 
            // fisNoTextBox
            // 
            this.fisNoTextBox.Location = new System.Drawing.Point(157, 14);
            this.fisNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fisNoTextBox.Name = "fisNoTextBox";
            this.fisNoTextBox.ReadOnly = true;
            this.fisNoTextBox.Size = new System.Drawing.Size(355, 27);
            this.fisNoTextBox.TabIndex = 1;
            // 
            // belgeNoTextBox
            // 
            this.belgeNoTextBox.Location = new System.Drawing.Point(156, 76);
            this.belgeNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.belgeNoTextBox.Name = "belgeNoTextBox";
            this.belgeNoTextBox.Size = new System.Drawing.Size(354, 27);
            this.belgeNoTextBox.TabIndex = 4;
            // 
            // fisNoLabel
            // 
            this.fisNoLabel.AutoSize = true;
            this.fisNoLabel.Location = new System.Drawing.Point(33, 16);
            this.fisNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fisNoLabel.Name = "fisNoLabel";
            this.fisNoLabel.Size = new System.Drawing.Size(76, 20);
            this.fisNoLabel.TabIndex = 0;
            this.fisNoLabel.Text = "Fiş No :";
            // 
            // tarihNoLabel
            // 
            this.tarihNoLabel.AutoSize = true;
            this.tarihNoLabel.Location = new System.Drawing.Point(47, 49);
            this.tarihNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tarihNoLabel.Name = "tarihNoLabel";
            this.tarihNoLabel.Size = new System.Drawing.Size(64, 20);
            this.tarihNoLabel.TabIndex = 1;
            this.tarihNoLabel.Text = "Tarih :";
            // 
            // aciklamaTextBox
            // 
            this.aciklamaTextBox.Location = new System.Drawing.Point(156, 112);
            this.aciklamaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aciklamaTextBox.Multiline = false;
            this.aciklamaTextBox.Name = "aciklamaTextBox";
            this.aciklamaTextBox.Size = new System.Drawing.Size(354, 34);
            this.aciklamaTextBox.TabIndex = 5;
            this.aciklamaTextBox.Text = "";
            // 
            // belgeNoLabel
            // 
            this.belgeNoLabel.AutoSize = true;
            this.belgeNoLabel.Location = new System.Drawing.Point(13, 79);
            this.belgeNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.belgeNoLabel.Name = "belgeNoLabel";
            this.belgeNoLabel.Size = new System.Drawing.Size(98, 20);
            this.belgeNoLabel.TabIndex = 2;
            this.belgeNoLabel.Text = "Belge No :";
            // 
            // tarihBox
            // 
            this.tarihBox.CustomFormat = "dd//MM/yyyy";
            this.tarihBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tarihBox.Location = new System.Drawing.Point(156, 44);
            this.tarihBox.Margin = new System.Windows.Forms.Padding(4);
            this.tarihBox.Name = "tarihBox";
            this.tarihBox.Size = new System.Drawing.Size(126, 27);
            this.tarihBox.TabIndex = 1;
            this.tarihBox.Value = new System.DateTime(2022, 9, 28, 0, 0, 0, 0);
            // 
            // aciklamaLabel
            // 
            this.aciklamaLabel.AutoSize = true;
            this.aciklamaLabel.Location = new System.Drawing.Point(14, 115);
            this.aciklamaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aciklamaLabel.Name = "aciklamaLabel";
            this.aciklamaLabel.Size = new System.Drawing.Size(97, 20);
            this.aciklamaLabel.TabIndex = 3;
            this.aciklamaLabel.Text = "Açıklama :";
            // 
            // tblFisBindingSource
            // 
            this.tblFisBindingSource.DataMember = "Tbl_Fis";
            // 
            // frmStokHar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(944, 425);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.grdstokhardetail);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButtons);
            this.Controls.Add(this.addrow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStokHar";
            this.Text = "frmStokHar";
            this.Load += new System.EventHandler(this.frmStokHar_Load);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdstokhardetail)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firmaLabel;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button sihirbaziac;
        private System.Windows.Forms.ComboBox firmaComboBox;
        private System.Windows.Forms.Label depoLabel;
        private System.Windows.Forms.ComboBox depoComboBox;
        public System.Windows.Forms.DataGridView grdstokhardetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainId;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimId;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.BindingSource tblFisBindingSource;
        private System.Windows.Forms.Button saveButtons;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TextBox fisNoTextBox;
        private System.Windows.Forms.TextBox belgeNoTextBox;
        private System.Windows.Forms.Label fisNoLabel;
        private System.Windows.Forms.Label tarihNoLabel;
        private System.Windows.Forms.RichTextBox aciklamaTextBox;
        private System.Windows.Forms.Label belgeNoLabel;
        private System.Windows.Forms.DateTimePicker tarihBox;
        private System.Windows.Forms.Label aciklamaLabel;
        private System.Windows.Forms.Button addrow;
    }
}