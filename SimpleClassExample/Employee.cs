using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
   public  class Employee
    {
        string name;
        string address;
        int age;
        long salary;
        long phone;
        DateTime dob = new DateTime();
        static int count = 0;

        public Employee()
        {
            /*name = "rupali";
            address = "anand plaza";
            age = 22;
            phone = 9876543210;
            salary = 90000;*/
            count++;
            Console.WriteLine("welcome to defaultt cons");
        }
        public Employee(string name,string address,int age,long phone,long salary)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.phone = phone;
            this.salary = salary;
            count++;
        }
        public static void showCount()
        {
            Console.WriteLine("count : {0}", count);
        }

        public void getEmployeeDetails()
        {
            
            using (SqlConnection connection = new SqlConnection())
            {

                connection.ConnectionString = @"Data Source = ADMIN\SQLEXPRESS; Integrated Security = SSPI;" + "Initial Catalog=Recruitment";
                connection.Open();
                Console.WriteLine("enter the name of employee :");
                this.name = Console.ReadLine();
                Console.WriteLine("enter the address of employee :");
                this.address = Console.ReadLine();
                agee: Console.WriteLine("enter the age of employee :");
                string age1 = Console.ReadLine();
                bool x = int.TryParse(age1, out this.age);
                if (x)
                {
                    Console.WriteLine("success");
                }
                else
                {
                    Console.WriteLine("failed to convert");
                    goto agee;
                }


                Console.WriteLine("enter the phone no of employee :");
                string phone1 = Console.ReadLine();
                this.phone = long.Parse(phone1);
                Console.WriteLine("enter the salary of employee :");
                string sal1 = Console.ReadLine();
                this.salary = long.Parse(sal1);
                Console.WriteLine("Please enter the date of birth in year/month/day format");
                string date = Console.ReadLine();
                this.dob = DateTime.Parse(date);

                string sql = "Insert into MyEmployee" + $"(name,address,age,salary,phone,dob)" + $"Values ('{this.name}','{this.address}','{this.age}','{this.salary}','{this.phone}','{this.dob}')";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();

                }
            }
           
            Console.WriteLine();


        }
        public void  displayEmployeeDetails()
        {
            /* Console.WriteLine("employee details :");
             Console.WriteLine("name of emp : {0}", this.name);
             Console.WriteLine("address of emp : {0}", this.address);
             Console.WriteLine("age of emp : {0}", this.age);
             Console.WriteLine("phone no  of emp  {0}:", this.phone);
             Console.WriteLine("salary of emp : {0}", this.salary);
             Console.WriteLine("dob : {0}", this.dob.Date);
             Console.WriteLine("count : {0}", count);
             Console.WriteLine();*/
            using (SqlConnection connction = new SqlConnection())
            {
                connction.ConnectionString = @"Data Source = ADMIN\SQLEXPRESS; Integrated Security = SSPI;" + "Initial Catalog=Recruitment";
                connction.Open();
                string sql = "select * From MyEmployee";
                SqlCommand myCommand = new SqlCommand(sql, connction);
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        Console.WriteLine($"->name : {myDataReader["name"]}, " + $"Address : {myDataReader["address"]}, " + $"Age : {myDataReader["age"]}, " + $"salary : {myDataReader["salary"]}, " + $"phone : {myDataReader["phone"]}, " + $"Date of birth : {myDataReader["dob"]}, ");
                    }
                }
            }

        }
       /* public void getEmployeeDetails(string name, string address, int age, long phone, long salary)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.phone = phone;
            this.salary = salary;
            Console.WriteLine();
        }*/
    }
}
