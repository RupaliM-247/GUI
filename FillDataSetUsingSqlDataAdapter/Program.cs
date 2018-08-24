using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FillDataSetUsingSqlDataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "Integrated Security=SSPI; Initial Catalog=Recruitment;" + @"Data Source=ADMIN\SQLEXPRESS";
            DataSet ds = new DataSet("Recruitment");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from ExternalCandidate", connectionString);
            adapter.Fill(ds,"ExternalCandidate");
            PrintDataSet(ds);
            Console.ReadLine();
        }

        static void PrintDataSet(DataSet ds)
        {
            foreach(DataTable dt in ds.Tables)
            {
                Console.WriteLine($"-> {dt.TableName} TableName");
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    Console.Write("Column name : " + dt.Columns[curCol].ColumnName + "\t");
                }
                Console.WriteLine("-----------------------------------------------");
                for(int curRow=0;curRow<dt.Rows.Count;curRow++)
                {
                    for(int curCol=0;curCol<dt.Columns.Count;curCol++)
                    {
                        Console.Write(dt.Rows[curRow][curCol].ToString() + "\t");

                    }
                }

            }



        }
    }
}
