
using ERPBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtakProje.Forms
{
    public partial class frmDepoTanim : BaseForm.frmBaseTanim
    {


        #region Objects
        depotanimclass depotanim;
        #endregion

        #region Constructor
        public frmDepoTanim()
        {
            depotanim = new depotanimclass();

            grdList.DataSource = depotanim.XdtMain;
            depotanim.XdtMain.Columns.Add(new DataColumn("id", typeof(int)));
            depotanim.XdtMain.Columns.Add(new DataColumn("kod", typeof(string)));
            depotanim.XdtMain.Columns.Add(new DataColumn("aciklama", typeof(string)));
            depotanim.LoadData();
            grdProperty();
            InitializeComponent();
        }
        #endregion


        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (depotanim.Validate())
            {
                depotanim.SaveData();
            }
        }
        public override void frmBaseTanim_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Değişikler Kaydedilsin mi?", "KeyBilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (depotanim.Validate())
                {
                    depotanim.SaveData();
                }
            }
        }
        void grdProperty()
        {
            grdList.Columns[0].HeaderText = "ID";
            grdList.Columns[0].Visible = false;
            grdList.Columns[1].HeaderText = "KOD";
            grdList.Columns[2].HeaderText = "AÇIKLAMA";
        }

    }
}
