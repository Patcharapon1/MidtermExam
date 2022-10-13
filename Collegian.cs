class Collegian : Person
{
    private string collegianNumber;
    public  Collegian(string nameTitle,string name,string surname,string age,string allergy,string religion,string collegianNumber)
    : base(nameTitle,name,surname,age,allergy,religion)
    {
        this.collegianNumber = collegianNumber;
    }
    public string GetCollegianNumber()
    {
        return this.collegianNumber;
    }
}