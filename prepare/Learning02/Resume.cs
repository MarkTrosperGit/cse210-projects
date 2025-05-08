class Resume()
{
    public string _name = "";
    public List<Job> _list = new List<Job>();
    public void Display() 
    {
        Console.WriteLine($"Name: {_name}\nJobs:");
        for (int i = 0; i < _list.Count; i++) 
            {
                _list[i].Display();
            }

    }
}