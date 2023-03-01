namespace Tests.StepDefinitions;

[Binding]
[Scope(Tag = "nullableclass")]
public sealed class NullableClassStepDefinitions : OptionStepDefinitions
{
    private Foo? _nullableClass = null;

    public NullableClassStepDefinitions(ScenarioContext scenarioContext)
        : base(scenarioContext)
    {
    }

    [Given(@"the class is null")]
    public void GivenTheClassIsNull() => _nullableClass = null;

    [Given(@"the class is not null")]
    public void GivenTheClassIsNotNull() => _nullableClass = new Foo();
    
    [When(@"I map and reduce the nullable class")]
    public void WhenMapReduceFoo()
    {
        MapReduce<Foo>(_nullableClass);
    }

    private class Foo
    {
        public override string ToString() => $"I am {nameof(Foo)}";
    }
}
