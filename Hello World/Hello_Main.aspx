<%@ Page Language="C#"%>

<!DOCTYPE html PUBLIC " -//W3C//DTD/xhtml 1.1//EN"
"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<script runat="server">
    void Page_load()
    {
        HelloWorld objHelloWorld = new HelloWorld();
        lblMessage.Text = objHelloWorld.SayMessage();
         
    }
    
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="head1" runat="server">
        <title>Show Hello World</title>
        <meta name="description" content="The description of my page" />
</head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:Label
                    id="lblMessage"
                    Runat="server" />

            </div>
        </form>
    </body>
</html>