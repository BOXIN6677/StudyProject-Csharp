using System.Runtime.CompilerServices;

class MainProject
{
    static void Main()
    {
        CalcuCircle.Calcu();
    }
}

class CalcuCircle
{
    public struct Point // 点的位置
    {
        public int point_x;
        public int point_y;
    }

    public struct Circle // 圆心位置
    {
        public int ce_x;
        public int ce_y;

        public int radius; // 圆的半径
    }

    public static void Calcu() // 计算点与圆的关系(方法)
    {
        Point po;
        Circle cl;

        Console.WriteLine("请输入点的x坐标");
        int px = int.Parse(Console.ReadLine());

        Console.WriteLine("请输入点的y坐标");
        int py = int.Parse(Console.ReadLine());

        Console.WriteLine("请输入圆心的x坐标");
        int cx = int.Parse(Console.ReadLine());

        Console.WriteLine("请输入圆心的y坐标");
        int cy = int.Parse(Console.ReadLine());

        Console.WriteLine("请输入圆的半径");
        int rad = int.Parse(Console.ReadLine());


        double dx = px - cx;  // x方向距离
        double dy = py - cy;  // y方向距离
        double distanceSquared = dx * dx + dy * dy;  // 距离的平方
        double radiusSquared = rad * rad;            // 半径的平方

        // 比较距离平方和半径平方
        if (distanceSquared < radiusSquared)
        {
            Console.WriteLine("点在圆内 ✓");
        }
        else if (distanceSquared > radiusSquared)
        {
            Console.WriteLine("点在圆外 ✓");
        }
        else
        {
            Console.WriteLine("点在圆上 ✓");
        }
    }
}