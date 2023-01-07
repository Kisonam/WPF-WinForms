using CsvHelper.Configuration;
using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguageCardLearning
{
   
    public class CsvHandler
    {
        public struct CsvHand
        {
            public string Word { get; set; }
            public string Transcription { get; set; }
            public string Translate { get; set; }

            public CsvHand(string word, string transcription, string translate)
            {
                this.Word = word;
                this.Transcription = transcription;
                this.Translate = translate;
            }
        }

        
        public void AddInBase(string path, string Word, string Transcription, string Translate)
        {
            List<CsvHand> readers = new List<CsvHand>();
            readers.Add(new CsvHand(Word, Transcription, Translate));

            StringBuilder csv = new StringBuilder();
            csv.AppendLine(readers[0].Word + ';' + readers[0].Transcription + ';' + readers[0].Translate);
            File.AppendAllText(path, csv.ToString(), Encoding.GetEncoding(1251));
        }

        public void ReadFromBase(string path)
        {

        }
    }
}
