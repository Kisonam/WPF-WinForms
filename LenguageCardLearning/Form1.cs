using CsvHelper;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace LenguageCardLearning
{
    public partial class Form1 : Form
    {

        ExcelHandler handler = new ExcelHandler();
        CsvHandler CsvHandler = new CsvHandler();
        string filePath = "D:\\Data.csv";
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSaveWords_Click(object sender, EventArgs e)
        {
            CsvHandler.AddInBase(filePath, txtWord.Text, txtTrans.Text, txtTranslate.Text);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            handler.NewFile();
            handler.NewSheet();
            handler.SaveAs(filePath);
            handler.CloseExcel();
        }
    }
}
//var records = new List<CsvHandler>
//{
//    new CsvHandler {Word = txtWord.Text, Transcription = txtTrans.Text, Translate = txtTranslate.Text}
//};

//using (var writer = new StreamWriter(filePath))
//using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
//{

//    csv.WriteHeader<CsvHandler>();
//    csv.NextRecord();
//    foreach (var record in records)
//    {
//        csv.NextRecord();
//        csv.WriteRecord(record);

//    }
//}