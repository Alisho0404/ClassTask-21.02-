class Actor
{
    private string _actor;
    private int _age;
    private string _gender;
    private List<string> _moviesPlayed = new List<string>();

    public Actor()
    {

    }

    public Actor(string fullName, int age, string gender)
    {
        _actor = fullName;
        _age = age;
        _gender = gender;
    }

    public void AddMovie(string movieTitle)
    {
        _moviesPlayed.Add(movieTitle);
    }

    public List<string> GetMoviesPlayed()
    {
        return _moviesPlayed;
    }

    public void SetAge(int age)
    {
        _age = age;
    }

    public int GetAge()
    {
        return _age;
    }

    public void SetGender(string gender)
    {
        _gender = gender;
    }

    public string GetGender()
    {
        return _gender;
    }

    public void SetName(string name)
    {
        _actor = name;
    }

    public string GetName()
    {
        return _actor;
    }
}