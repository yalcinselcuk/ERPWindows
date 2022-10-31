using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;

namespace ERPBase
{
    public class firmatanimclass : basetanimclass
    {
        SqlConnection con = null;
        myDataAdapter da = null;

        public override void LoadData()
        {

            XdtMain.RowChanged += XdtMain_RowChanged;

            con = new SqlConnection("Data Source=LAPTOP-8HOREQD2;Initial Catalog=textileproject;Integrated Security=True");
            con.Open();
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = con;
            cmm.CommandText = "select a.id, a.kod, a.aciklama from firmatanim a ";
            da = new myDataAdapter();
            da.SelectCommand = cmm;
            da.Fill(XdtMain);
            da.CreateCommand();

            con.Close();
        }
        protected override void XdtMain_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Add)
            {
                if (e.Row["id"] == DBNull.Value || e.Row["id"] == null)
                    e.Row["id"] = helper.GetId("firmatanim");

            }

        }
        public override void SaveData()
        {

            con.Open();
            SqlTransaction trans = con.BeginTransaction();
            try
            {
                da.Update(XdtMain, trans);
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
