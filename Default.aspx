<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul class="home-orbit" data-orbit>
  <li>
    <img src="img/outkast.jpg" alt="Outkast" />
  </li>
  <li>
    <img src="img/beatles.jpg" alt="Beatles" />
  </li>
  <li>
    <img src="img/nmh.jpg" alt="Neutral Milk Hotel" />
  </li>
</ul>
    <div class="row home-icons">
        <div class="medium-12 large-4 columns">
            <i class="foundicon-settings general"></i>
            <h4>Learn about us.</h4>
            <p>We are a database to store information about albums. Eventually, we'll have other cool features too.</p>
            <p><a href="about.aspx" class="button">Learn more</a></p>
        </div>
        <div class="medium-12 large-4 columns">
            <i class="foundicon-plus general"></i>
            <h4>Add an album.</h4>
            <p>Have a favorite album that other people should know about? Tell the world. Add it here.</p>
            <p><a href="add-album.aspx" class="button">Add an album</a></p>
        </div>
        <div class="medium-12 large-4 columns">
            <i class="foundicon-search general"></i>
            <h4>Explore.</h4>
            <p>View our elaborate database of user contributed albums and modify them as you see fit.</p>
            <p><a href="albumlist.aspx" class="button">Learn more</a></p>
        </div>
    </div>
</asp:Content>

