using System.Collections.Specialized;

class Project
{
    static void Main()
    {
        Console.WriteLine("=================");
        Console.WriteLine("基础版:");

        Console.WriteLine("请输入你的年龄:");
        int age = int.Parse(Console.ReadLine()); // 输入除string其他类型需要 数据类型.Parse(Console.ReadLine())

        if (age < 18)
        {
            Console.WriteLine("你未成年,不允许进入网吧");
        }
        else
        {
            Console.WriteLine("欢迎进入网吧");
        }



        Console.WriteLine("=================");
        Console.WriteLine("进阶版:");

        Console.WriteLine("消费满100打9折,满200打8折");
        Console.WriteLine("请问你消费了多少:");
        int price = int.Parse(Console.ReadLine());
        if (price >= 200)
        {
            Console.WriteLine("打折后价格为:" + price * 0.8);
        }else if(price >= 100)
        {
            Console.WriteLine("打折后价格为:" + price * 0.9);
        }
        else
        {
            Console.WriteLine("抱歉,不能打折");
        }



        Console.WriteLine("=================");
        Console.WriteLine("再次进阶版:");

        Console.WriteLine("你迟到了吗:");
        string is_late = Console.ReadLine();
        if(is_late == "true" || is_late == "yes" || is_late == "是的")
        {
            Console.WriteLine("该罚");
        }else if(is_late == "false" || is_late == "no" || is_late == "没有")
        {
            Console.WriteLine("很好");
        }
        else
        {
            Console.WriteLine("你在胡说八道");
        }
    }
}