using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["ArtistName"] != null && Session["AlbumName"] != null)
            {
                lblAlbumName.Text = Session["AlbumName"].ToString();
                lblArtistName.Text = Session["ArtistName"].ToString();
                //lblAlbumName.Text += Application["AlbumName"].ToString();
            }
            /*
            HttpCookie cookie = Request.Cookies["cookieAlbum"];
            if (cookie != null)
            {
                lblAlbumName.Text = "Cookie: " + cookie.Value;
            }
            */
            /*lblAlbumName.Text = Request.QueryString["Car"];*/
        }
        catch (Exception exp)
        {
            lblAlbumName.Text = exp.Message;
        }
    }
}