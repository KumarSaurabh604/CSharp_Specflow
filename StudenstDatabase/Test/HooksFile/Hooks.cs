using StudentsManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Test.HooksFile
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [AfterFeature]
        public static void BeforeScenario()
        {
            Students.ClearAll();
        }

    }
}
