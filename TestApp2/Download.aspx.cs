using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Office2013.Excel;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace TestApp2
{
    public partial class Download : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fileName = "TableData.xlsx";

            byte[] myFile = CreateExcelFileWithData();

            SendExcelFileToClient(fileName, myFile);

        }

        public byte[] CreateExcelFileWithData()
        {
            //Data Generation
            int[] id = new int[10];
            string[] name = new string[10];
            double[] kwota = new double[10];

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                id[i] = i + 1;
                name[i] = "Name " + (i + 1).ToString();
                kwota[i] = random.Next(1000, 10000) + random.NextDouble();
            }

            //Create Excel file
            XLWorkbook workbook = new XLWorkbook();

            IXLWorksheet worksheet = workbook.Worksheets.Add("Sheet1");

            worksheet.Cell(1, 1).Value = "Id";
            worksheet.Cell(1, 2).Value = "ImieNazwisko";
            worksheet.Cell(1, 3).Value = "Kwota";

            //Fill the table cells with data
            for (int i = 0; i < 10; i++)
            {
                worksheet.Cell(i + 2, 1).Value = id[i];
                worksheet.Cell(i + 2, 2).Value = name[i];
                worksheet.Cell(i + 2, 3).Value = kwota[i];
            }

            //Save workbook to MemoryStream
            MemoryStream memoryStream = new MemoryStream();
            workbook.SaveAs(memoryStream);
            // Return an array of bytes from the MemoryStream
            return memoryStream.ToArray();
        }

        private void SendExcelFileToClient(string fileName, byte[] fileContent)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("Content-Disposition", "attachment; filename =" + fileName);
            Response.ContentType = ("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            Response.BinaryWrite(fileContent);
            Response.Flush();
            Response.End();
        }
    }
}