class Student
{
    private string _fullName;
    private int _age;
    private int _grade;
    public Student()
    {
        
    }
    public Student(string name, int age)
    {
        _fullName=name;
        _age=age;
    }
    public Student(string name, int age, int grade)
    {
        _fullName = name;
        _age=age;
        _grade=grade;
    } 
    public void Study()
    {
        Console.WriteLine($"{_fullName} is studying");
    } 
    public void SetGrade(int newGrade)
    {
        _grade= newGrade;
    } 
    public int GetGrade()
    {
        return _grade;
    }
}