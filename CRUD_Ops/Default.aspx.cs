using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Ops
{
    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-LTLSG7NR;Initial Catalog=CrudOpsDB;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("INSERT INTO StudentInfo_Tab1 values('"+int.Parse(Student_ID.Text)+"','"+Student_Name.Text+"', '"+Student_Address.SelectedValue+"', '"+double.Parse(Student_Age.Text)+"','"+Student_Contact.Text+"')", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            LoadRecord();
            ClearFields();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void LoadRecord()
        {
            SqlCommand comm = new SqlCommand("SELECT * FROM StudentInfo_Tab1", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("UPDATE StudentInfo_Tab1 SET StudentName = '"+Student_Name.Text+"', Address = '"+Student_Address.SelectedValue+"', Age = '"+double.Parse(Student_Age.Text)+"', Contact = '" +Student_Contact.Text + "' WHERE StudentID = '" + int.Parse(Student_ID.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            LoadRecord();
            ClearFields();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("DELETE StudentInfo_Tab1 WHERE StudentID = '" + int.Parse(Student_ID.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
            LoadRecord();
            ClearFields();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("SELECT * FROM StudentInfo_Tab1 WHERE StudentID = '" + int.Parse(Student_ID.Text) + "'", con);;
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            ClearFields();
        }

        private void ClearFields()
        {
            Student_ID.Text = string.Empty;
            Student_Name.Text = string.Empty;
            Student_Address.ClearSelection(); 
            Student_Age.Text = string.Empty;
            Student_Contact.Text = string.Empty;
        }
    }
}