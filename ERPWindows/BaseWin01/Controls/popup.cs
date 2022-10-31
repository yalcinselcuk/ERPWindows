using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaseWin01
{
    public delegate void AfterRowSelectEventHandler(object sender, string selectedvalue, string selectedid);


    public partial class popup : Form
    {
        #region Objects
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-8HOREQD2;Initial Catalog=textileproject;Integrated Security=True");

        SqlDataAdapter adtr;
        /*public */DataTable tbldata;
        public event AfterRowSelectEventHandler AfterRowSelectEvent;
        string comboboxname;
        #endregion

        #region Constructors
        public popup()
        {
            InitializeComponent();
        }
        public popup(string comboboxname)
        {
            InitializeComponent();
            this.comboboxname = comboboxname;
        }
        #endregion

        #region Events
        private void popup_Load(object sender, EventArgs e)
        {
            if(comboboxname == "uruncombobox")
            {
                filldatagrid("stoktanim");
            }
            if (comboboxname == "renkcombobox")
            {
                filldatagrid("renktanim");
            }
            if (comboboxname == "birimcombobox")
            {
                filldatagrid("birimtanim");
            }

            dataGridView1.DataSource = tbldata;
           
            //AfterRowSelectEvent(this, tbldata);
        }
        private void popup_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            AfterRowSelectEvent(this, dataGridView1.CurrentCell.Value.ToString(), dataGridView1[e.ColumnIndex - 1, e.RowIndex].Value.ToString());
            this.Close();
        }
        #endregion
        #region Public Methods

        public void filldatagrid(string tablename)
        {
            tbldata = new DataTable();
            adtr = new SqlDataAdapter("SELECT id, kod, aciklama FROM " + tablename, conn);
            conn.Open();
            adtr.Fill(tbldata);
           
            conn.Close();
            
        }
       
        #endregion

    }
}

