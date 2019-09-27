using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CsvHelper;

namespace FrankTask
{
    public class Task
    {
        public static string FizzBuzz(int value, int fizz, int buzz)
        {
            string rt = "";
            if (value % fizz == 0)
            {
                rt="Fizz";
            }
            if (value % buzz == 0)
            {
                rt += "Buzz";

            }
            if(rt == "")
            {
                rt = "value:" + value + ",fizz:" + fizz + ",buzz:" + buzz;
            }
            return rt;
        }

        public static decimal WhoPutsWaterInBoxes(decimal length, decimal width, decimal height)
        {
            decimal volumn = length * width * height;
            decimal difference = decimal.Round(volumn / (decimal)61.024 - 1 , 4);
            return difference;
        }

        public static void EverySecondThursdayoftheWeek()
        {
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
           
            using (var reader = new StreamReader(dir + @"\CSVDatas.csv"))
            using (var csv = new CsvReader(reader))
            {
                var record = new CSVData();
                var records = csv.EnumerateRecords(record);
                List<CSVData> newRecords=new List<CSVData>();
                using (var writer = new StreamWriter(dir + @"\CSVDatas_Output.csv"))
                {
                    foreach (var r in records)
                    {
                        DateTime dateValue;
                        if (!DateTime.TryParse(r.Date, out dateValue))
                        {
                            r.Date = "";
                        }
                        CSVData newRecord = new CSVData();
                        newRecord.Name = r.Name;
                        newRecord.Date = r.Date;
                        newRecords.Add(newRecord);
                    }
                    using (var csv1 = new CsvWriter(writer))
                    {
                        csv1.WriteRecords(newRecords);
                    }
                }
                    



            }

           
        }

        public class CSVData
        {
            public string Name { get; set; }
            public string Date { get; set; }
        }
    }
}
