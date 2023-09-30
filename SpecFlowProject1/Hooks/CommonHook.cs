using TechTalk.SpecFlow;
using System;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public class CommonHooks
    {
        [BeforeStep]
        public void BeforeEachStep()
        {
            var stepText = ScenarioStepContext.Current.StepInfo.Text;
            Console.WriteLine($"Starting step: {stepText}");
        }

        [AfterStep]
        public void AfterEachStep()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                var stepText = ScenarioStepContext.Current.StepInfo.Text;
                var errorMessage = ScenarioContext.Current.TestError.Message;
                var enhancedErrorMessage = $"Step '{stepText}' failed with error: {errorMessage}";

                throw new Exception(enhancedErrorMessage);
            }
        }
    }
}

