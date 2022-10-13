class Teacher : Person
{
    private string role;
    private string havecar;
    private string numcar;


    public Teacher(string nameTitle,string name,string surname,string age,string role,string allergy,string religion,string havecar,string numcar)
    : base(nameTitle,name,surname,age,allergy,religion)
    {
        this.role = role;
        this.havecar = havecar;
        this.numcar = numcar;
    }
    public string GetRole()
    {
        return this.role;
    }
    public string GetHavecar()
    {
        return this.havecar;
    }
    public string GetNumcar()
    {
        return this.numcar;
    }
}