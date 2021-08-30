using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sys = System;

using Microsoft.Office.Interop.Excel;

namespace ExcelDataHandler
{
    public static class Excel
    {
        static Application app = null;
        static Workbook book = null;
        static Worksheet sheet = null;
        static Range range = null;

        public static void OpenExcel()
        {
            if (app == null)
            {
                app = new Application();
            }

        }

        public static void OpenDocument()
        {
            if (book == null)
            {
                book = app.Workbooks.Open(Config.path);
                sheet = book.Worksheets[1];
                sheet.Activate();
            }
            
        }

        public static void Compare()
        {
            OpenExcel();
            OpenDocument();
            if (Config.fastMode)
            {
                CompareFast();
            }
            else
            {
                CompareDirect();
            }
            SaveDocument();
            CloseDocument();
        }

        public static void CompareDirect()
        {
            if(app != null && book != null)
            {
                Progress.Init((Config.ranges[0].rowEnd - Config.ranges[0].rowStart + 1) * (Config.ranges[1].rowEnd - Config.ranges[1].rowStart + 1));

                for (int i = Config.ranges[0].rowStart; i <= Config.ranges[0].rowEnd; i++)
                {
                    int cmpCount = 0;
                    for (int j = Config.ranges[1].rowStart; j <= Config.ranges[1].rowEnd; j++)
                    {
                        string str1 = sheet.Cells[i, Config.ranges[0].column].Value2.ToString();
                        string str2 = sheet.Cells[j, Config.ranges[1].column].Value2.ToString();
                        int cmpResult = Sys.String.Compare(str1, str2);
                        if (cmpResult == 0)
                        {
                            cmpCount++;
                        }
                        Progress.Update();
                    }
                    if (cmpCount == 0)
                    {
                        sheet.Cells[i, Config.ranges[0].column].Characters.Font.Color = Config.colorMatchNo;
                        //sheets[0].Cells[i, excelConfigs[0].column].Characters.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                    }
                    else if (cmpCount > 1 && Config.checkMatchMore1)
                    {
                        sheet.Cells[i, Config.ranges[0].column].Characters.Font.Color = Config.colorMatchMore1;
                        //sheets[0].Cells[i, excelConfigs[0].column].Characters.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
                    }
                    
                }
            }
            
        }

        public static void CompareFast()
        {
            if (app != null && book != null)
            {

                List<string> list1 = new List<string>();
                List<string> list2 = new List<string>();

                Progress.Init((Config.ranges[0].rowEnd - Config.ranges[0].rowStart + 1) + (Config.ranges[1].rowEnd - Config.ranges[1].rowStart + 1) +
                    ((Config.ranges[0].rowEnd - Config.ranges[0].rowStart + 1) * (Config.ranges[1].rowEnd - Config.ranges[1].rowStart + 1)));

                for (int i = Config.ranges[0].rowStart; i <= Config.ranges[0].rowEnd; i++)
                {
                    list1.Add(sheet.Cells[i, Config.ranges[0].column].Value2.ToString());
                    Progress.Update();
                }
                for (int i = Config.ranges[1].rowStart; i <= Config.ranges[1].rowEnd; i++)
                {
                    list2.Add(sheet.Cells[i, Config.ranges[1].column].Value2.ToString());
                    Progress.Update();
                }

                for (int i = 0; i < list1.Count; i++)
                {
                    int cmpCount = 0;
                    for (int j = 0; j < list2.Count; j++)
                    {
                        string str1 = list1[i];
                        string str2 = list2[j];
                        int cmpResult = Sys.String.Compare(str1, str2);
                        if (cmpResult == 0)
                        {
                            cmpCount++;
                        }
                        Progress.Update();
                    }
                    if (cmpCount == 0)
                    {
                        sheet.Cells[i + Config.ranges[0].rowStart, Config.ranges[0].column].Characters.Font.Color = Config.colorMatchNo;
                        //sheets[0].Cells[i, excelConfigs[0].column].Characters.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                    }
                    else if (cmpCount > 1 && Config.checkMatchMore1)
                    {
                        sheet.Cells[i + Config.ranges[0].rowStart, Config.ranges[0].column].Characters.Font.Color = Config.colorMatchMore1;
                        //sheets[0].Cells[i, excelConfigs[0].column].Characters.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
                    }
                }
            }

        }

        public static void GetRanges()
        {
            OpenExcel();
            OpenDocument();
            if (app != null && book != null)
            {
                range = sheet.Range["A1"].SpecialCells(XlCellType.xlCellTypeConstants);

                if (range.Areas.Count == 2)
                {
                    string addr1 = range.Areas.Item[1].Address;
                    string addr2 = range.Areas.Item[2].Address;

                    string[] borders1 = addr1.Replace(":", "").Split("$");
                    string[] borders2 = addr2.Replace(":", "").Split("$");

                    if (Sys.String.Equals(borders1[1], borders1[3]) && Sys.String.Equals(borders2[1], borders2[3]))
                    {

                        if (Sys.String.Compare(borders1[1], borders2[1]) < 0)
                        {
                            Config.column1Index = borders1[1];
                            Config.column1Start = borders1[2];
                            Config.column1End = borders1[4];

                            Config.column2Index = borders2[1];
                            Config.column2Start = borders2[2];
                            Config.column2End = borders2[4];
                        }
                        else if (Sys.String.Compare(borders1[1], borders2[1]) > 0)
                        {
                            Config.column1Index = borders2[1];
                            Config.column1Start = borders2[2];
                            Config.column1End = borders2[4];

                            Config.column2Index = borders1[1];
                            Config.column2Start = borders1[2];
                            Config.column2End = borders1[4];
                        }
                        else
                        {
                            Log.Write("Match ranges addres");
                        }

                    }
                    else
                    {
                        Log.Write("Columns index is not equals");
                    }


                }
                else
                {
                    Log.Write("Range areas != 2");
                }
            }
            else
            {
                Log.Write("App or book is null");
            }
            CloseDocument();
                
            
                         
        }

        public static void SaveDocument()
        {
            try
            {
                book.Save();
            }
            catch (Sys.Exception ex)
            {
                Log.Write(ex.Message);
                app.Visible = true;
            }
        }

        public static void CloseDocument()
        {
            if (book != null)
            {
                book.Close(SaveChanges: false);
                book = null;
            }
            
        }

        public static void CloseExcel()
        {
            if (app != null)
            {
                app.Quit();
                app = null;
            }
        }

        public static void Dispose()
        {
            app = null;
            book = null;
            sheet = null;
            range = null;

            Sys.GC.Collect();
        }




    }
}
