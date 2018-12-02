using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BaseLibrary;
using TimeLibrary;

namespace WindowsFormsApp1.Classes
{
    public class DataOperations : BaseSqlServerConnections
    {
        public DataOperations()
        {
            DefaultCatalog = "DateTimeDatabase";
        }
        /// <summary>
        /// demonstration on calculating differences between two time spans.
        /// As delivered in this code sample there are two records which have
        /// end time before start time which would be invalid in most cases.
        /// The reason for these two rows is for demoing validating if a end time
        /// is before a start time using a language extension method.
        /// 
        /// Output to the IDE console.
        /// * Column name/Data Ty;e
        /// * Invalid end time records, id, start and end time along with difference where in these cases TimeSpan
        ///   duration reports 23:00
        /// </summary>
        public DataTable ReadTimeTableDifferences()
        {
         
            var dt = new DataTable();

            mHasException = false;
            const string selectStatement = "SELECT id,FirstName,LastName,StartTime,EndTime, " + 
                                           "CONVERT(TIME, CONVERT(DATETIME, EndTime) - CONVERT(DATETIME, StartTime)) As Difference " + 
                                           "FROM  dbo.TimeTable;" ;

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn, CommandText = selectStatement })
                {
                    try
                    {
                        cn.Open();
                        dt.Load(cmd.ExecuteReader());

                        Console.WriteLine("Column names and type");
                        foreach (DataColumn col in dt.Columns)
                        {
                            Console.WriteLine($"{col.ColumnName} - {col.DataType}");
                        }

                        Console.WriteLine();
                        Console.WriteLine("Id  Start  End   Difference");

                        foreach (DataRow row in dt.Rows)
                        {
                            if (row.Field<TimeSpan>("EndTime").IsValidEndTime(row.Field<TimeSpan>("StartTime")))
                            {
                                Console.WriteLine($"{row.Field<int>("id").ToString("00")}  {row.Field<TimeSpan>("StartTime").ToString(@"hh\:mm")}  {row.Field<TimeSpan>("EndTime").ToString(@"hh\:mm")} {row.Field<TimeSpan>("Difference").ToString(@"hh\:mm")}");
                            }

                        }

                    }
                    catch (Exception e)
                    {
                        mHasException = true;
                        mLastException = e;
                    }
                }
            }

            return dt;
        }
        /// <summary>
        /// Read a table with primary key, two date time columns
        /// and create two string columns which will represent
        /// TimeSpan type.
        /// </summary>
        /// <returns></returns>
        public List<EventItem> ReadEventItemsList()
        {
            var eventList = new List<EventItem>();
            mHasException = false;
            const string selectStatement = "SELECT EventID, " + 
                                           "StartDate, " +
                                           "CONVERT(VARCHAR(5), StartDate,108) AS StartTime, " +
                                           "EndDate, " +
                                           "CONVERT(VARCHAR(5), EndDate,108) AS EndTime " +
                                           "FROM dbo.Events;";
            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand() {Connection = cn, CommandText = selectStatement})
                {
                    try
                    {
                        cn.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            eventList.Add(new EventItem()
                            {
                                EventID = reader.GetInt32(0),
                                StartDate = reader.GetDateTime(1),
                                StartTime = reader.GetString(2).TimeSpan(),
                                EndDate = reader.GetDateTime(3),
                                EndTime = reader.GetString(4).TimeSpan()
                            });
                        }

                    }
                    catch (Exception e)
                    {
                        mHasException = true;
                        mLastException = e;
                    }
                }
            }

            return eventList;
        }

        /// <summary>
        /// Read TimeTable data from SQL-Server database table
        /// </summary>
        /// <returns></returns>
        public List<Person> ReadTimeTable()
        {
            var pList = new List<Person>();

            mHasException = false;

            const string selectStatement = "SELECT  id,FirstName,LastName,StartTime,EndTime " + 
                                            "FROM dbo.TimeTable;";

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn, CommandText = selectStatement })
                {
                    try
                    {
                        cn.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            pList.Add(new Person()
                            {
                                Id = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                StartTime = reader.GetTimeSpan(3),
                                EndTime = reader.GetTimeSpan(4)
                            });
                        }
                    }
                    catch (Exception e)
                    {
                        mHasException = true;
                        mLastException = e;
                    }
                }
            }

            return pList;
        }
        /// <summary>
        /// Responsible for updating a StartTime for a record based off
        /// a selection in this case from TimeComboBox custom control.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="startTime"></param>
        /// <returns></returns>
        public bool UpdateStartTime(int id, TimeSpan startTime)
        {
            bool success = false;
            mHasException = false;
            const string updateStatement = "UPDATE dbo.TimeTable SET StartTime = @TimeValue  WHERE id = @Id";

            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand() {Connection = cn, CommandText = updateStatement })
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@TimeValue", startTime);
                    cn.Open();
                    success = cmd.ExecuteNonQuery() == 1;
                }
            }

            return success;
        }
    }
}
