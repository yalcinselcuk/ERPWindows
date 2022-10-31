
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
    public partial class frmFirmaTanim : BaseForm.frmBaseTanim
    {
        #region Objects
        firmatanimclass firmatanim;
        #endregion

        #region Constructor
        public frmFirmaTanim()
        {
            firmatanim = new firmatanimclass();

            grdList.DataSource = firmatanim.XdtMain;
            firmatanim.XdtMain.Columns.Add(new DataColumn("id", typeof(int)));
            firmatanim.XdtMain.Columns.Add(new DataColumn("kod", typeof(string)));
            firmatanim.XdtMain.Columns.Add(new DataColumn("aciklama", typeof(string)));
            firmatanim.LoadData();
            grdProperty();
            InitializeComponent();
        }
        #endregion


        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (firmatanim.Validate())
            {
                firmatanim.SaveData();
            }
        }
        public override void frmBaseTanim_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Değişikler Kaydedilsin mi?", "KeyBilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (firmatanim.Validate())
                {
                    firmatanim.SaveData();
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
