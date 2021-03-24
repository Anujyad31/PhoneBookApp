using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace PhoneBookApp
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt= new DataTable();
        DataSet ds = new DataSet();


        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=USDLSCVDIXA0788\\SQLEXPRESS;Initial Catalog=PhoneBookDB;Integrated Security=True";
            con.Open();

            if (!Page.IsPostBack)
            {
                DataShow();

            }

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert into tblPhoneBook(Name,PhoneNum,Address)values('" +txtName.Text.ToString()+ "','" +txtPhoneNum.Text.ToString()+ "','" +txtAddress.Text.ToString()+ "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

        }
        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * From tblPhonebook";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update tblPhoneBook set PhoneNum= '" + txtPhoneNum.Text.ToString() + "',Address='" + txtAddress.Text.ToString() + "' where Name='"+txtName.Text.ToString()+"'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            
            DataShow();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Delete from tblPhoneBook where Name= '" + txtName.Text.ToString() + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }
    }
}