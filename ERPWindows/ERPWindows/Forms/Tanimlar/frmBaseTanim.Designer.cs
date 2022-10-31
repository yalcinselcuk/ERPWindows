namespace OrtakProje.BaseForm
{
    partial class frmBaseTanim
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
            this.grdList = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelcenter = new System.Windows.Forms.Panel();
            this.panelbottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.panelcenter.SuspendLayout();
            this.panelbottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdList
            // 
            this.grdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdList.ColumnHeadersHeight = 29;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdList.Location = new System.Drawing.Point(0, 0);
            this.grdList.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grdList.MultiSelect = false;
            this.grdList.Name = "grdList";
            this.grdList.RowHeadersWidth = 51;
            this.grdList.Size = new System.Drawing.Size(607, 421);
            this.grdList.TabIndex = 0;
            this.grdList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdList_DataError);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(318, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(467, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelcenter
            // 
            this.panelcenter.AutoSize = true;
            this.panelcenter.Controls.Add(this.grdList);
            this.panelcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcenter.Location = new System.Drawing.Point(0, 0);
            this.panelcenter.Name = "panelcenter";
            this.panelcenter.Size = new System.Drawing.Size(607, 421);
            this.panelcenter.TabIndex = 1;
            // 
            // panelbottom
            // 
            this.panelbottom.Controls.Add(this.btnSave);
            this.panelbottom.Controls.Add(this.btnClose);
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(0, 369);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(607, 52);
            this.panelbottom.TabIndex = 2;
            // 
            // frmBaseTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 421);
            this.Controls.Add(this.panelbottom);
            this.Controls.Add(this.panelcenter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmBaseTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaseTanim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBaseTanim_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.panelcenter.ResumeLayout(false);
            this.panelbottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.DataGridView grdList;
        protected System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelcenter;
        private System.Windows.Forms.Panel panelbottom;
    }
}