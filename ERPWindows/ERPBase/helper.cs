using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPBase
{
    public static class helper
    {
        public static int GetId(string tablename)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-8HOREQD2;Initial Catalog=textileproject;Integrated Security=True");

            SqlCommand cmm = new SqlCommand();


            con.Open();
            cmm.Connection = con;
            cmm.CommandText = "select id from referances where tablename= @tablename";
            cmm.Parameters.Add("@tablename", SqlDbType.VarChar).Value = tablename;
            cmm.Connection = con;

            var id = cmm.ExecuteScalar();
            if (id == null) id = -1;

            int prcref = Convert.ToInt32(id);

            if (prcref == -1)
            {
                prcref = 1;
                cmm.CommandText = "insert into referances(id, tablename) values(@id, @tablename)";
                cmm.Parameters.Add("@id", SqlDbType.Int, 20).Value = prcref;
                //cmm.Parameters.Add("@tablename", SqlDbType.NVarChar, 200).Value = tablename;


            }
            else
            {
                prcref += 1;
                cmm.CommandText = "update referances set id=@id where tablename = @tablename ";
                //cmm.Parameters.Add("@tablename", SqlDbType.NVarChar, 200).Value = tablename;
                cmm.Parameters.Add("@id", SqlDbType.Int, 20).Value = prcref;


            }

            cmm.ExecuteNonQuery();
            con.Close();
            return prcref;
        }

        public static void DataAdapterSetTransaction(SqlDataAdapter da, SqlTransaction trans)
        {
            da.UpdateCommand.Transaction = trans;
            da.DeleteCommand.Transaction = trans;
            da.InsertCommand.Transaction = trans;
        }

        //gönderilen degiskenin ya da satırın null olup olmadığı kontrol edilir
        //eğer ki satır boşsa boş değer döndürülür
        //değilse olan değer döndürülür
        public static string GetString(object o, string defaultval)
        {
            if (o == null | o == DBNull.Value) return defaultval;

            return o.ToString();
        }
        public static string GetString(DataRow r, string colname, string defaultval)
        {
            if (r[colname] == null | r[colname] == DBNull.Value) return defaultval;

            return GetString(r[colname], defaultval);
        }

    }
}
