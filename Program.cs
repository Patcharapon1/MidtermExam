enum MenuLogout
{
    RegisterUser = 1,
    ShowStatistic,
    Login
}
enum MenuRegis
{
    Collegian = 1,
    Student,
    Teacher
}
enum MenuLogin
{
    RegisterUser = 1,
    Allcollegian,
    Allstudent,
    Allteacher,
    Logout
}
class Program
{
    public static PersonList personlist;
    public static void Main(string[] args)
    {
        PreparePersonListWhenProgramIsLoad();
        PrintMenu();
    }
    public static void PrintMenu()
    {
        PrintListMenuLogout();
        InputMenuLogoutFromKeyboard();
    }
    public static void PrintListMenuLogout()
    {
        Console.Clear();
        Console.WriteLine("----- Menu idea camp 2022 -----");
        Console.WriteLine("1.Register Idea Camp 2022");
        Console.WriteLine("2.Show registration statistics Idea Camp 2022");
        Console.WriteLine("3.Login");
        Console.WriteLine("-------------------------------");
    }
    public static void InputMenuLogoutFromKeyboard()
    {
        Console.Write("Please select menu : ");
        MenuLogout menuLogout = (MenuLogout)(int.Parse(Console.ReadLine()));

        PresentMenuLogout(menuLogout);
    }
    public static void PresentMenuLogout(MenuLogout menuLogout)
    {
        switch (menuLogout)
        {
            case MenuLogout.RegisterUser:
                InputRegisterUser();
                break;
            case MenuLogout.ShowStatistic:
                ShowRegisStatistic();
                break;
            case MenuLogout.Login:
                ShowLogin();
                break;
            default:
                break;
        }
        PrintMenu();

    }
    public static void PrintListMenuLogin()
    {
        Console.Clear();
        Console.WriteLine("----- Menu idea camp 2022 -----");
        Console.WriteLine("1.Register Idea Camp 2022");
        Console.WriteLine("2.All collegian register");
        Console.WriteLine("3.All student register");
        Console.WriteLine("4.All teacher register");
        Console.WriteLine("5.Logout");
        Console.WriteLine("-------------------------------");
    }
    public static void InputMenuLoginFromKeyboard()
    {
        Console.Write("Please select menu : ");
        MenuLogin menuLogin = (MenuLogin)(int.Parse(Console.ReadLine()));

        PresentMenuLogin(menuLogin);
    }
    public static void PresentMenuLogin(MenuLogin menuLogin)
    {
        switch (menuLogin)
        {
            case MenuLogin.RegisterUser:
                InputRegisterUser();
                break;
            case MenuLogin.Allcollegian:
                ShowAllcollegian();
                break;
            case MenuLogin.Allstudent:
                ShowAllstudent();
                break;
            case MenuLogin.Allteacher:
                ShowAllteacher();
                break;
            case MenuLogin.Logout:
                PrintMenu();
                break;
            default:
                break;
        }
        PrintListMenuLogin();
        InputMenuLoginFromKeyboard();

    }
    public static void ShowAllcollegian()
    {
        Console.Clear();
        Console.WriteLine("-----Collegian Register-----");

        Program.personlist.FetchCollegianPersonList();
        Console.Write("Press enter button to continue.");
        Console.ReadLine();
        PrintListMenuLogin();
        InputMenuLoginFromKeyboard();
    }
    public static void ShowAllstudent()
    {
        Console.Clear();
        Console.WriteLine("-----Student Register-----");

        Program.personlist.FetchStudentPersonList();
        Console.Write("Press enter button to continue.");
        Console.ReadLine();
        PrintListMenuLogin();
        InputMenuLoginFromKeyboard();
    }
    public static void ShowAllteacher()
    {
        Console.Clear();
        Console.WriteLine("-----Teacher Register-----");

        Program.personlist.FetchTeacherPersonList();
        Console.Write("Press enter button to continue.");
        Console.ReadLine();
        PrintListMenuLogin();
        InputMenuLoginFromKeyboard();
    }
    public static void ShowLogin()
    {
        Console.Clear();
        Console.WriteLine("Write < exit > for out");
        string email = InputEmail();
        if (email ==  "exit")
        {
            PrintMenu();
        }
        else
        {
            UserPass userpass = new UserPass(email,InputPassword());
            PrintListMenuLogin();
            InputMenuLoginFromKeyboard();
        }

    }


    public static void InputRegisterUser()
    {
        Console.Clear();
        PrintMenuRegister();
        InputMenuRegister();

    }
    public static void ShowRegisStatistic()
    {
        Console.Clear();
        Program.personlist.FetchPersonList();
        
        Console.Write("Press enter button to continue.");
        Console.ReadLine();
        Console.Clear();
        PrintMenu();
    }
    
