class PersonList
{
    private List<Person> personlist;

    public PersonList()
    {
        this.personlist = new List<Person>();
    }
    public void AddNewPerson(Person person)
    {
        this.personlist.Add(person);
    }
    public void FetchPersonList()
    {
        int countTeacher = 0;
        int countStudent = 0;
        int countCollegian = 0;
        foreach(Person person in this.personlist)
        {
            if(person is Teacher)
            {
                countTeacher += 1;
            }
            else
            {
                countTeacher += 0;
            }
        }
        Console.WriteLine("All Teacher : {0}",countTeacher);
    
        foreach(Person person in this.personlist)
        {
            if(person is Student)
            {
                countStudent += 1;
            }
            else
            {
                countStudent += 0;
            }
        }
        Console.WriteLine("All Student : {0}",countStudent);
        foreach(Person person in this.personlist)
        {
            if(person is Collegian)
            {
                countCollegian += 1;
            }
            else
            {
                countCollegian += 0;
            }
        }
        Console.WriteLine("All Collegian : {0}",countCollegian);
    }

}