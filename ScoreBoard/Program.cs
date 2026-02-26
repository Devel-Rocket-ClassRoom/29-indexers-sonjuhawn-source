using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

ScoreBoard student = new ScoreBoard(5);
student.Register("김민수", 85);
student.Register("이지영", 92);
student.Register("박서준", 78);

Console.WriteLine($"등록된 학생 수: {student.Count}명");

for (int i = 0; i < student.Count; i++)
{
    Console.WriteLine($"{i}번: {student[i]}");
}

Console.WriteLine($"김민수 점수: {student["김민수"]}원");
Console.WriteLine($"이지영 점수: {student["이지영"]}원");
Console.WriteLine($"홍길동 점수: {student["홍길동"]}원");

student["김민수"] = 95;

class ScoreBoard
{
    private string[] _names;
    private int[] _scores;
    private int _count;

    public ScoreBoard(int capacity)
    {
        _names = new string[capacity]; 
        _scores = new int[capacity];
        _count = 0;
    }

    public int Count
    {
        get { return _count; } 
    }

    public void Register(string name, int score)
    {
        if( _names.Length > _count)
        {
            _names[_count] = name;
            _scores[_count] = score;
            _count++;
        }
        else
        {
            Console.WriteLine("성적표가 가득 찼습니다.");
        }
    }

    public int Length
    {
        get { return _scores.Length; }
    }

    public int this[string name]
    {
        get {
                for (int i = 0; i < _scores.Length ; i++)
                {
                    if(_names[i] == name)
                    {
                        return _scores[i];
                    }
                }
                return -1;
            }
        set { _scores[name] = value; }
    }
    public string this[int index]
    {
        get { 
            if (0 <= index &&  index < _scores.Length)
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