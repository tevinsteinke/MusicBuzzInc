    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using MusicDataAccess;

public partial class AlbumList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //AlbumDataAccess albumDA = new AlbumDataAccess();
            //List<MusicDataAccess.Album> albums = albumDA.GetAll();
            AlbumServiceProxy.AlbumServiceClient albums = new AlbumServiceProxy.AlbumServiceClient();
            Repeater1.DataSource = albums;
            Repeater1.DataBind();
            ////1. connect to the db
            //SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Tevin\\Desktop\\it431\\MusicBuzzInc\\App_Data\\MusicBuzzInc.mdf;Integrated Security=True");

            ////2. pass the SQL statements
            //SqlDataAdapter da = new SqlDataAdapter("Select * from album", con);

            ////3. get the data
            //DataSet ds = new DataSet();
            //da.Fill(ds,"Album");

            ////4. bind the data to the grid
            //GridView1.DataSource = ds;
            //GridView1.DataBind();
            
            ////1. connection object
            ////2. use command object
            //SqlCommand command = new SqlCommand("Select * from Album", con);
            ////3. get the data 
            //con.Open();
            //SqlDataReader dr = command.ExecuteReader();
            //while (dr.Read())
            //{
            //    ListItem list = new ListItem();
            //    list.Value = dr["AlbumId"].ToString();
            //    string displaytext = string.Format("{0} - {1}, {2}",
            //        dr["AlbumId"].ToString(),
            //        dr["AlbumName"].ToString(),
            //        dr["ArtistName"].ToString());

            //    list.Text = displaytext;
            //    DropDownList1.Items.Add(list);

            //}

            //con.Close();
        }
        
    }
}