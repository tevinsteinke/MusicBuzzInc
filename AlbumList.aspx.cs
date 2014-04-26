using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

using MusicDataAccess;
using AlbumServiceProxy;

public partial class AlbumList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            AlbumDataAccess albumDA = new AlbumDataAccess();
            List<MusicDataAccess.Album> albums = albumDA.GetAll();
            //AlbumServiceProxy.AlbumServiceClient albums = new AlbumServiceProxy.AlbumServiceClient();
            //List<MusicDataAccess.Album> albumsList = new List<MusicDataAccess.Album>();
            //albumsList = albums.GetAll();

            //List<Album> a = albums.GetAll();
            Repeater1.DataSource = albums;
            Repeater1.DataBind();
        }
        
    }
}