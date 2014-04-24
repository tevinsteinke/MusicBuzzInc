<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="modify-album.aspx.cs" Inherits="modify_album" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/Javascript">
        function alertDelete() {
            alert("Thanks! This album was successfully removed.");
        }
    </script>
    <script type="text/Javascript">
        function alertModify() {
            alert("Thanks! This album was successfully updated.");
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <header>
    <div class="page-header">
        <div class="row">
            <div class="small-12 columns">
                <h1>Modify Album</h1>
                <h4><span class="subhead">Update our vast music database.</span></h4>
            </div>
         </div>
    </div>
    </header>
    <div class="row"><div class="small-12 columns"><h3>Please update the fields below.</h3><hr /><br /></div></div>
     <div class="row">
        <div class="small-12 large-3 columns">
            <asp:Label ID="lblAlbumName" runat="server"
                 Text="Album name">
            </asp:Label><span class="required">*</span>
        </div>
        <div class="small-12 large-9 columns">
            <asp:TextBox ID="txtAlbumName" runat="server"
                ValidationGroup="requiredAlbum">
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="small-12 large-3 columns">
            <asp:Label ID="lblArtistName" runat="server" 
                Text="Artist name">
            </asp:Label>
            <span class="required">*</span>
        </div>
        <div class="small-12 large-9 columns">
            <asp:TextBox ID="txtArtistName" runat="server">
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="small-12 large-3 columns">
            <asp:Label ID="lblYear" runat="server" 
                Text="Release year">
            </asp:Label>
        </div>
        <div class="small-12 large-9 columns">
            <asp:TextBox ID="txtYear" runat="server">
            </asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="small-12 large-3 columns">
            <asp:Label ID="lblLabel" runat="server" 
                Text="Label">
            </asp:Label>
        </div>
        <div class="small-12 large-9 columns">
            <asp:TextBox ID="txtLabel" runat="server">
            </asp:TextBox>
        </div>
    </div>
    <%--<div class="row">
        <div class="small-12 large-3 columns">
            <asp:Label ID="lblImage" runat="server" 
                Text="Image">
            </asp:Label>
        </div>
        <div class="small-12 large-9 columns">
            <asp:FileUpload ID="fileImage" runat="server"></asp:FileUpload>
        </div>
    </div>--%>
    <div class="row">
        <div class="small-12 large-3 columns">
            <asp:Label ID="lblGenre" runat="server" 
                Text="Genre">
            </asp:Label>
        </div>
        <div class="small-12 large-9 columns">
            <asp:DropDownList ID="ddlGenre" runat="server">
                <asp:ListItem Value="unclassified">(Unclassified)</asp:ListItem>
                <asp:ListItem Value="rock">Rock</asp:ListItem>
                <asp:ListItem Value="hip-hop">Hip hop</asp:ListItem>
                <asp:ListItem Value="rb">R&B</asp:ListItem>
                <asp:ListItem Value="electronic">Electronic</asp:ListItem>
                <asp:ListItem Value="folk">Folk</asp:ListItem>
                <asp:ListItem Value="jazz">Jazz</asp:ListItem>
                <asp:ListItem Value="country">Country</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="row">
        <div class="small-12 columns">
            <asp:Button ID="BtnModify" 
                runat="server" 
                CssClass="button right" 
                Text="Modify" 
                OnClientClick="alertModify() " OnClick="BtnModify_Click"/>
        </div>
    </div>
    <div class="row">
        <div class="small-12 columns">
            <asp:Button ID="BtnDelete" 
                runat="server" 
                CssClass="button small alert" 
                Text="Delete album" 
                OnClick="BtnDelete_Click"
                OnClientClick="alertDelete()" />
        </div>
    </div>
</asp:Content>

