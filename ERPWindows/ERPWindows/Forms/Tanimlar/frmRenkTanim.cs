
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
    public partial class frmRenkTanim : BaseForm.frmBaseTanim
    {
        #region Objects
        renktanimclass renktanim;
        #endregion

        #region Constructor
        public frmRenkTanim()
        {
            renktanim = new renktanimclass();

            grdList.DataSource = renktanim.XdtMain;
            renktanim.XdtMain.Columns.Add(new DataColumn("id", typeof(int)));
            renktanim.XdtMain.Columns.Add(new DataColumn("kod", typeof(string)));
            renktanim.XdtMain.Columns.Add(new DataColumn("aciklama", typeof(string)));
            renktanim.LoadData();
            grdProperty();
            InitializeComponent();
        }
        #endregion


        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (renktanim.Validate())
            {
                renktanim.SaveData();
            }
        }
        public override void frmBaseTanim_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Değişikler Kaydedilsin mi?", "KeyBilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (renktanim.Validate())
                {
                    renktanim.SaveData();
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
