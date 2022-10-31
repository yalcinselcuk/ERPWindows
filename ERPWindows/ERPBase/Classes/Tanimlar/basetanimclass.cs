using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;

namespace ERPBase
{
    public abstract class basetanimclass
    {
        #region Objects
        public DataTable XdtMain = new DataTable();
        #endregion

        public abstract void LoadData();
        public abstract void SaveData();

        public bool Validate()
        {
            foreach (DataRow r in XdtMain.Select("", "", DataViewRowState.CurrentRows))
            {
                if (helper.GetString(r, "kod", "").Trim() == "")
                {
                    MessageBox.Show("Kod Boş Olamaz");
                    return false;
                }
                //if (r["kod"].ToString() == XdtMain.Columns["kod"].ToString())
                //{
                //    MessageBox.Show("Mükerrer Kayıt Girdiniz", "KEY BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return false;
                //}
            }
            return true;
        }
        protected virtual void XdtMain_RowChanged(object sender, DataRowChangeEventArgs e)
        {
        }
        
    }
}