    public static void PrintMenuRegister()
    {
        Console.WriteLine("1.Collegian");
        Console.WriteLine("2.Student");
        Console.WriteLine("3.Teacher");
    }
    public static void InputMenuRegister()
    {
        Console.Write("Please select group : ");
        MenuRegis menuregis = (MenuRegis)(int.Parse(Console.ReadLine()));

        PresentMenuRegister(menuregis);
    }
    public static void PresentMenuRegister(MenuRegis menuregis)
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
    public static void ShowInputCollegian()
    {
        Console.Clear();
        Console.WriteLine("Register collegian");
        Collegian collegian = new Collegian(InputNameTitle(),InputName(),InputSurname(),InputCollegianNumber(),InputAge(),InputAllergy(),InputReligion());
        string IsAdmin = InputAdmin();
        if(IsAdmin == "Y")
        {
            UserPass userpass = new UserPass(InputEmail(),InputPassword());
        }

        Program.personlist.AddNewPerson(collegian);
    }

    public static void ShowInputStudent()
    {
        Console.Clear();
        Console.WriteLine("Register student");
        Student student = new Student(InputNameTitle(),InputName(),InputSurname(),InputAge(),InputGrade(),InputAllergy(),InputReligion(),InputSchool());
        

        Program.personlist.AddNewPerson(student);
    }
    public static void ShowInputTeacher()
    {
        Console.Clear();
        Console.WriteLine("Register Teacher");
        Teacher teacher = new Teacher(InputNameTitle(),InputName(),InputSurname(),InputAge(),InputRole(),InputAllergy(),InputReligion());
        string HaveCar = InputCar();
        if(HaveCar == "Y")
        {
            InputNumCar();
        }
        string IsAdmin = InputAdmin();
        if(IsAdmin == "Y")
        {
            UserPass userpass = new UserPass(InputEmail(),InputPassword());
        }

        Program.personlist.AddNewPerson(teacher);

    }

    public static void PreparePersonListWhenProgramIsLoad()
    {
        Program.personlist = new PersonList();
    }
    

    public static string InputNameTitle()
    {
        Console.Write("Name Title : 1.Mr. 2.Mrs. 3.Miss : select number : ");
        int select = int.Parse(Console.ReadLine());
        if (select == 1)
            return "Mr.";
        else if (select == 2)
            return "Mrs.";
        else
            return "Miss";
    }
    public static string InputName()
    {
        Console.Write("Name : ");
        return Console.ReadLine();
    }
    public static string InputSurname()
    {
        Console.Write("Surname : ");
        return Console.ReadLine();
    }
    public static string InputCollegianNumber()
    {
        Console.Write("Collegian Number : ");
        return Console.ReadLine();
    }
    public static string InputAge()
    {
        Console.Write("Age : ");
        return Console.ReadLine();
    }
    public static string InputAllergy()
    {
        Console.Write("Allergy : ");
        return Console.ReadLine();
    }
    public static string InputReligion()
    {
        Console.Write("Religion : 1.Buddhism 2.Christianity 3.Islam 4.Other : select number : ");
        int select = int.Parse(Console.ReadLine());
        if (select == 1)
            return "Buddhism";
        else if (select == 2)
            return "Christianity";
        else if (select == 3)
            return "Islam";
        else 
            return "Other";
    }
    public static string InputGrade()
    {
        Console.Write("Grade : 1.M.4 2.M.5 3.M.6 : select number : ");
        int select = int.Parse(Console.ReadLine());
        if (select == 1)
            return "M.4";
        else if (select == 2)
            return "M.5";
        else 
            return "M.6";
    }
    public static string InputSchool()
    {
        Console.Write("School : ");
        return Console.ReadLine();
    }
    public static string InputRole()
    {

        Console.Write("Role : 1.Dean 2.Head of department 3.Full-time teacher : select number : ");
        int select = int.Parse(Console.ReadLine());
        if (select == 1)
            return "Dean";
        else if (select == 2)
            return "Head of department";
        else 
            return "Full-time teacher";
    }
    public static string InputAdmin()
    {
        Console.Write("Are you an admin? (Y/N) : ");
        return Console.ReadLine();
    }
    public static string InputEmail()
    {
        Console.Write("E-mail : ");
        return Console.ReadLine();
    }
    public static string InputPassword()
    {
        Console.Write("Password : ");
        return Console.ReadLine();
    }
    public static string InputCar()
    {
        Console.Write("Have car?(Y/N) : ");
        return Console.ReadLine();
    }
    public static string InputNumCar()
    {
        Console.Write("Number Car : ");
        return Console.ReadLine();
    }
    

}