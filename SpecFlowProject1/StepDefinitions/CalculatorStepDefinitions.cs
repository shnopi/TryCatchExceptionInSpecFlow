using NUnit.Framework.Interfaces;
using System.Diagnostics;
using System.Reflection;
using TechTalk.SpecFlow.Bindings;

[Binding]
public class YourSpecFlowStepsClass
{

    [When("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        number = 5;

    }
    [Then("� ���������, ��� ����� (.*) ����� 3")]
    public void Equal3(int number)
    {
        number.Should().Be(10);
    }
}
