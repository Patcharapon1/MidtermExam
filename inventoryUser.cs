class InventoryUser
{
    private UserPass[]  userpasss;

    public InventoryUser(UserPass[] userpasss)
    {
        this.userpasss = userpasss;
    }
    public UserPass GetUserPass(string email)
    {
        foreach(UserPass userpass in userpasss)
        {
            if (userpass.GetEmail()==email)
            {
                return userpass;
            }
        }
        return null;
    }


    public UserPass Check(UserPass checkUser)
    {
        foreach(UserPass userpass in userpasss)
        {
            string email = checkUser.GetEmail();
            string password = checkUser.GetPassword();
            
            if (userpass.GetEmail()==email && userpass.GetPassword()==password)
            {
                return userpass;
            }
        }
        return null;
    }
    
}