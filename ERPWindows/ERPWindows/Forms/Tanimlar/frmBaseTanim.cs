//using OrtakProje.Classes.Tanimlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtakProje.BaseForm
{
    public partial class frmBaseTanim : Form
    {
        #region Constructor
        public frmBaseTanim()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnClose_Click(object sender, EventArgs e) { this.Close(); }
        public virtual void btnSave_Click(object sender, EventArgs e) { }
        public virtual void frmBaseTanim_FormClosing(object sender, FormClosingEventArgs e) { }
        #endregion

        private void grdList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            foreach(DataRow r in grdList.Rows)
            {
                if (r["kod"].ToString() == grdList.Columns["kod"].ToString())
                    MessageBox.Show("hata");
            }
            if (e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Mükerrer Kayıt \nKayıt Otomatik Silindi", "KeyBilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
        }
    }
}
