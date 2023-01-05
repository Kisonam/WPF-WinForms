using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace LenguageCardLearning
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp = new Excel.Application();
        Workbook xlWorkBook;    
        Worksheet xlWorkSheet;

        string filePath = "D:\\Data.xlsx";
        public Form1()
        {
            InitializeComponent();

            if (xlApp.Workbooks == null)
            {
                xlApp.Workbooks.Add();
            }

            xlWorkBook = xlApp.Workbooks.Open(filePath);
            xlWorkSheet = xlWorkBook.Worksheets[1];

            Range rng = xlWorkSheet.Range["A1:C1"];
            string[] startTxt = { "English", "Transcrptio", "Translate" };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (xlApp == null)
            {
                MessageBox.Show("Warning! Excel are not installed");
                return;
            }
        }
        private void btnSaveWords_Click(object sender, EventArgs e)
        {
            



            xlWorkBook.SaveAs(filePath);
        }

        
    }
}
