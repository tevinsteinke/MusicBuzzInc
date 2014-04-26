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
        if (!IsPostBack)
        {
            AlbumDataAccess albumDA = new AlbumDataAccess();
            MusicDataAccess.Album cur = albumDA.FindAlbum(int.Parse(Request.QueryString["id"]));

            //fill in the fields, only if they aren't null
            if (cur.AlbumName != null) { txtAlbumName.Text = cur.AlbumName.ToString(); }
            if (cur.ArtistName != null) { txtArtistName.Text = cur.ArtistName.ToString(); }
            if (cur.Label != null) { txtLabel.Text = cur.Label.ToString(); }
            if (cur.Genre != null) { ddlGenre.SelectedValue = cur.Genre.ToString(); }
            if (cur.Year != null) { txtYear.Text = cur.Year.ToString(); }
            if (cur.Artwork != null) { txtArtwork.Text = cur.Artwork.ToString(); }
        }
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        AlbumDataAccess delete = new AlbumDataAccess();
        delete.Delete(int.Parse(Request.QueryString["id"]));
        Response.Redirect("AlbumList.aspx");
    }

    protected void BtnModify_Click(object sender, EventArgs e)
    {
        MusicDataAccess.Album updated = new MusicDataAccess.Album();
        updated.AlbumId = int.Parse(Request.QueryString["id"]);
        updated.AlbumName = txtAlbumName.Text;
        updated.ArtistName = txtArtistName.Text;
        updated.Label = txtLabel.Text;
        updated.Genre = ddlGenre.SelectedValue;
        updated.Year = Convert.ToInt16(txtYear.Text);
        updated.Artwork = txtArtwork.Text;

        AlbumDataAccess modify = new AlbumDataAccess();
        
        modify.Modify(updated);
        Response.Redirect("AlbumList.aspx");
    }
}