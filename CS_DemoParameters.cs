using System;

namespace CS_DemoParameters
{
class Program
{
// static int Add(ref int a, ref int b)
// {
// a*=a;//a=a*a;
// b*=b;//b=b*b;
// return a + b;
// }
static void Add(ref int a, ref int b, out int sum)
{
a*=a;//a=a*a;
b*=b;//b=b*b;
sum = a + b;
}
static void Main()
{
int n1=20;
int n2=10;
//int sum=Add(ref n1,ref n2);
int result;
Add(ref n1,ref n2,out result);
Console.WriteLine("The sum of {0} and {1} is {2}",n1,n2,result);
//Console.WriteLine("The sum of {0} and {1} is {2}",n1,n2,sum);
}
}
}