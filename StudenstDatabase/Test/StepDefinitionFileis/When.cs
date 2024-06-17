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
    class When
    {
        private readonly Poco_files.PocoClass Data;


        public When(Poco_files.PocoClass Data)
        {
            this.Data = Data;

        }

        //Students stud = new Students();

        [When(@"we enter the details (.*), (.*),(.*),(.*)")]
        public void WhenWeEnterTheDetails(String name, int age, string branch, string section)
        {
            Students.Addition(name, age, branch, section);


            Data.result = Students.StudentList;
            ScenarioContext.Current.Add("dataofstudents", Data.result);

        }

        [When(@"we click add button")]
        public void WhenWeClickAddButton()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"we enter duplicate details (.*),(.*),(.*),(.*)")]
        public void WhenWeEnterDuplicateDetailsSaurabh(String a, int b, string c, string d)
        {

            var z = Students.StudentList;
            foreach (Student var in z)
            {

                if (var.Name == a)
                {
                    string message = "Student record with same name already exists";
                    Data.error_message = message;

                    break;

                }
            }

        }

        [When(@"the user provide a valid (.*)")]
        public void WhenTheUserProvideAValid(int p0)
        {
            Students.getDetails(p0);
        }

        [When(@"the user provide a invalid (.*)")]
        public void WhenTheUserProvideAInvalid(int invalid)
        {
            Students.invalidInput(invalid);
        }

    }
}
