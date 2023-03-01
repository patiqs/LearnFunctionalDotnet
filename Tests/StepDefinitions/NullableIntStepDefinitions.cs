namespace Tests.StepDefinitions;

[Binding]
[Scope(Tag = "nullableint")]
public sealed class NullableIntStepDefinitions : OptionStepDefinitions
{
    private int? _nullableInteger = null;

    public NullableIntStepDefinitions(ScenarioContext scenarioContext)
        : base(scenarioContext)
    {
    }

    [Given(@"the nullable integer is null")]
    public void GivenTheNullableIntegerIsNull() => _nullableInteger = null;

    [Given(@"the nullable integer is '(.*)'")]
    public void GivenTheNullableIntegerIs(int value) => _nullableInteger = value;

    [When(@"I map and reduce the nullable integer")]
    public void WhenMapReduceIntWithCast()
    {
        MapReduce((Option<int>)_nullableInteger);
    }

    [When(@"I map and reduce the nullable integer using Options.From")]
    public void WhenMapReduceIntWithFrom()
    {
        MapReduce(Option<int>.From(_nullableInteger));
    }

}
