using System.Windows.Forms;

namespace OrtakProje.Forms.StokHareket
{
    partial class frmStokHareketListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokHareketListesi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişFişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışFişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeyiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdstokharlistesi = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belgeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdstokharlistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.listeyiGüncelleToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(158, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişFişiToolStripMenuItem,
            this.çıkışFişiToolStripMenuItem});
            this.yeniKayıtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniKayıtToolStripMenuItem.Image")));
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            // 
            // girişFişiToolStripMenuItem
            // 
            this.girişFişiToolStripMenuItem.Name = "girişFişiToolStripMenuItem";
            this.girişFişiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.girişFişiToolStripMenuItem.Text = "Giriş Fişi";
            this.girişFişiToolStripMenuItem.Click += new System.EventHandler(this.girişFişiToolStripMenuItem_Click);
            // 
            // çıkışFişiToolStripMenuItem
            // 
            this.çıkışFişiToolStripMenuItem.Name = "çıkışFişiToolStripMenuItem";
            this.çıkışFişiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.çıkışFişiToolStripMenuItem.Text = "Çıkış Fişi";
            this.çıkışFişiToolStripMenuItem.Click += new System.EventHandler(this.çıkışFişiToolStripMenuItem_Click);
            // 
            // listeyiGüncelleToolStripMenuItem
            // 
            this.listeyiGüncelleToolStripMenuItem.Image = global::ERPWindows.Properties.Resources.reload;
            this.listeyiGüncelleToolStripMenuItem.Name = "listeyiGüncelleToolStripMenuItem";
            this.listeyiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.listeyiGüncelleToolStripMenuItem.Text = "Listeyi Güncelle";
            this.listeyiGüncelleToolStripMenuItem.Click += new System.EventHandler(this.listeyiGüncelleToolStripMenuItem_Click);
            // 
            // grdstokharlistesi
            // 
            this.grdstokharlistesi.AllowUserToAddRows = false;
            this.grdstokharlistesi.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.grdstokharlistesi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdstokharlistesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdstokharlistesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdstokharlistesi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdstokharlistesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdstokharlistesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdstokharlistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdstokharlistesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fisKodu,
            this.fisNo,
            this.fisTipi,
            this.tarih,
            this.belgeNo,
            this.aciklama,
            this.firmaId,
            this.firmaKod,
            this.depoId,
            this.depoKod});
            this.grdstokharlistesi.EnableHeadersVisualStyles = false;
            this.grdstokharlistesi.Location = new System.Drawing.Point(136, 0);
            this.grdstokharlistesi.Name = "grdstokharlistesi";
            this.grdstokharlistesi.RowHeadersWidth = 51;
            this.grdstokharlistesi.RowTemplate.Height = 24;
            this.grdstokharlistesi.Size = new System.Drawing.Size(854, 489);
            this.grdstokharlistesi.TabIndex = 1;
            this.grdstokharlistesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdstokharlistesi_CellDoubleClick);
            this.grdstokharlistesi.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdstokharlistesi_DataBindingComplete);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // fisKodu
            // 
            this.fisKodu.DataPropertyName = "Fiş Kodu";
            this.fisKodu.HeaderText = "Fiş Kodu";
            this.fisKodu.MinimumWidth = 6;
            this.fisKodu.Name = "fisKodu";
            this.fisKodu.Width = 112;
            // 
            // fisNo
            // 
            this.fisNo.DataPropertyName = "fisNo";
            this.fisNo.HeaderText = "Fiş No";
            this.fisNo.MinimumWidth = 6;
            this.fisNo.Name = "fisNo";
            this.fisNo.Width = 93;
            // 
            // fisTipi
            // 
            this.fisTipi.DataPropertyName = "fisTipi";
            this.fisTipi.HeaderText = "Fiş Tipi";
            this.fisTipi.MinimumWidth = 6;
            this.fisTipi.Name = "fisTipi";
            this.fisTipi.Visible = false;
            this.fisTipi.Width = 125;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.MinimumWidth = 6;
            this.tarih.Name = "tarih";
            this.tarih.Width = 81;
            // 
            // belgeNo
            // 
            this.belgeNo.DataPropertyName = "belgeNo";
            this.belgeNo.HeaderText = "Belge No";
            this.belgeNo.MinimumWidth = 6;
            this.belgeNo.Name = "belgeNo";
            this.belgeNo.Width = 115;
            // 
            // aciklama
            // 
            this.aciklama.DataPropertyName = "aciklama";
            this.aciklama.HeaderText = "Açıklama";
            this.aciklama.MinimumWidth = 6;
            this.aciklama.Name = "aciklama";
            this.aciklama.Width = 114;
            // 
            // firmaId
            // 
            this.firmaId.DataPropertyName = "firmaId";
            this.firmaId.HeaderText = "Firma Id";
            this.firmaId.MinimumWidth = 6;
            this.firmaId.Name = "firmaId";
            this.firmaId.Visible = false;
            this.firmaId.Width = 125;
            // 
            // firmaKod
            // 
            this.firmaKod.DataPropertyName = "firmaKod";
            this.firmaKod.HeaderText = "Firma Kodu";
            this.firmaKod.MinimumWidth = 6;
            this.firmaKod.Name = "firmaKod";
            this.firmaKod.Width = 134;
            // 
            // depoId
            // 
            this.depoId.DataPropertyName = "depoId";
            this.depoId.HeaderText = "Depo Id";
            this.depoId.MinimumWidth = 6;
            this.depoId.Name = "depoId";
            this.depoId.Visible = false;
            this.depoId.Width = 125;
            // 
            // depoKod
            // 
            this.depoKod.DataPropertyName = "depoKod";
            this.depoKod.HeaderText = "Depo Kodu";
            this.depoKod.MinimumWidth = 6;
            this.depoKod.Name = "depoKod";
            this.depoKod.Width = 130;
            // 
            // frmStokHareketListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(989, 489);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grdstokharlistesi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStokHareketListesi";
            this.Text = "Stok Hareket Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStokHareketListesi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdstokharlistesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeyiGüncelleToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdstokharlistesi;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişFişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışFişiToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiskodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisno;
        private System.Windows.Forms.DataGridViewTextBoxColumn fistipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmakod;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn depokod;
        private DataGridViewTextBoxColumn fisKodu;
        private DataGridViewTextBoxColumn fisNo;
        private DataGridViewTextBoxColumn fisTipi;
        private DataGridViewTextBoxColumn belgeNo;
        private DataGridViewTextBoxColumn firmaId;
        private DataGridViewTextBoxColumn firmaKod;
        private DataGridViewTextBoxColumn depoId;
        private DataGridViewTextBoxColumn depoKod;
    }
}