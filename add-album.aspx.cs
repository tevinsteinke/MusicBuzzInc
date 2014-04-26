using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

using MusicDataAccess;

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
            //do stuff
        }
    }
    protected void FormSubmit(Object sender,
                           EventArgs e)
    {
        if (!requiredAlbum.IsValid) { EmptyAlbumName.Attributes["style"] = "display: block"; }

        if (!requiredArtist.IsValid) { EmptyArtistName.Attributes["style"] = "display: block"; }

        if (Page.IsValid)
        {
            FormSuccess.Attributes["style"] = "display: block";

            //add to DB
            MusicDataAccess.Album newAlbum = new MusicDataAccess.Album();
            newAlbum.AlbumName = txtAlbumName.Text;
            newAlbum.ArtistName = txtArtistName.Text;
            newAlbum.Label = txtLabel.Text;
            newAlbum.Genre = ddlGenre.SelectedValue;
            newAlbum.Year = Convert.ToInt16(txtYear.Text);
            //newAlbum.Image = 

            AlbumDataAccess add = new AlbumDataAccess();

            add.Add(newAlbum);

            //add album and artist names to the session
            Session["AlbumName"] = txtAlbumName.Text;
            Session["ArtistName"] = txtArtistName.Text;
            Response.Redirect("album-success.aspx");
        }
    }
}
