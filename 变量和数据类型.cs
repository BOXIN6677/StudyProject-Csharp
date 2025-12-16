class Prom
{
    static void Main() // 主函数
    {
        // 语法: 数据类型 变量名 = 值 / var 变量名 = 值
        int num = 1;
        float fnum = 31.0f; // 浮点型需要在值后面加上f后缀
        double dnum = 3.14; // 精确浮点型
        string name = "Jim"; // 字符串
        bool is_alive = true; // 布尔类型

        var vul = 10; // 另一种形式
        var ret = num + vul;
        var let = ret; // 赋值

        Console.WriteLine("Num ="+num);
        Console.WriteLine("我的名字是" + name);
        Console.WriteLine("Num+Vul =" + ret);
        Console.WriteLine("let =" + let);

        Console.WriteLine("请输入你的年龄: ");
        string age = Console.ReadLine();
        Console.WriteLine("你的年龄是:" + age);

        System.Console.ReadKey(); // 按下任意键结束
    }
}
