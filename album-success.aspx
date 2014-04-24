<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="album-success.aspx.cs" Inherits="page1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <header>
    <div class="page-header">
        <div class="row">
            <div class="small-12 columns">
                <h1>Success</h1>
                <h4><span class="subhead">Your album has been added.</span></h4>
            </div>
         </div>
    </div>
    </header>
    
    <div class="row">
        <div class="small-12 columns">
            <h3>Thanks for expanding our database!</h3>
            <p>The following album has been added: <strong><asp:Label ID="lblAlbumName" runat="server" Text="Label"></asp:Label></strong> by <strong><asp:Label ID="lblArtistName" runat="server" Text="Label"></asp:Label></strong>. Our database is rapidly expanding and it is all thanks to your contribution. To view our elaborate album database in full, please view below.</p>
            <p><a href="albumlist.aspx" class="button">View all albums</a><br /></p>
            <p>If you'd like to add another album, we would greatly appreciate it. Follow the link below to get started.</p>
            <p><a href="add-album.aspx" class="button">Add another album</a></p>
        </div>
    </div>
</asp:Content>

