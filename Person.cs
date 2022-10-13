class Person
{
    private string nameTitle;
    private string name;
    private string surname;
    private string age;
    private string allergy;
    private string religion;


    public Person(string nameTitle,string name,string surname,string age,string allergy,string religion)
    {
        this.nameTitle = nameTitle;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.allergy = allergy;
        this.religion = religion;
    }
    public string GetNameTitle()
    {
        return this.nameTitle;
    }
    public string GetName()
    {
        return this.name;
    }
    public string GetSurname()
    {
        return this.surname;
    }
    public string GetAge()
    {
        return this.age;
    }
    public string GetAllergy()
    {
        return this.allergy;
    }
    public string GetReligion()
    {
        return this.religion;
    }
}