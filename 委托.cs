// 委托： 一种引用类型,用于封装特定参数列表和返回类型的方法
// 就像一个遥控器,调用各种方法

// 定义一个委托类型

using System.Net.Sockets;

public delegate void Takeaway(string address,string food);

class KFC
{
    public static void TakeChicken(string address, string food)
    {
        Console.WriteLine($"肯德基, 将{food}送达了{address}");
    }
}

class BurgerKing
{
    public static void TakeBurger(string address, string food)
    {
        Console.WriteLine($"汉堡王, 将{food}送达了{address}");
    }
}

class Pizzeria
{
    public static void TakePizza(string address, string food)
    {
        Console.WriteLine($"披萨店, 将{food}送达了{address}");
    }
}



class Project
{
    static void Main()
    {
        // ====Part1====
        
        // 调用委托需要先实例对象,方法需要静态方法
        KFC kfc = new KFC();
        BurgerKing burger = new BurgerKing();
        Pizzeria pizza = new Pizzeria();
        
        // 单个委托
        Takeaway my_order = KFC.TakeChicken;
        my_order("Street NO.17", "炸鸡");
        
        // 多播委托
        Takeaway party_order = KFC.TakeChicken;
        party_order += BurgerKing.TakeBurger;
        party_order += Pizzeria.TakePizza;
        party_order("Street NO.32", "各种吃的");
        
        // 重新赋值
        Takeaway my_takes = KFC.TakeChicken;
        my_takes = Pizzeria.TakePizza;
        my_takes("Street NO.17", "榴莲千层披萨");
    }
}