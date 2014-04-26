<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AlbumList.aspx.cs" Inherits="AlbumList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <header>
    <div class="page-header">
        <div class="row">
            <div class="small-12 columns">
                <h1>Album List</h1>
                <h4><span class="subhead">View our collection of albums.</span></h4>
            </div>
         </div>
    </div>
    </header>
    <div class="row"><div class="small-12 columns"><h3>View our albums here, or <a href="add-album.aspx">add a new one.</a></h3><hr /><br /></div></div>
    <%--<div class="row">
        <dl class="tabs" data-tab>
  <dd class="active"><a href="#uncategorized">Uncategorized</a></dd>
  <dd><a href="#rock">Rock</a></dd>
  <dd><a href="#hip-hop">Hip-hop</a></dd>
  <dd><a href="#folk">Folk</a></dd>
</dl>
<div class="tabs-content">
  <div class="content active" id="uncategorized">
  </div>
  <div class="content" id="rock">
  </div>
  <div class="content" id="hip-hop">
  </div>
  <div class="content" id="folk">
  </div>
</div>
    </div>--%>
    <div class="row">
    <asp:Repeater ID="Repeater1" runat="server">
      <ItemTemplate>
          <div class="medium-6 large-3 columns album">
              <asp:HiddenField ID="genre" runat="server" value='<%# Eval("Genre")%>' ClientIDMode="Static" />
              <div class="show">
                  <img src='<%# Eval("Artwork")%>' />
      
                  <div class="mask">
                    <h2><%# Eval("AlbumName") %></h2>
                    <p>
                        <strong><%# Eval("ArtistName")%></strong>
                    </p>
                    <asp:Button ID="BtnModify" 
                        CssClass="button small" 
                        runat="server"
                        Text="Modify"
                        PostBackUrl='<%# string.Format("~/modify-album.aspx?id={0}", Eval("AlbumId")) %>' />
                  </div>
              </div>
          </div>  
      </ItemTemplate>
    </asp:Repeater>
        </div>
    <!--<script>
        $(sort);

        function sort() {
            var current;
            $("h2").each(function (i) {
                current = $("this").text();
                alert(current);
            });
        }
    </script>-->
</asp:Content>


