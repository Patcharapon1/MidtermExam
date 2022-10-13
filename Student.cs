class Student : Person
{
    private string grade;
    private string school;

    public Student(string nameTitle,string name,string surname,string age,string grade,string allergy,string religion,string school)
    : base(nameTitle,name,surname,age,allergy,religion)
    {
        this.grade = grade;
        this.school = school;
    }
    public string GetGrade()
    {
        return this.grade;
    }
    public string GetSchool()
    {
        return this.school;
    }


}