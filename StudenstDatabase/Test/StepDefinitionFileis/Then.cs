using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using StudentsManager;
using static StudentsManager.Student;

namespace Test.StepDefinitionFileis
{
    [Binding]
    class Then
    {
        private readonly Poco_files.PocoClass Data;

        Students studen = new Students();

        public Then(Poco_files.PocoClass Data)
        {
            this.Data = Data;

        }


        [Then(@"the new student should be registerd into database")]
        public void ThenTheNewStudentShouldBeRegisterdIntoDatabase()
        {

            var stdlist = ScenarioContext.Current.Get<IEnumerable<Student>>("dataofstudents");


            foreach (Student item in stdlist)
            {
                Console.WriteLine("print here");
                System.Console.WriteLine("-------------------------------------------------");
                System.Console.WriteLine("" + item.Name);
                System.Console.WriteLine("" + item.Age);
                System.Console.WriteLine("" + (Branch)item.Branches);
                System.Console.WriteLine("" + (Section)item.Sections);
            }


        }



        [Then(@"Duplicate message error will display")]
        public void ThenDuplicateMessageErrorWillDisplay()
        {
            Console.WriteLine(Data.error_message);
        }


        [Then(@"the data of student will display")]
        public void ThenTheDataOfStudentWillDisplay()
        {
            Students.displayGetDetails();
        }

        [Then(@"the error will display")]
        public void ThenTheErrorWillDisplay()
        {
            Students.invalidErrorDisplay();
        }


    }
}
