class UserPass
{
    private string email;
    private string password;
    
    public UserPass(string email,string password)
    {
        this.email=email;
        this.password=email;
    }
    public string GetEmail()
    {
        return this.email;
    }
    public string GetPassword()
    {
        return this.password;
    }

}