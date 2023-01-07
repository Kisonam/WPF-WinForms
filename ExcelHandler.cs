using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Text;
using CsvHelper;
using DocumentFormat.OpenXml.Bibliography;

namespace LenguageCardLearning
{
    internal class ExcelHandler
    {
        public Application xlApp = new Application();

        Workbook workbook;
        Worksheet worksheet;

        // Method creates a new Excel file by creating a new Excel workbook with a single worksheet
        public void NewFile()
        {
            this.workbook = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            this.worksheet = this.workbook.Worksheets[1];
        }

        // Method adds a new worksheet to the existing workbook 
        public void NewSheet()
        {
            Worksheet newSheet = xlApp.Worksheets.Add(After: this.worksheet);
        }

        // Method saves workbook at a specified path
        public void SaveAs(string path)
        {
            workbook.SaveAs(path);
        }

        // Method closes Excel file
        public void CloseExcel()
        {
            workbook.Close();
        }

        public void OpenExcel()
        {
           worksheet.Activate();
        }
    }
}
