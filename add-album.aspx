<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="add-album.aspx.cs" Inherits="add_album" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <header>
    <div class="page-header">
        <div class="row">
            <div class="small-12 columns">
                <h1>Add an album</h1>
                <h4><span class="subhead">Expand our database with your own knowledge.</span></h4>
            </div>
         </div>
    </div>
    </header>
    <div class="row"><div class="small-12 columns"><h3>Please fill out the fields below.</h3><hr /><br /></div></div>
    <div class="row">
        <div class="small-12 columns">
            <div data-alert class="alert-box success" id="FormSuccess" runat="server">
                Thank you for submitting your form! Your album has been added.
                <a href="#" class="close">&times;</a>
            </div>
        </div>
    </div><!--/row2-->
    <div class="row">
        <div class="small-12 columns">
            <div data-alert class="alert-box warning" id="EmptyAlbumName" runat="server">
                    <asp:RequiredFieldValidator ID="requiredAlbum" runat="server" 
                        ControlToValidate="txtAlbumName" 
                        ErrorMessage="ERROR: Please enter an album name."
                        EnableClientScript="False">
                    </asp:RequiredFieldValidator>
                <a href="#" class="close">&times;</a>
            </div>
        </div>
    </div><!--/row2-->
    <div class="row">
        <div class="small-12 columns">
            <div data-alert class="alert-box warning" id="EmptyArtistName" runat="server">
                    <asp:RequiredFieldValidator ID="requiredArtist" runat="server" 
                        ControlToValidate="txtArtistName" 
                        ErrorMessage="ERROR: Please enter an artist name."
                        EnableClientScript="False">
                    </asp:RequiredFieldValidator>
                <a href="#" class="close">&times;</a>
            </div>
        </div>
    </div><!--/row2-->
    <%-- %><div class="row">
        <div class="small-12 columns">
            <asp:DropDownList ID="ddlAlbum" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlAlbum_SelectedIndexChanged"></asp:DropDownList>
        </div>
    </div>--%>
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
            <asp:Button ID="SubmitButton" runat="server"
                 Text="Submit" 
                onClick="FormSubmit" 
                CssClass="right button"/>
            <%--<asp:Button ID="BtnModify" runat="server" CssClass="button right" OnClick="Button1_Click" Text="Modify" />
            <asp:Button ID="BtnDelete" runat="server" CssClass="button right" OnClick="BtnDelete_Click" Text="Delete" />--%>
        </div>
    </div>
</asp:Content>

