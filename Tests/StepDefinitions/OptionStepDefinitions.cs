namespace Tests.StepDefinitions;

[Binding]
public class OptionStepDefinitions
{

    private readonly ScenarioContext _scenarioContext;

    public OptionStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Then(@"I get '(.*)'")]
    public void ThenIGet(string expected) => _scenarioContext.GetResult().Should().Be(expected);

    protected void MapReduce<T>(Option<T> option)
    {
        string result = option
            .Map(ToResult)
            .Reduce("reduced from none");
        _scenarioContext.SetResult(result);
    }

    private static string ToResult<T>(T some) => some?.ToString() ?? throw new InvalidOperationException("I don't know how can it happen");
}
