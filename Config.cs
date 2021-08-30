using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace ExcelDataHandler
{
    public static class Config
    {
        public static string path { get; set; } = null;
        public static string sheet { get; set; } = null;
        public static string column1Index { get; set; } = null;
        public static string column1Start { get; set; } = null;
        public static string column1End { get; set; } = null;
        public static string column2Index { get; set; } = null;
        public static string column2Start { get; set; } = null;
        public static string column2End { get; set; } = null;


        public static Range[] ranges = null;

        public static Color colorMatchNo { get; set; }
        public static Color colorMatchMore1 { get; set; }

        public static bool checkMatchMore1 { get; set; }
        public static bool fastMode { get; set; }

        
        public static void InitCompare()
        {
            if (!File.Exists(path))
            {
                Log.Write("File not exist!");
            }
            ranges = new Range[] { new Range(column1Index, column1Start, column1End), new Range(column2Index, column2Start, column2End) };
        }




        public class Range
        {
            public dynamic column { get; set; } = null;
            public int rowStart { get; set; } = 0;
            public int rowEnd { get; set; } = 0;

            public Range(string column, string rowStart, string rowEnd)
            {
                int i = 0;

                if(int.TryParse(column, out i))
                {
                    this.column = i;
                }
                else
                {
                    this.column = column;
                }

                if (int.TryParse(rowStart, out i))
                {
                    this.rowStart = i;
                }
                else
                {
                    Log.Write("Row start parse error");
                }

                if (int.TryParse(rowEnd, out i))
                {
                    this.rowEnd = i;
                }
                else
                {
                    Log.Write("Row end parse error");
                }

                
            }
        }
        
    }
}
