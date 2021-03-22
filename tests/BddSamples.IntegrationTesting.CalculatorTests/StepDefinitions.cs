using BddSamples.Calculating.Calculator;
using TechTalk.SpecFlow;
using Xunit;

namespace BddSamples.IntegrationTesting.CalculatorTests
{
    [Binding]
    public sealed class StepDefinitions
    {
        private readonly ScenarioContext _context;
        private Calculator _calculator;
        private decimal _actualResult;

        public StepDefinitions(ScenarioContext context)
        {
            _context = context;
        }
        
        [Given(@"a new instance of a calculator")]
        public void GivenANewInstanceOfACalculator()
        {
            _calculator = new Calculator();
        }
    
        [When(@"I add (.*) and (.*) together")]
        public void WhenIAddOperand1AndOperand2Together(int operand1, int operand2)
        {
            _actualResult = _calculator.Add(operand1, operand2);
        }
    
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeExpectedResult(decimal expectedResult)
        {
            Assert.Equal(expectedResult, _actualResult);
        }
    }
}