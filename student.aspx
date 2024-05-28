<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="CRUDUsingADO.NET.student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.6.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">


        <div class="form-group">
            <div class="col-md-2">
                <asp:Label ID="Label1" runat="server" Text="Name" CssClass="control-label"></asp:Label>

            </div>
            <div class="col-md-5">
                <asp:TextBox ID="TextBox1"  runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>


        <div class="form-group">
            <div class="col-md-2">
                <asp:Label ID="Label2" runat="server" Text="Age" CssClass="control-label"></asp:Label>

            </div>
            <div class="col-md-5">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>


        <div class="form-group">
            <div class="col-md-2">
                <asp:Label ID="Label3" runat="server" Text="Email" CssClass="control-label"></asp:Label>

            </div>
            <div class="col-md-5">
                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>


        <div class="form-group">
            <div class="col-md-2">
                <asp:Label ID="Label4" runat="server" Text="birth OF Date" CssClass="control-label"></asp:Label>

            </div>
            <div class="col-md-5">
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
            </div>
        </div>


        <div class="form-group">
            <div class="col-md-6">
                <asp:Button ID="Button1" runat="server" Text="create" CssClass="form-control  btn btn-primary"  OnClick="Button1_Click" />
          
                <asp:Button ID="Button2" runat="server" Text="clear" CssClass="form-control btn btn-secondary" OnClick="Button2_Click" />

            </div>
        </div>
       
            <div class="form-group">
                <div class="col-md-8">
                    <asp:Label ID="lblmessage" runat="server" CssClass="form-control"></asp:Label>
                </div>



            

            <h2>Student List </h2>
            <asp:GridView ID="gvstudent" runat="server" CssClass="table table-bordered table-hover"></asp:GridView>
            <table id="tlbstudent" runat="server"></table>
        </div>


    </form>
</body>
</html>
