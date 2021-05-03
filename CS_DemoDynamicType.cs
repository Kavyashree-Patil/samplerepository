using System;
namespace CS_DemoDynamicType
{
class Program
{
static void Main()
{
dynamic result=Add(20,10);
//dynamic result=Add("Hello","World");
result="Hello";

Console.writeLine(result);
}

static dynamic Add(dynamic a, dynamic b)
{
return a + b;
}
}
}