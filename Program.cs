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
    static PersonList personlist;
    static void Main(string[] args)
    {
        PreparePersonListWhenProgramIsLoad();
        PrintMenu();
    }
    static void PrintMenu()
    {
        PrintListMenuLogout();
        InputMenuLogoutFromKeyboard();
    }
    static void PrintListMenuLogout()
    {
        Console.Clear();
        Console.WriteLine("----- Menu idea camp 2022 -----");
        Console.WriteLine("1.Register Idea Camp 2022");
        Console.WriteLine("2.Show registration statistics Idea Camp 2022");
        Console.WriteLine("3.Login");
        Console.WriteLine("-------------------------------");
    }
    static void InputMenuLogoutFromKeyboard()
    {
        Console.Write("Please select menu : ");
        MenuLogout menuLogout = (MenuLogout)(int.Parse(Console.ReadLine()));

        PresentMenuLogout(menuLogout);
    }
    static void PresentMenuLogout(MenuLogout menuLogout)
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
    static void PrintListMenuLogin()
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
    static void InputMenuLoginFromKeyboard()
    {
        Console.Write("Please select menu : ");
        MenuLogin menuLogin = (MenuLogin)(int.Parse(Console.ReadLine()));

        PresentMenuLogin(menuLogin);
    }
    static void PresentMenuLogin(MenuLogin menuLogin)
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
    static void ShowAllcollegian()
    {
        Console.Clear();
        Console.WriteLine("-----Collegian Register-----");

        Program.personlist.FetchCollegianPersonList();
        Console.ReadLine();
        PrintListMenuLogin();
        InputMenuLoginFromKeyboard();
    }
    static void ShowAllstudent()
    {
        Console.Clear();
        Console.WriteLine("-----Student Register-----");

        Program.personlist.FetchStudentPersonList();
        Console.ReadLine();
        PrintListMenuLogin();
        InputMenuLoginFromKeyboard();
    }
    static void ShowAllteacher()
    {
        Console.Clear();
        Console.WriteLine("-----Teacher Register-----");

        Program.personlist.FetchTeacherPersonList();
        Console.ReadLine();
        PrintListMenuLogin();
        InputMenuLoginFromKeyboard();
    }
    static void ShowLogin()
    {
        Console.Clear();
        InputEmail();
        InputPassword();

        PrintListMenuLogin();
        InputMenuLoginFromKeyboard();

    }


    static void InputRegisterUser()
    {
        Console.Clear();
        PrintMenuRegister();
        InputMenuRegister();

    }
    static void ShowRegisStatistic()
    {
        Console.Clear();
        Program.personlist.FetchPersonList();

        Console.ReadLine();
        Console.Clear();
        PrintMenu();
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
        string IsAdmin = InputAdmin();
        if(IsAdmin == "Y")
        {
            UserPass userpass = new UserPass(InputEmail(),InputPassword());
        }

        Program.personlist.AddNewPerson(collegian);
    }

    static void ShowInputStudent()
    {
        Console.Clear();
        Console.WriteLine("Register student");
        Student student = new Student(InputNameTitle(),InputName(),InputSurname(),InputAge(),InputGrade(),InputAllergy(),InputReligion(),InputSchool());
        

        Program.personlist.AddNewPerson(student);
    }
    static void ShowInputTeacher()
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

    static void PreparePersonListWhenProgramIsLoad()
    {
        Program.personlist = new PersonList();
    }
    

    static string InputNameTitle()
    {

        Console.Write("Name Title : 1.นาย 2.นาง 3.นางสาว : ");
        int select = int.Parse(Console.ReadLine());
        if (select == 1)
            return "นาย";
        else if (select == 2)
            return "นาง";
        else
            return "นางสาว";
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
        Console.Write("Religion : 1.พุทธ 2.คริสต์ 3.อิสลาม 4.อื่นๆ : ");
        int select = int.Parse(Console.ReadLine());
        if (select == 1)
            return "พุทธ";
        else if (select == 2)
            return "คริสต์";
        else if (select == 3)
            return "อิสลาม";
        else 
            return "อื่นๆ";
    }
    static string InputGrade()
    {
        Console.Write("Grade : 1.ม.4 2.ม.5 3.ม.6 : ");
        int select = int.Parse(Console.ReadLine());
        if (select == 1)
            return "ม.4";
        else if (select == 2)
            return "ม.5";
        else 
            return "ม.6";
    }
    static string InputSchool()
    {
        Console.Write("School : ");
        return Console.ReadLine();
    }
    static string InputRole()
    {

        Console.Write("Role : 1.คณบดี 2.หัวหน้าภาควิชา 3.อาจารย์ประจำ : ");
        int select = int.Parse(Console.ReadLine());
        if (select == 1)
            return "คณบดี";
        else if (select == 2)
            return "หัวหน้าภาควิชา";
        else 
            return "อาจารย์ประจำ";
    }
    static string InputAdmin()
    {
        Console.Write("Are you an admin? (Y/N) : ");
        return Console.ReadLine();
    }
    static string InputEmail()
    {
        Console.Write("E-mail : ");
        return Console.ReadLine();
    }
    static string InputPassword()
    {
        Console.Write("Password : ");
        return Console.ReadLine();
    }
    static string InputCar()
    {
        Console.Write("Have car?(Y/N) : ");
        return Console.ReadLine();
    }
    static string InputNumCar()
    {
        Console.Write("Number Car : ");
        return Console.ReadLine();
    }
    

}