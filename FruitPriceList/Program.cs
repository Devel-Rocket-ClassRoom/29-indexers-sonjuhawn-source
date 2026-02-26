using System;
using System.Collections;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

FruitPriceList fruit = new FruitPriceList(5);
fruit.Add("사과", 1500);
fruit.Add("바나나", 3000);
fruit.Add("딸기", 8000);

Console.WriteLine($"등록된 과일 수: {fruit.Count}개");

Console.WriteLine($"사과 가격: {fruit["사과"]}원");
Console.WriteLine($"바나나 가격: {fruit["바나나"]}원");
Console.WriteLine($"포도 가격: {fruit["포도"]}원");

for(int i=0; i < fruit.Count; i++)
{
    Console.WriteLine($"{i}번: {fruit[i]}");
}

class FruitPriceList
{
    private string[] _names;
    private int[] _prices;
    private int _count;

    public FruitPriceList(int capacity)
    {
        _names = new string[capacity]; 
        _prices = new int[capacity];
        _count = 0;
    }

    public int Count
    {
        get { return _count; } 
    }

    public void Add(string name, int price)
    {
        if( _names.Length > _count)
        {
            _names[_count] = name;
            _prices[_count] = price;
            _count++;
        }
        else
        {
            Console.WriteLine("가격표가 가득 찼습니다.");
        }
    }

    public int Length
    {
        get { return _prices.Length; }
    }

    public int this[string name]
    {
        get {
                for (int i = 0; i < _prices.Length ; i++)
                {
                    if(_names[i] == name)
                    {
                        return _prices[i];
                    }
                }
                return -1;
            }
    }
    public string this[int index]
    {
        get { 
            if (_prices[index] == null)
            {
                return "";
            }
            else
            {
                return _names[index];
            }
            }
    }
}