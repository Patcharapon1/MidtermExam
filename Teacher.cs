class Teacher : Person
{
    private string role;

    public Teacher(string nameTitle,string name,string surname,string age,string role,string allergy,string religion)
    : base(nameTitle,name,surname,age,allergy,religion)
    {
        this.role = role;
    }
    public string GetRole()
    {
        return this.role;
    }

}