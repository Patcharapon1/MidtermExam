enum Menu 
{
    RegisterUser = 1,
    ShowRegisterUser,
    Login
}
enum MenuRegis
{
    Collegian = 1,
    Student,
    Teacher
}
class Program
{
    static PersonList personlist;
    static void Main(string[] args)
    {
        PreparePersonListWhenProgramIsLoad();
        PrintMenu();
    }
    static void PrintMenu()
    {
        PrintListMenu();
        InputMenuFromKeyboard();
    }
    static void PrintListMenu()
    {
        Console.WriteLine("----- Menu idea camp 2022 -----");
        Console.WriteLine("1.Register idea camp 2022");
        Console.WriteLine("2.Show Register idea camp 2022");
        Console.WriteLine("3.Login");
        Console.WriteLine("-------------------------------");
    }
    static void InputMenuFromKeyboard()
    {
        Console.Write("Please select menu : ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PresentMenu(menu);
    }
    static void PresentMenu(Menu menu)
    {
        switch (menu)
        {
            case Menu.RegisterUser:
                InputRegisterUser();
                break;
                
            default:
                break;
        }
    }


    static void InputRegisterUser()
    {
        Console.Clear();
        PrintMenuRegister();
        InputMenuRegister();

    }
    static void PrintMenuRegister()
    {
        Console.WriteLine("1.Collegian");
        Console.WriteLine("2.Student");
        Console.WriteLine("3.Teacher");
    }
    static void InputMenuRegister()
    {
        Console.Write("Please select group : ");
        MenuRegis menuregis = (MenuRegis)(int.Parse(Console.ReadLine()));

        PresentMenuRegister(menuregis);
    }
    static void PresentMenuRegister(MenuRegis menuregis)
    {
        switch(menuregis)
        {
            case MenuRegis.Collegian:
                ShowInputCollegian();
                break;
            case MenuRegis.Student:
                ShowInputStudent();
                break;
            case MenuRegis.Teacher:
                ShowInputTeacher();
                break;
            default:
                break;
        }
    }
    static void ShowInputCollegian()
    {
        Console.Clear();
        Console.WriteLine("Register collegian");
        Collegian collegian = new Collegian(InputNameTitle(),InputName(),InputSurname(),InputCollegianNumber(),InputAge(),InputAllergy(),InputReligion());

        Program.personlist.AddNewPerson(collegian);
        BackToMainMenu();
    }
    static void ShowInputStudent()
    {
        Console.Clear();
        Console.WriteLine("Register student");
        Student student = new Student(InputNameTitle(),InputName(),InputSurname(),InputAge(),InputGrade(),InputAllergy(),InputReligion(),InputSchool());

        Program.personlist.AddNewPerson(student);
        BackToMainMenu();
    }
    static void ShowInputTeacher()
    {
        Console.Clear();
        Console.WriteLine("Register Teacher");
        Teacher teacher = new Teacher(InputNameTitle(),InputName(),InputSurname(),InputAge(),InputRole(),InputAllergy(),InputReligion());

        Program.personlist.AddNewPerson(teacher);
        BackToMainMenu();
    }

    static void BackToMainMenu()
    {
        Console.Clear();
        PrintListMenu();
        InputMenuFromKeyboard();
    }
    static void PreparePersonListWhenProgramIsLoad()
    {
        Program.personlist = new PersonList();
    }
    



    static string InputNameTitle()
    {
        Console.Write("Name Title : ");
        return Console.ReadLine();
    }
    static string InputName()
    {
        Console.Write("Name : ");
        return Console.ReadLine();
    }
    static string InputSurname()
    {
        Console.Write("Surname : ");
        return Console.ReadLine();
    }
    static string InputCollegianNumber()
    {
        Console.Write("Collegian Number : ");
        return Console.ReadLine();
    }
    static string InputAge()
    {
        Console.Write("Age : ");
        return Console.ReadLine();
    }
    static string InputAllergy()
    {
        Console.Write("Allergy : ");
        return Console.ReadLine();
    }
    static string InputReligion()
    {
        Console.Write("Religion : ");
        return Console.ReadLine();
    }
    static string InputGrade()
    {
        Console.Write("Grade : ");
        return Console.ReadLine();
    }
    static string InputSchool()
    {
        Console.Write("School : ");
        return Console.ReadLine();
    }
    static string InputRole()
    {
        Console.Write("Role : ");
        return Console.ReadLine();
    }

}