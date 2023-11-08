using ConsoleApp10;

int intA = 5;
int intB = intA;
intA = 7;

Console.WriteLine(intA);
Console.WriteLine(intB);

string stringA = "Adam";
string stringB = stringA;
stringA = "Paweł";

Console.WriteLine(stringA);
Console.WriteLine(stringB);

bool boolA = true;
bool boolB = boolA;
boolA = false;

Console.WriteLine(boolA);
Console.WriteLine(boolB);

Test testA = new Test();
testA.Name = "Filip";
testA.Age = 10;
testA.IsTrueOrFalse = true;
Test testB = testA;
testA.Name = "Oskar";
testA.Age = 24;
testA.IsTrueOrFalse = false;

Console.WriteLine($"Test A {testA.Name} {testA.Age} {testA.IsTrueOrFalse}");
Console.WriteLine($"Test B {testB.Name} {testB.Age} {testB.IsTrueOrFalse}");

Console.WriteLine("testA method:\n");
testA.TestMethod(testA.Age);
Console.WriteLine("testB method:\n");
testB.TestMethod(testB.Age);