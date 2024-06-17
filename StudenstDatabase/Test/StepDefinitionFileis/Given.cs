using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Test.StepDefinitionFileis
{   
    [Binding]
    class Given
    {
        [Given(@"we have opened the Appication")]
        public void GivenWeHaveOpenedTheAppication()
        {
            //ScenarioContext.Current.Pending();
        }
       

    }
}
