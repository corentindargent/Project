using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Labo1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connectionString = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LABO1;Integrated Security=True;");


            //Instruction
            string queryString =
             "select s.id,s.FullName,s.Birthdate,s.Remark,c.Description"
             +" from dbo.Student s"
             +" left join dbo.StudentCourse sc on s.Id = sc.StudentId"
             +" left join  dbo.Course c on  c.Id = sc.CourseId"
             +" order by s.id";
             

            using (connectionString)
            {
                SqlCommand command = new SqlCommand(queryString, connectionString);


                try
                {
                    connectionString.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    long idStudent = int.MinValue;

                    while(reader.Read())
                    {
                        if(idStudent == (long)reader[0])
                        {
                           // Console.WriteLine(idStudent+"\t {0}\n", reader[0]);
                            Console.WriteLine("\t\t\t {0}\n", reader.GetString(4));
                        }
                        else
                        {
                            idStudent = (long)reader[0];
                            Console.WriteLine(" \n\n \t{0}\t{1}\t{2}\t{3}\n Liste de cours \n\n\t\t\t{4}\n",
                             reader[0], reader[1], reader[2], reader[3],reader[4]);
                        }                       

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }

        }
    }
}
