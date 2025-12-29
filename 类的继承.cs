using System.Security.Cryptography.X509Certificates;

public class Animal
{
    // 自动属性: 编译器会自动生成私有字段
    public int age { get; set;  }
    public string name { get; set; }

    // 私有字段: 以下划线开头,存储真正的数据
    private int _age;
    private string _name;

    // 公开属性: 对外暴露的接口
    public string Name
    {
        get { return _name; }         // 读取时返回私有字段
        set { _name = value; }        // 写入时设置私有字段
    }
    public int Age
    {
        get { return _age; }          // get访问器：获取数据
        set { _age = value; }         // set访问器：设置数据
        // value是关键字，代表传入的值
    }

    // 构造函数: 初始化自动属性
    public Animal(string name,int age)
    {
        Name = name;
        Age = age;
    }

    public void Introd()
    {
        Console.WriteLine($"它的名字叫{Name}");
        Console.WriteLine($"它目前是{Age}岁");
    }
}

// 继承
// 语法: 继承方式 class 类名 :父类
public class Dog : Animal
{
    public string coat_color { get; set; } // 毛色

    // 调用父类构造函数
    public Dog(string a_name,int a_age,string a_coat_color)
        :base(a_name,a_age)
    {
        coat_color = a_coat_color;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name}正在大叫");
    }
}



class mainProject
{
    static void Main()
    {
        Dog doggy = new Dog("Jim", 4, "Black"); // 创建对象
        doggy.Introd();
        doggy.Bark();
        Console.WriteLine($"它的毛色是{doggy.coat_color}");
    }
}