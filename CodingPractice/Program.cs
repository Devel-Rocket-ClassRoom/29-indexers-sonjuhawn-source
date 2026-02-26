using System;
using System.Collections;
using System.Numerics;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Console.WriteLine("'''");
Catalog catalog = new Catalog();
Console.WriteLine(catalog[0]);
Console.WriteLine(catalog[1]);
Console.WriteLine(catalog[2]);

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Car car = new Car(3);
car[0] = "CLA";
car[1] = "CLS";
car[2] = "AMG";

for(int i = 0; i < car.Length; i++)
{
    Console.WriteLine(car[i]);
}

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Week week = new Week(3);
week[0] = "일요일";
week[1] = "월요일";
week[2] = "화요일";

for (int i = 0; i < week.Length; i++)
{
    Console.WriteLine(week[i]);
}

Console.WriteLine("'''\n");

Console.WriteLine("'''");
var nick = new NickName();

nick["홍길동"] = "RedPlus";
nick["김철수"] = "BlueStar";

Console.WriteLine($"{nick["홍길동"]}, {nick["김철수"]}");


Console.WriteLine("'''\n");


Console.WriteLine("'''");
MultiIndexer multi = new MultiIndexer();

multi[0] = "첫 번째 값";

multi["name"] = "홍길동";
multi["city"] = "서울";

Console.WriteLine($"multi[0] = {multi[0]}");
Console.WriteLine($"multi[\"name\"] = {multi["name"]}");
Console.WriteLine($"multi[\"city\"] = {multi["city"]}");


Console.WriteLine("'''\n");

Console.WriteLine("'''");
Example example = new Example();
example.Name = "홍길동";
example[0] = "첫 번째";
example[1] = "두 번째";

Console.WriteLine(example.Name);
Console.WriteLine($"{example[0]}, {example[1]}");

Console.WriteLine("'''\n");

class Catalog
{
    public string this[int index]
    {
        get { return (index % 2 == 0) ? ($"{index}: 짝수반환") : ($"{index}: 홀수반환"); }
    }
}

class Car
{
    public string[] name;
    public Car(int num)
    {
        name = new string[num];
    }

    public int Length
    {
        get { return name.Length; }
    }

    public string this[int index]
    {
        get { return name[index]; }
        set {  name[index] = value; }
    }
}

class Week
{
    public string[] day;
    public Week(int index)
    {
        day = new string[index];
    }

    public int Length
    {
        get { return day.Length; }
    }

    public string this[int index]
    {
        get { return day[index]; }
        set { day[index] = value; }
    }
}

class NickName
{
    private Hashtable _names = new Hashtable();

    public string this[string key]
    {
        get { return _names[key].ToString(); }
        set { _names[key] = value; }
    }
}

class MultiIndexer
{
    private Hashtable _data = new Hashtable();

    public string this[int index]
    {
        get { return (string)_data[index]; }
        set { _data[index] = value; }
    }

    public string this[string key]
    {
        get { return (string)_data[key]; }
        set { _data[key] = value; }
    }
}

class Example
{
    private string name;
    private string[] num = new string [10];

    public string Name
    {
        get { return  name; }
        set { name = value; }
    }

    public string this[int index]
    {
        get { return num[index]; }
        set { num[index] = value; }
    }

}