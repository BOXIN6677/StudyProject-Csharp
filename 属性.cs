// 属性: Csharp中一种特殊的类成员,看上去是字段,实际上是方法
// 提供了对私有字段的安全访问
class Students
{
    // 普通的私有字段
    private int _age;
    private string _name;
    
    // 属性(公开访问的接口)
    public int Age
    {
        get { return _age; }      // 读取字段时调用
        set { _age = value; }     // 写入数据时调用,value类似于形参
    }

    // 属性的简便写法
    public string Name
    {
        get => _name;
        set => _name = value;
    }
}


class Project
{
    static void Main()
    {
        Students st = new Students();
        // 写入属性
        st.Name = "Jim";
        st.Age = 18;
        Console.WriteLine($"学生姓名:{st.Name},学生年龄:{st.Age}");
    }
}