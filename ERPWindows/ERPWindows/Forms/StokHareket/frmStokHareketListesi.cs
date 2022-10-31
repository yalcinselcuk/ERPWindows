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

namespace OrtakProje.Forms.StokHareket
{
    public partial class frmStokHareketListesi : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-8HOREQD2;Initial Catalog=textileproject;Integrated Security=True");
        SqlDataAdapter adtr;
        DataTable tbl = new DataTable();
        stokHareketClass stokHarClass = new stokHareketClass();


        public frmStokHareketListesi()
        {
            InitializeComponent();
        }

        private void frmStokHareketListesi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            tbl.Clear();

            adtr = new SqlDataAdapter("SELECT a.id, a.fisno, a.fistipi, a.tarih, " +
                                     "a.belgeno, a.aciklama, a.firmaid, firmakod = b.kod, a.depoid, depokod = c.kod," +
                                        "CASE a.fistipi" +
                                        "      WHEN '1' THEN 'Giriş Fişi'" +
                                        "      WHEN '0' THEN 'Çıkış Fişi' " +
                                        "END AS 'Fiş Kodu'" +
                                     "FROM stokharmain a " +
                                     "LEFT OUTER JOIN firmatanim b on b.id = a.firmaid " +
                                     "LEFT OUTER JOIN depotanim c on c.id = a.depoid", conn);

            adtr.Fill(tbl);

            grdstokharlistesi.DataSource = tbl;
            grdstokharlistesi.Columns["tarih"].DefaultCellStyle.Format = "dd/MM/yyyy";
            grdstokharlistesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void girişFişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokHareketClass.fistype = 1;
            frmStokHar frmStokHar = new frmStokHar();
            frmStokHar.MdiParent = this.MdiParent;
            frmStokHar.Text = "Giriş Fişi";
            frmStokHar.Show();
        }

        private void çıkışFişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokHareketClass.fistype = 0;
            frmStokHar frmStokHar = new frmStokHar();
            frmStokHar.MdiParent = this.MdiParent;
            frmStokHar.Text = "Çıkış Fişi";
            frmStokHar.Show();
        }

        private void listeyiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void grdstokharlistesi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdstokharlistesi.ClearSelection();
        }

        private void grdstokharlistesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmStokHar frmStokHar = new frmStokHar(Convert.ToInt32(grdstokharlistesi.CurrentRow.Cells[0].Value));
            stokHareketClass.fistype = 1;
            frmStokHar.MdiParent = this.MdiParent;

            frmStokHar.Show();
        }
    }
}
