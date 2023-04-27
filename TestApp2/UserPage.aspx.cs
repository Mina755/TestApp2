using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2013.Excel;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Client;

namespace TestApp2
{
    public partial class UserPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelClick.Text = "The file will be downloaded in the next window";
        }

        protected void ButtonExcelDownload_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.open('Download.aspx','_blank'); window.focus();</script>");
            
            string text = "Download complete";

            LabelClick.Text = text;
        }

    }
}
