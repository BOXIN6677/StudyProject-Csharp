// =========Part1==========
public class Animal
{
    public virtual void speak() // 父类虚方法
    {
        Console.WriteLine("动物的叫声");
    }
}

public class Dog : Animal
{
    public override void speak() // 重写父类虚方法
    {
        Console.WriteLine("汪汪");
    }
}

public class Cat : Animal
{
    public override void speak()
    {
        Console.WriteLine("喵喵");
    }
}

// =========Part2==========

public abstract class Tool // 抽象类需要有 abstract 关键字
{
    public abstract void use_manner(); // 抽象方法,子类必须要实现

    public void work()
    {
        Console.WriteLine("使用中...");
    }
}

public class Knife : Tool
{
    public override void use_manner()
    {
        Console.WriteLine("切菜");
    }
}

public class Hammer : Tool
{
    public override void use_manner()
    {
        Console.WriteLine("钉钉子");
    }
}

// ===========Part3==========

public interface Iplug // 定义一个接口(接口名开头必须是'I',命名约定)
{
    // 接口 和 抽象类的区别
    // 抽象类:"是什么(is)",只能继承一个抽象方法,可以有字段和属性
    // 接口:"能干什么(can)",可以实现多个,只能有属性
    void connect();      // 插上
    void disconnect();   // 拔出
}

public class Phone : Iplug
{
    public void connect()
    {
        Console.WriteLine("手机充电中...");
    }

    public void disconnect()
    {
        Console.WriteLine("充电完成!");
    }
}

public class Computer : Iplug
{
    public void connect()
    {
        Console.WriteLine("电脑使用中...");
    }

    public void disconnect()
    {
        Console.WriteLine("关机");
    }
}
class mainProject
{
    static void Main()
    {
        Console.WriteLine("============");
        Console.WriteLine("Part1:继承与虚方法");
        Animal anis = new Animal();
        Dog dogs = new Dog();
        Cat cats = new Cat();
        anis.speak();
        dogs.speak();
        cats.speak();

        Console.WriteLine("============");
        Console.WriteLine("Part2:抽象类");
        // Tool tools = new Tool();   抽象类无法实例对象
        Knife knife = new Knife();
        Hammer hammer = new Hammer();
        knife.use_manner();
        hammer.use_manner();
        knife.work();

        Console.WriteLine("============");
        Console.WriteLine("Part3:接口");
        // Iplug ipu = new Iplug();   接口无法实例对象
        Phone phone = new Phone();
        Computer pc = new Computer();
        phone.connect();
        phone.disconnect();
        pc.connect();
        pc.disconnect();
    }
}