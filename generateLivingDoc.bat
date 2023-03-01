dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
pushd

livingdoc test-assembly Tests\bin\Debug\net6.0\Tests.dll -t Tests\bin\Debug\net6.0\TestExecution.json

popd