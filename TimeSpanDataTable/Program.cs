using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanDataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Code sample";

            UsingString();
            StronglyTyped();
            
            Console.ReadLine();

        }

        private static void UsingString()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{nameof(UsingString)}: Using string");
            Console.ResetColor();
            
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("StartTime", typeof(string)));

            dataTable.Rows.Add("10:10:0");
            dataTable.Rows.Add("");
            dataTable.Rows.Add("10:10:0");
            dataTable.Rows.Add("10-10/0");

            foreach (DataRow row in dataTable.Rows)
            {
                if (row.Field<string>("StartTime").IsNullOrWhiteSpace())
                {
                    Console.WriteLine("Empty");
                }
                else
                {
                    if (row.Field<string>("StartTime").IsValidTimeFormat())
                    {
                        Console.WriteLine(row.Field<string>("StartTime").ToTimeSpan());
                    }
                    else
                    {
                        Console.WriteLine($"{row.Field<string>("StartTime")} not valid");
                    }
                }
            }

            Console.WriteLine();
        }

        private static void StronglyTyped()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{nameof(StronglyTyped)}: Using TimeSpan");
            Console.ResetColor();



            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("StartTime", typeof(TimeSpan)));

            dataTable.Rows.Add(DateTime.Now.TimeOfDay);
            dataTable.Rows.Add();
            dataTable.Rows.Add(new TimeSpan(10, 0, 0));

            foreach (DataRow row in dataTable.Rows)
            {
                var test = row["StartTime"];
                if (row["StartTime"] != DBNull.Value)
                {
                    Console.WriteLine(row.Field<TimeSpan>("StartTime"));
                }
                else
                {
                    Console.WriteLine("Null");
                }
            }
        }
    }
}
