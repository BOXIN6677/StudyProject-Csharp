// ==========Part1==========

// 重载一元操作符(一元谓词)
// 语法: public static 返回值数据类型 operator 运算符(参数列表) {实现}

struct Person
{
    public string name;
    public int age;

    public Person(string m_name,int m_age)
    {
        name = m_name;
        age = m_age;
    }
    
    public static Person operator ++(Person p) // 重载++操作符
    {
        return new Person(p.name, p.age + 1);
    }
}

// ==========Part2==========

// 重载二元操作符(二元谓词)

struct Person2
{
    public string name;
    public int age;

    public Person2(string m_name, int m_age)
    {
        name = m_name;
        age = m_age;
    }

    public static bool operator ==(Person2 p1, Person2 p2) // 重载==操作符
    {
        if (p1.age == p1.age && p1.name == p2.name)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public static bool operator !=(Person2 p1, Person2 p2) // 重载==操作符时,还需要重载!=
    {
        return !(p1 == p2);
    }
}

class Project
{
    static void Main()
    {
        // Part1
        Person s = new Person("Jim",10);
        s++;
        Console.WriteLine("增长1岁后的年龄:{0}",s.age);
        
        // Part2
        Person2 m = new Person2("Jim", 20);
        Person2 m2 = new Person2("Jom", 20);
        
        if (m == m2){ Console.WriteLine("他们是同一个人"); }
        else{ Console.WriteLine("他们不是一个人"); }
    }
}