
using BaseWin01.DataSets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPBase
{
    public class stokHareketClass
    {
        #region Variables
        SqlDataAdapter adtrdetail = null;
        SqlDataAdapter adtrmain = null;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-8HOREQD2;Initial Catalog=textileproject;Integrated Security=True");
        SqlCommandBuilder commandBuilder;
        dsStokHar ds = null;
        

        #region Property
        public dsStokHar DS { get { return ds; } }
        public int _MainId
        {
            get { return mainid; }
        }
        #endregion

        #region Constructor
        public stokHareketClass()
        {
            this.ds = new dsStokHar();
        }
        public stokHareketClass(dsStokHar ds)
        {
            this.ds = ds;
        }
        #endregion



        int mainid;
        public static int fistype;
        #endregion



        public void Init()
        {

        }
        public Result LoadData(int fisref)
        {
            mainid = fisref;

            GetMainValues(mainid);
            GetDetailsValues(mainid);
            if (mainid < 0)
            {
                CreateNew();
                return new Result { resultbool = true, resultmessage = "" };
            }
            return new Result { resultbool = true, resultmessage = "" };
        }


        public void GetMainValues(int fisref)
        {

            try
            {
                adtrmain = new SqlDataAdapter("SELECT a.id, a.fisno, a.fistipi, a.tarih, a.belgeno, a.aciklama, " +
                                              "a.firmaid, a.depoid, firmakod = b.kod, depokod = c.kod FROM stokharmain a " +
                                              "LEFT OUTER JOIN firmatanim b ON b.id = a.firmaid " +
                                              "LEFT OUTER JOIN depotanim c ON c.id = a.depoid " +
                                              "WHERE a.id = " + fisref, conn);

                conn.Open();

                adtrmain.Fill(ds.stokharmain);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.Close();
        }

        public void GetDetailsValues(int fisref)
        {

            try
            {
                adtrdetail = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("SELECT a.id, a.mainid, a.urunid, a.renkid, a.birimid, urunkod = b.kod, renkkod = d.kod, birimkod = c.kod, a.miktar FROM stokhardetail a " +
                                                "LEFT OUTER JOIN stoktanim b on b.id = a.urunid " +
                                                "LEFT OUTER JOIN birimtanim c on c.id = a.birimid " +
                                                "LEFT OUTER JOIN renktanim d on d.id = a.renkid " +
                                                "WHERE a.mainid =  " + fisref, conn);
                conn.Open();
                adtrdetail.SelectCommand = cmd;
                adtrdetail.Fill(ds.stokhardetail);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }



        public Result Validate()
        {
            string tarihsecilen = DS.stokharmain.Rows[0]["tarih"].ToString();
            string şimdikitarih = DateTime.Now.ToString();
            int tarihsonuc = tarihsecilen.CompareTo(şimdikitarih);

            if (DS.stokharmain.Rows[0]["firmakod"].ToString() == "")
            {
                return new Result { resultbool = false, resultmessage = "Firma Seçilmedi" };
            }
            if (DS.stokharmain.Rows[0]["depokod"].ToString() == "")
            {
                return new Result { resultbool = false, resultmessage = "Depo Seçilmedi" };

            }
            if (DS.stokharmain.Rows[0]["belgeno"].ToString() == "")
            {
                this.ds.stokharmain[0]["belgeno"] = DS.stokharmain.Rows[0]["fisno"];// row["fisNo"];

            }
            return new Result { resultbool = true, resultmessage = "" };
        }
        public Result ValidateDelete()
        {
            return new Result { resultbool = true, resultmessage = "" };
        }


        public Result Save()
        {
            SqlTransaction transaction = null;

            try
            {
                conn.Open();
                adtrmain = new SqlDataAdapter();
                transaction = conn.BeginTransaction();


                cmd = new SqlCommand("select id, fisno, fistipi,  tarih, belgeno, aciklama, firmaid, depoid from stokharmain", conn);
                cmd.Transaction = transaction;
                adtrmain.SelectCommand = cmd;

                commandBuilder = new SqlCommandBuilder(adtrmain);

                DS.stokharmain[0].EndEdit();


                adtrmain.InsertCommand = commandBuilder.GetInsertCommand(true);
                adtrmain.DeleteCommand = commandBuilder.GetDeleteCommand(true);
                adtrmain.UpdateCommand = commandBuilder.GetUpdateCommand(true);

                adtrmain.Update(DS.stokharmain);


                cmd = new SqlCommand("select id, mainid, urunid, renkid, birimid, miktar from stokhardetail", conn);
                adtrdetail = new SqlDataAdapter();
                cmd.Transaction = transaction;
                adtrdetail.SelectCommand = cmd;

                commandBuilder = new SqlCommandBuilder(adtrdetail);

                adtrdetail.InsertCommand = commandBuilder.GetInsertCommand(true);
                adtrdetail.DeleteCommand = commandBuilder.GetDeleteCommand(true);
                adtrdetail.UpdateCommand = commandBuilder.GetUpdateCommand(true);

                adtrdetail.Update(DS.stokhardetail);

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                return new Result { resultbool = false, resultmessage = ex.ToString() };

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            //}
            return new Result { resultbool = true, resultmessage = "" };
        }

        public Result Delete()
        {
            if (fistype == 1)
            {
                ds.stokharmain.Rows[0].Delete();
                Save();
            }
            return new Result { resultbool = true, resultmessage = "" };
        }
        public void CreateNew()
        {
            mainid = helper.GetId("stokharmain");

            DataRow rnew = this.ds.stokharmain.NewRow();
            rnew["id"] = mainid;
            rnew["fisno"] = (mainid).ToString("000000");
            rnew["tarih"] = DateTime.Now;
            rnew["fistipi"] = fistype;
            this.ds.stokharmain.Rows.Add(rnew);

        }

        public void AddDetailsRow(StokHarDetailInfo stokHarDetailInfo)
        {

            DataRow r = this.DS.stokhardetail.NewRow();
            r["id"] = helper.GetId("stokhardetail");
            r["mainid"] = mainid;
            r["urunid"] = stokHarDetailInfo.urunid;
            r["urunkod"] = stokHarDetailInfo.urunkod;
            r["renkid"] = stokHarDetailInfo.renkid;
            r["renkkod"] = stokHarDetailInfo.renkkod;
            r["birimid"] = stokHarDetailInfo.birimid;
            r["birimkod"] = stokHarDetailInfo.birimkod;
            r["miktar"] = stokHarDetailInfo.miktar;
            this.DS.stokhardetail.Rows.Add(r);

        }
    }
    public class StokHarDetailInfo
    {
        #region Property
        public int id { get; set; }
        public int mainid { get; set; }
        public int urunid { get; set; }
        public int renkid { get; set; }
        public int birimid { get; set; }
        public decimal miktar { get; set; }
        public string urunkod { get; set; }
        public string renkkod { get; set; }
        public string birimkod { get; set; }
        #endregion
    }

    public class Result
    {
        public bool resultbool { get; set; }
        public string resultmessage { get; set; }
    }
}

