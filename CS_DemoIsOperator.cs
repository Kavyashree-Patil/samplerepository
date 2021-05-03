/*using System;
namespace CS_DemoIsOperator
{
class Circle
{
int radius;
public Circle(int radius)
{
_radius=radius;
}
}


class Program
{
static void Main()
{
Circle c=new Circle(100);
object obj=c;
int number=Convert.To.Int32(obj);
}
}
}
*/

using System;

namespace CS_DemoIsOperator
{
class Circle
{
int _radius;
public Circle(int radius)
{
_radius=radius;
}
}
class Square
{
int _length;
public Square(int length)
{
_length=length;
}
}
class Test
{
public static void DoTest(object obj)
{
Circle c;
Square s;
if(obj is Circle)
{
Console.WriteLine("obj is of type Circle");
c=(obj as Circle); //(Circle)obj;
}
else if(obj is Square)
{
Console.WriteLine("obj is of type Square");
s=(obj as Square);
}
else
{
Console.WriteLine("obj is neither Circle nor Square");
}
}
}
class Program
{
static void Main()
{
Circle c=new Circle(100);
object obj=c;
if(obj is int)
{
Test.DoTest(obj);
int number=Convert.ToInt32(obj); //(int)obj
Console.WriteLine("The value is of type integer and the value is {0}",number);
}
Square s=new Square(50);
Test.DoTest(c);
Test.DoTest(s);
Test.DoTest(100);
}
}
}