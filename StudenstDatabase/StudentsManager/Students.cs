using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsManager;
using static StudentsManager.Student;

namespace StudentsManager
{
    public class Students
    {

        public static List<Student> StudentList = new List<Student>();


        public static void Addition(string name, int age, string branch, string section)
        {
            Student stu = new Student();

            stu.value = stu.increment();
            stu.Name = name;
            stu.Age = age;
            stu.Branches = Convert.ToInt32((Branch)Enum.Parse(typeof(Branch), branch));
            stu.Sections = Convert.ToInt32((Section)Enum.Parse(typeof(Section), section)); ;
           

            StudentList.Add(stu);

        
        }

        static int s_id, s_age, s_branch, s_section;
        static string s_name;

        public static void getDetails(int id)
        {
            
            foreach(Student data in StudentList)
            {
                if(data.value == id)
                {
                    s_id = data.value;
                    s_name = data.Name;
                    s_age = data.Age;
                    s_branch = data.Branches;
                    s_section = data.Sections;

                    Console.WriteLine("user data found------------");
                    break;
                }
            }
        }

        public static void displayGetDetails()
        {
            Console.WriteLine("Student Id: "+s_id);
            Console.WriteLine("Student Name: "+s_name);
            Console.WriteLine("Student Age: "+s_age);
            Console.WriteLine("Student Branch: "+(Branch)s_branch);
            Console.WriteLine("Student Section: "+ (Section)s_section);
        }

        static string errorMessage;
        public static void invalidInput(int invalid)
        {

            foreach (Student data in StudentList)
            {
                if (data.value != invalid)
                {
                    errorMessage = "Invalid ID is Given";
                    break;  
                }
            }
        }

        public static void invalidErrorDisplay()
        {
            Console.WriteLine(errorMessage);
        }

        public static void ClearAll()
        {
            StudentList.Clear();
            Console.WriteLine("All Clear");
        }
    }

}
