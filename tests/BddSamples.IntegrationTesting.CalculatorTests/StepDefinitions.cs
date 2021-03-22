using BddSamples.Calculating.Calculator;
using TechTalk.SpecFlow;
using Xunit;

namespace BddSamples.IntegrationTesting.CalculatorTests
{
    [Binding]
    public sealed class StepDefinitions
    {
        private Calculator _calculator;
        private decimal _actualResult;
       
        [Given(@"a new instance of a calculator")]
        public void GivenANewInstanceOfACalculator()
        {
            _calculator = new Calculator();
        }
    
        [When(@"I add (.*) and (.*) together")]
        public void WhenIAddOperand1AndOperand2Together(decimal operand1, decimal operand2)
        {
            _actualResult = _calculator.Add(operand1, operand2);
        }
    
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeExpectedResult(decimal expectedResult)
        {
            Assert.Equal(expectedResult, _actualResult);
        }

        [When(@"I multiply (.*) and (.*) together")]
        public void WhenIMultiplyOperand1AndOperand2Together(decimal operand1, decimal operand2)
        {
            _actualResult = _calculator.Multiply(operand1, operand2);
        }
    }
}