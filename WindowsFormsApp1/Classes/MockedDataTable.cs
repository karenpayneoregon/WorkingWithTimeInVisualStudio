using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class MockedDataTable
    {
        public DataTable Table()
        {
            var dt = new DataTable();

            dt.Columns.Add(new DataColumn() {ColumnName = "id", DataType = typeof(int),AutoIncrement = true, AutoIncrementSeed = 1});
            dt.Columns.Add(new DataColumn() { ColumnName = "FirstName", DataType = typeof(string) });
            dt.Columns.Add(new DataColumn() { ColumnName = "LastName", DataType = typeof(string) });
            dt.Columns.Add(new DataColumn() { ColumnName = "StartTime", DataType = typeof(DateTime) });

            dt.Rows.Add(null, "Jeanine", "Abbott", new DateTime(2018,1,1,8,0,0));
            dt.Rows.Add(null, "Lester", "Lam", new DateTime(2018, 1, 1, 9, 0, 0));
            dt.Rows.Add(null, "Claire", "Cowan", new DateTime(2018, 1, 1, 10, 0, 0));

            return dt;
        }
    }
}
