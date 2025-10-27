public class Account
{
    float balance;
    string user;

    public float Bal
    {
        get
        {
            return balance;
        }
        set{
            if (value > 0)
            {
                balance = value;
            }
        }
    }
    public string dude
    {
        get { return user; }
    }

    public Account(float xbalance, string xuser)
    {
        balance = xbalance;
        user = xuser;
    }

    public void show()
    {
        Console.WriteLine($"Hello, {user}! yo balance lowkey ${balance}");
    }
    public void deposit(float amt)
    {
        balance += amt;
    }

    public float getBalance()
    {
        return balance;
    }
    public bool withdraw(float amt)
    {
        if (amt > balance)
        {
            return false;
        }
        else
        {
            balance -= amt;
            return true;
        }


    }

    public bool transfer(Account secondAccount, float amt)
    {
        if (amt > secondAccount.getBalance())
        {
            return false;
        }
        else
        {
            secondAccount.withdraw(amt);
            this.deposit(amt);
            return true;
        }


    }



}


