using MarsOnboarding.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsOnboarding.Hooks
{
    [Binding]

    public sealed class Hooks : CommonDriver
    {
        [BeforeScenario]

        public void BeforeScenariowithTag()
        {
            Initialize();
        }
        
        [AfterScenario]

        public void AfterScenariowithTag()
        {
            Close();
        }
    }
}
