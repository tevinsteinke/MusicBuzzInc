using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using MusicDataAccess;

public partial class modify_album : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string albumId = Request.QueryString["id"];
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\temp\\MusicBuzzInc.mdf;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        string sqlStatement = "Select * from Album where AlbumId = {0}";
        sqlStatement = string.Format(sqlStatement, albumId);
        command.CommandText = sqlStatement;
        command.Connection = con;
        con.Open();
        SqlDataReader dr = command.ExecuteReader();
        while (dr.Read())
        {
            txtAlbumName.Text = dr["AlbumName"].ToString();
            txtArtistName.Text = dr["ArtistName"].ToString();
            txtLabel.Text = dr["Label"].ToString();
            ddlGenre.SelectedValue = dr["Genre"].ToString();
            txtYear.Text = dr["Year"].ToString();
        }
        con.Close();
    }
    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        string albumId = Request.QueryString["id"];
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\temp\\MusicBuzzInc.mdf;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        string sqlStatement = @"Delete from Album where AlbumId = {0}";
        sqlStatement = string.Format(sqlStatement,
                albumId);
        command.CommandText = sqlStatement;
        command.Connection = con;
        con.Open();
        command.ExecuteNonQuery();
        con.Close();
        Response.Redirect("AlbumList.aspx");
    }
    protected void BtnModify_Click(object sender, EventArgs e)
    {
        string albumId = Request.QueryString["id"];
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\temp\\MusicBuzzInc.mdf;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        string sqlStatement = @"Update Album set AlbumName='{0}', ArtistName='{1}', 
                                        Label='{2}', Genre='{3}', Year={4} where AlbumId = {5}";
        sqlStatement = string.Format(sqlStatement,
                txtAlbumName.Text,
                txtArtistName.Text,
                txtLabel.Text,
                ddlGenre.SelectedValue,
                txtYear.Text,
                albumId);
        command.CommandText = sqlStatement;
        command.Connection = con;
        con.Open();
        command.ExecuteNonQuery();
        con.Close();
        Response.Redirect("AlbumList.aspx");
    }
}