using MyApp;
//dotnet test --collect:"XPlat Code Coverage"----->test result
// Falsifiable Manual Tests

AddFunctionShouldReturn30ForInputs10And20();
AddFunctionShouldReturn40ForInputs20And20();
AddFunctionShouldReturn50ForInputs25And25();

SubtractFunctionShouldReturn5ForInputs20And15();
MultiplyFunctionShouldReturn25ForInputs5And5();
DivideFunctionShouldReturn4ForInputs20And5();

void AddFunctionShouldReturn30ForInputs10And20()
{
    var calculator = new Calculator();

    var x = 10;
    var y = 20;
    var expectedResult = 30;

    var actualResult = calculator.Add(x, y);

    Console.WriteLine($"Add -> Actual: {actualResult}, Expected: {expectedResult}");

    if (actualResult == expectedResult)
        Console.WriteLine("Test Passed");
    else
        Console.WriteLine("Test Failed");
}

void AddFunctionShouldReturn40ForInputs20And20()
{
    var calculator = new Calculator();

    var expectedResult = 40;
    var actualResult = calculator.Add(20, 20);

    Console.WriteLine($"Add -> Actual: {actualResult}, Expected: {expectedResult}");

    if (actualResult == expectedResult)
        Console.WriteLine("Test Passed");
    else
        Console.WriteLine("Test Failed");
}

void AddFunctionShouldReturn50ForInputs25And25()
{
    var calculator = new Calculator();

    var expectedResult = 50;
    var actualResult = calculator.Add(25, 25);

    Console.WriteLine($"Add -> Actual: {actualResult}, Expected: {expectedResult}");

    if (actualResult == expectedResult)
        Console.WriteLine("Test Passed");
    else
        Console.WriteLine("Test Failed");
}

// ---------------- NEW TESTS ----------------

void SubtractFunctionShouldReturn5ForInputs20And15()
{
    var calculator = new Calculator();

    var expectedResult = 5;
    var actualResult = calculator.Subtract(20, 15);

    Console.WriteLine($"Subtract -> Actual: {actualResult}, Expected: {expectedResult}");

    if (actualResult == expectedResult)
        Console.WriteLine("Test Passed");
    else
        Console.WriteLine("Test Failed");
}

void MultiplyFunctionShouldReturn25ForInputs5And5()
{
    var calculator = new Calculator();

    var expectedResult = 25;
    var actualResult = calculator.Multiply(5, 5);

    Console.WriteLine($"Multiply -> Actual: {actualResult}, Expected: {expectedResult}");

    if (actualResult == expectedResult)
        Console.WriteLine("Test Passed");
    else
        Console.WriteLine("Test Failed");
}

void DivideFunctionShouldReturn4ForInputs20And5()
{
    var calculator = new Calculator();

    var expectedResult = 4;
    var actualResult = calculator.Divide(20, 5);

    Console.WriteLine($"Divide -> Actual: {actualResult}, Expected: {expectedResult}");

    if (actualResult == expectedResult)
        Console.WriteLine("Test Passed");
    else
        Console.WriteLine("Test Failed");
}