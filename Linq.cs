using Linq;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee
            {
                
                EmployeeID = 1001,
                FirstName = "Malcolm",
                LastName = "Daruwalla",
                Title = "Manager",
                DOB = Convert.ToDateTime("11/16/1984"),
                DOJ = Convert.ToDateTime("06/08/2011"),
                City = "Mumbai"
            });
            employees.Add(new Employee
            {

                EmployeeID = 1002,
                FirstName = "Asdin",
                LastName = "Dhalla",
                Title = "AsstManager",
                DOB = Convert.ToDateTime("08/20/1984"),
                DOJ = Convert.ToDateTime("07/07/2012"),
                City = "Mumbai"
            });
            employees.Add(new Employee
            {

                EmployeeID = 1003,
                FirstName = "Madhavi",
                LastName = "Oza",
                Title = "Consultant",
                DOB = Convert.ToDateTime("11/14/1987"),
                DOJ = Convert.ToDateTime("04/12/2015"),
                City = "Pune"
            });
            employees.Add(new Employee
            {

                EmployeeID = 1004,
                FirstName = "Saba",
                LastName = "Shaikh",
                Title = "SE",
                DOB = Convert.ToDateTime("06/03/1990"),
                DOJ = Convert.ToDateTime("02/02/2016"),
                City = "Pune"
            });
            employees.Add(new Employee
            {

                EmployeeID = 1005,
                FirstName = "Naiza",
                LastName = "Shaikh",
                Title = "SE",
                DOB = Convert.ToDateTime("03/08/1991"),
                DOJ = Convert.ToDateTime("02/02/2016"),
                City = "Mumbai"
            });
                 employees.Add(new Employee
                 {

                     EmployeeID = 1006,
                     FirstName = "Amit",
                     LastName = "Pathak",
                     Title = "Consultant",
                     DOB = Convert.ToDateTime("11/07/1989"),
                     DOJ = Convert.ToDateTime("08/08/2014"),
                     City = "Chennai"
                 });
            employees.Add(new Employee
            {

                EmployeeID = 1007,
                FirstName = "Vijay",
                LastName = "Nataraj",
                Title = "Consultant",
                DOB = Convert.ToDateTime("12/02/1989"),
                DOJ = Convert.ToDateTime("06/01/2015"),
                City = "Mumbai"
            });
            employees.Add(new Employee
            {

                EmployeeID = 1008,
                FirstName = "Rahul",
                LastName = "Dubrey",
                Title = "Associate",
                DOB = Convert.ToDateTime("11/11/1993"),
                DOJ = Convert.ToDateTime("11/06/2014"),
                City = "Chennai"
            });
            employees.Add(new Employee
            {

                EmployeeID = 1009,
                FirstName = "Suresh",
                LastName = "Mistry",
                Title = "Associate",
                DOB = Convert.ToDateTime("08/12/1992"),
                DOJ = Convert.ToDateTime("12/03/2014"),
                City = "Chennai"
            });
            employees.Add(new Employee
            {

                EmployeeID = 1010,
                FirstName = "Sumit",
                LastName = "Shah",
                Title = "Manager",
                DOB = Convert.ToDateTime("04/12/1991"),
                DOJ = Convert.ToDateTime("01/02/2016"),
                City = "Pune"
            });
            IEnumerable<Employee> Result = from i in employees
                                           select i;
            Console.WriteLine("DISPLAYING ALL THE DETAILS OF EMPLOYEES");
            foreach(Employee e in Result)
            {
                Console.WriteLine("" + e.EmployeeID + "-" + e.FirstName + "-" + e.LastName + "-" + e.Title + "-" + e.DOB + "-" + e.DOJ + "-" + e.City+ "");
            }
            Console.WriteLine();
            IEnumerable<Employee> Result2 = from i in employees
                                            where (i.City != "Mumbai")
                                            select i;
            Console.WriteLine("DISPLAY ALL THE DETAILS OF EMPLOYEES WHOSE LOCATION IS NOT MUMBAI");
            foreach( Employee e in Result2)
            {
                Console.WriteLine(e.EmployeeID + "-" + e.FirstName + "-" + e.LastName + "-" + e.Title + "-" + e.DOB + "-" + e.DOJ + "-" + e.City + "");
            }
            Console.WriteLine();
            IEnumerable<Employee> Result3 = from i in employees
                                            where (i.Title == "AsstManager")
                                            select i;
            Console.WriteLine("DISPLAY THE DETAILS OF THE EMPLOYEE WHERE EMPLOYEE TITLE IS ASSTMANAGER");
            foreach(Employee e in Result3)
            {
                Console.WriteLine( e.EmployeeID + "-" + e.FirstName + "-" + e.LastName + "-" + e.Title + "-" + e.DOB + "-" + e.DOJ + "-" + e.City + "");
            }
            Console.WriteLine();
            IEnumerable<Employee> Result4 = from i in employees
                                            where (i.LastName.StartsWith("S"))
                                            select i;
            Console.WriteLine("DISPLAY THE DETAILS OF THE EMPLOYEE WHOSE NAME STARTS WITH S");
            foreach(Employee e in Result4)
            {
                Console.WriteLine(e.EmployeeID + "-" + e.FirstName + "-" + e.LastName + "-" + e.Title + "-" + e.DOB + "-" + e.DOJ + "-" + e.City + "");
            }
            Console.WriteLine();
            IEnumerable<Employee> Result5 = from i in employees
                                            where (i.DOJ < Convert.ToDateTime("01/01/2015"))
                                            select i;
            Console.WriteLine("DISPLAY THE DETAILS OF THE EMPLOYEE WITH DOJ ");
            foreach( Employee e in Result5)
            {
                Console.WriteLine( e.EmployeeID + "-" + e.FirstName + "-" + e.LastName + "-" + e.Title + "-" + e.DOB + "-" + e.DOJ + "-" + e.City + "");
            }
            Console.WriteLine();
            IEnumerable<Employee> Result6 = from i in employees
                                            where (i.DOB > Convert.ToDateTime("01/01/1990"))
                                            select i;
            Console.WriteLine("DISPLAY THE DETAILS OF THE EMPLOYEE WITH DOB");
            foreach(Employee e in Result6)
            {
                Console.WriteLine( e.EmployeeID + "-" + e.FirstName + "-" + e.LastName + "-" + e.Title + "-" + e.DOB + "-" + e.DOJ + "-" + e.City + "");
            }
            Console.WriteLine();
            IEnumerable<Employee> Result7 = from i in employees
                                            where(i.Title == "Consultant" || i.Title == "Associate" )
                                            select i;
            Console.WriteLine("DISPALY DETAILS OF THE EMPLOYEE WHOSE TITLE IS CONSULTANT AND ASSOCIATE");
            foreach(Employee e in Result7)
            {
                Console.WriteLine( e.EmployeeID + "-" + e.FirstName + "-" + e.LastName + "-" + e.Title + "-" + e.DOB + "-" + e.DOJ + "-" + e.City + "");
            }
            Console.WriteLine();
            IEnumerable<Employee> Result8 = from i in employees
                                            select i;
            Console.WriteLine("NUMBER OF EMPLOYEES : {0}",employees.Count);
            foreach( Employee e in Result8)
            {
                Console.WriteLine(e.EmployeeID + "-" + e.FirstName + "-" + e.LastName + "-" + e.Title + "-" + e.DOB + "-" + e.DOJ + "-" + e.City + "");
            }
          
            Console.WriteLine();
            IEnumerable<Employee> Result9 = from i in employees
                                            where (i.City == "Chennai")
                                            select i;
            Console.WriteLine("NUMBER OF EMPLOYEES :{0}", Result9.Count());
            foreach( Employee e in Result9)
            {
                Console.WriteLine(e.EmployeeID + "-" + e.FirstName + "-" + e.LastName + "-" + e.Title + "-" + e.DOB + "-" + e.DOJ + "-" + e.City + "");
            }
            Console.WriteLine();
            int Result10 = employees.Max(x => x.EmployeeID);
                Console.WriteLine("DISPLAY HIGHEST EMPLOYEE ID");
            Console.WriteLine("Highest employee id : {0}", Result10);
            Console.WriteLine();

            IEnumerable<Employee> Result11 = from i in employees
                                             where (i.DOJ > Convert.ToDateTime("01/01/2015"))
                                             select i;
            Console.WriteLine("NUMBER OF EMPLOYEES : {0}", Result11.Count());
            foreach( Employee e in Result11)
            {
               Console.WriteLine(e.EmployeeID + "-" + e.FirstName + "-" + e.LastName + "-" + e.Title + "-" + e.DOB + "-" + e.DOJ + "-" + e.City + "");
            }
            Console.WriteLine();
            IEnumerable<Employee> Result12 = from i in employees
                                             where(i.Title != "Associate")
                                             select i;
            Console.WriteLine("NUMBER OF EMPLOYEES : {0}",Result12.Count());
            foreach( Employee e in Result12)
            {
                Console.WriteLine(e.EmployeeID + "-" + e.FirstName + "-" + e.LastName + "-" + e.Title + "-" + e.DOB + "-" + e.DOJ + "-" + e.City + "");
            }
            Console.WriteLine();
            var Result13 = from i in employees group i by i.City;
            Console.WriteLine("DISPLAY EMPLOYEE DETAILS BASED ON CITY");
            foreach(var j in Result13)
            {
                Console.WriteLine("{0}-{1}", j.Key, j.Count());
            }
            var Result14 = from i in employees group i by (i.City, i.Title);
            Console.WriteLine("DISPLAY EMPLOYEE DETAILS BASED ON CITY AND TITLE");
            foreach(var e in Result14)
            {
                Console.WriteLine("{0}-{1}", e.Key, e.Count());
            }
            var Result15 = employees.Select(x => x.DOB);
            Console.WriteLine("DISPLAY TOTAL NUMBER OF YOUNGER EMPLOYEES");
            Console.WriteLine("Total number of younger employee : {0}", Result15.Min());
            Console.WriteLine();
            Console.ReadLine();
                                 
            foreach (var Employee in employees)
            {
                Console.WriteLine(Employee.EmployeeID);
                Console.WriteLine(Employee.FirstName);
                Console.WriteLine(Employee.LastName);
                Console.WriteLine(Employee.Title);
                Console.WriteLine(Employee.DOB);
                Console.WriteLine(Employee.DOJ);
                Console.WriteLine(Employee.City);
                Console.WriteLine("************************************************");
            }
        }
         class Employee
         { 
            public int EmployeeID { get; set; } 
            public string FirstName { get; set; }
                public string LastName { get; set; }
            public string Title { get; set; }
             
            public DateTime DOB { get; set; }
            public DateTime DOJ { get; set; }
            public string City { get; set; }
            

         }
    }
}

  
