using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SimpleAdoExample
{
    class Program
    {

        static void Main(String[] args)
        {

            //insertExcan();
            //updateExcan();
            deleteExcan();
            selectExcan();
            Console.ReadLine();
        }
        public static void selectExcan()
        {
            using(SqlConnection connction = new SqlConnection())
            {
                connction.ConnectionString = @"Data Source = ADMIN\SQLEXPRESS; Integrated Security = SSPI;" + "Initial Catalog=Recruitment";
                connction.Open();
                string sql = "select cCandidatecode,vfirstname From Externalcandidate";
                SqlCommand myCommand = new SqlCommand(sql, connction);
                using(SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    while(myDataReader.Read())
                    {
                        Console.WriteLine($"->Code : {myDataReader["cCandidatecode"]}, " + $"Name : {myDataReader["vfirstName"]}.");
                    }
                }
            }
        }

        public static void insertExcan()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source = ADMIN\SQLEXPRESS; Integrated Security = SSPI;" + "Initial Catalog=Recruitment";
                connection.Open();
                Console.WriteLine("enter code");
                string code = Console.ReadLine();
                Console.WriteLine("enter name ");
                string name = Console.ReadLine();
                string sql = "Insert into Externalcandidate" + $"(cCandidatecode,vFirstName)" + $"Values ('{code}','{name}')";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();

                }
            }
        }

        public static void updateExcan()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source = ADMIN\SQLEXPRESS; Integrated Security = SSPI;" + "Initial Catalog=Recruitment";
                connection.Open();
                Console.WriteLine("enter code");
                string code = Console.ReadLine();
              
                string sql = "Update Externalcandidate set " + $"cCandidatecode = " + $"'{code}'"+ " where vfirstName='rupali'";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();

                }
            }
        }

        public static void deleteExcan()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source = ADMIN\SQLEXPRESS; Integrated Security = SSPI;" + "Initial Catalog=Recruitment";
                connection.Open();
                Console.WriteLine("enter code");
                string code = Console.ReadLine();

                string sql = "Delete from Externalcandidate where " + $"cCandidatecode = " + $"'{code}'" ;
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                    
                }
            }
        }





    }
}
