using System;
namespace CS_DemoImplicitlyTypedLocalVar
{
class Program
{
static void Main()
{
int result=Add(20,10);
Console.WriteLine(result);
}
static Add(object a, object b)
{
return Convert.ToInt32(a) + Convert.ToInt32(b);
}
}
}