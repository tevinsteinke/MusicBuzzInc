using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class add_album : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //List<Album> albums = new List<Album>();
        //for (int x = 0; x < 4; x++)
        //{
            //Album a = new Album();
            //a.name = String.Format("Name, {0}", x);
            //albums.Add(a);
        //}

        //Album a1 = new Album();
        //a1.name = txtAlbumName.Text;

        //albums.Add(a1);

        //hide the error unless it actually happens
        EmptyAlbumName.Attributes["style"] = "display: none";
        EmptyArtistName.Attributes["style"] = "display: none";
        FormSuccess.Attributes["style"] = "display: none";

        if (!IsPostBack)
        {
            //SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Tevin\\Desktop\\it431\\MusicBuzzInc\\App_Data\\MusicBuzzInc.mdf;Integrated Security=True");
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
            //    ddlAlbum.Items.Add(list);

            //}

            //con.Close();
        }
    }
    protected void FormSubmit(Object sender,
                           EventArgs e)
    {
        if (!requiredAlbum.IsValid)
        {
            EmptyAlbumName.Attributes["style"] = "display: block";
        }

        if (!requiredArtist.IsValid)
        {
            EmptyArtistName.Attributes["style"] = "display: block";
        }

        if (Page.IsValid)
        {
            FormSuccess.Attributes["style"] = "display: block";

            //add to db
            //FileStream FS = new FileStream(filepath, FileMode.Open, FileAccess.Read); //create a file stream object associate to user selected file 
            //byte[] img = new byte[FS.Length]; //create a byte array with size of user select file stream length
            //FS.Read(img, 0, Convert.ToInt32(FS.Length));//read user selected file stream in to byte array
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\temp\\MusicBuzzInc.mdf;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            string sqlStatement =
                @"Insert into Album(AlbumName, ArtistName, Label, Genre, Year)
                values('{0}', '{1}', '{2}', '{3}', {4})";
            sqlStatement = string.Format(sqlStatement,
                txtAlbumName.Text,
                txtArtistName.Text,
                txtLabel.Text,
                ddlGenre.SelectedValue,
                txtYear.Text);
            command.CommandText = sqlStatement;
            command.Connection = con;
            con.Open();
            command.ExecuteNonQuery();
            con.Close();


            //add album and artist names to the session
            Session["AlbumName"] = txtAlbumName.Text;
            Session["ArtistName"] = txtArtistName.Text;
            //Application["AlbumName"] = txtAlbumName.Text;
            HttpCookie cookieAlbum = new HttpCookie("AlbumName");
            cookieAlbum.Value = txtAlbumName.Text;
            cookieAlbum.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookieAlbum);
            Response.Redirect("album-success.aspx");

           

            
        }
    }
    //protected void ddlAlbum_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    string studentId = ddlAlbum.SelectedValue;
    //    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Tevin\\Desktop\\it431\\MusicBuzzInc\\App_Data\\MusicBuzzInc.mdf;Integrated Security=True");
    //    SqlCommand command = new SqlCommand();
    //    string sqlStatement = "Select * from Album where AlbumId = {0}";
    //    sqlStatement = string.Format(sqlStatement, studentId);
    //    command.CommandText = sqlStatement;
    //    command.Connection = con;
    //    con.Open();
    //    SqlDataReader dr = command.ExecuteReader();
    //    while (dr.Read())
    //    {
    //        txtAlbumName.Text = dr["AlbumName"].ToString();
    //        txtArtistName.Text = dr["ArtistName"].ToString();
    //        txtLabel.Text = dr["Label"].ToString();
    //        ddlGenre.SelectedValue = dr["Genre"].ToString();
    //        txtYear.Text = dr["Year"].ToString();
    //    }
    //    con.Close();
    //    // do the update functionality for this
    //}
//    protected void Button1_Click(object sender, EventArgs e)
//    {
//        string studentId = ddlAlbum.SelectedValue;
//        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Tevin\\Desktop\\it431\\MusicBuzzInc\\App_Data\\MusicBuzzInc.mdf;Integrated Security=True");
//        SqlCommand command = new SqlCommand();
//        string sqlStatement = @"Update Album set AlbumName='{0}', ArtistName='{1}', 
//                                Label='{2}', Genre='{3}', Year={4} where AlbumId = {5}";
//        sqlStatement = string.Format(sqlStatement,
//                txtAlbumName.Text,
//                txtArtistName.Text,
//                txtLabel.Text,
//                ddlGenre.SelectedValue,
//                txtYear.Text,
//                studentId);
//        command.CommandText = sqlStatement;
//        command.Connection = con;
//        con.Open();
//        command.ExecuteNonQuery();
//        con.Close();
//    }
    //protected void BtnDelete_Click(object sender, EventArgs e)
    //{
    //    string studentId = ddlAlbum.SelectedValue;
    //    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Tevin\\Desktop\\it431\\MusicBuzzInc\\App_Data\\MusicBuzzInc.mdf;Integrated Security=True");
    //    SqlCommand command = new SqlCommand();
    //    string sqlStatement = @"Delete from Album where AlbumId = {0}";
    //    sqlStatement = string.Format(sqlStatement,
    //            studentId);
    //    command.CommandText = sqlStatement;
    //    command.Connection = con;
    //    con.Open();
    //    command.ExecuteNonQuery();
    //    con.Close();
    //}
}
