using System.Collections.Specialized;

class Prom
{
    static void Main()
    {
        Console.WriteLine("============");
        Console.WriteLine("While循环");

        Console.WriteLine("请输入你的年龄:");
        int age = int.Parse(Console.ReadLine());
        while(age <= 18)
        {
            Console.WriteLine("你长到了" + age + "岁");
            age++;
        }
        Console.WriteLine("你成年了");



        Console.WriteLine("============");
        Console.WriteLine("For循环");

        age = 0;
        for(int i = age;i <= 18;i++)
        {
            Console.WriteLine("你现在" + i + "岁");
        }
        Console.WriteLine("你成年了");
    }
}