class Collegian : Person
{
    private string collegianNumber;
    public  Collegian(string nameTitle,string name,string surname,string collegianNumber,string age,string allergy,string religion)
    : base(nameTitle,name,surname,age,allergy,religion)
    {
        this.collegianNumber = collegianNumber;
    }
    public string GetCollegianNumber()
    {
        return this.collegianNumber;
    }
}