// ReSharper disable once CheckNamespace
namespace TechTalk.SpecFlow;

public static class ScenarioContextExtensions
{
    public static string GetResult(this ScenarioContext context) => 
        context["Result"]?.ToString() ?? throw new InvalidOperationException($"Result is not set in {nameof(ScenarioContext)}");

    public static void SetResult(this ScenarioContext context, string result) => context["Result"] = result;
}
