
class Teacher
{
    string _fullName;
    string _subject;
    int _experience;

    public string Teach()
    {
        return $"{_fullName} teaching {_subject}";
    }
    public void SetExperience(int year)
    {
        _experience = year;
    }
    public int GetExperience()
    {
        return _experience;
    }
    public Teacher() { }
    public Teacher(string name, string subject)
    {
        _fullName = name;
        _subject = subject;
    }
    public Teacher(string name, string subject, int stazh)
    {
        _fullName = name;
        _subject = subject;
        _experience = stazh;
    }

}
 