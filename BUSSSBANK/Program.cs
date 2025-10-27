namespace BUSSSBANK;

class Program
{
    static void Main(string[] args)
    {
        int? x1 = 20;
        int? x2 = null;
        DisplayNullable(x1);
        DisplayNullable(x2);
        string? s = null;
        Console.WriteLine(s ?? "s is null");

        Account guy = new Account(100, "Bob");
        guy.Bal = 1000;
        Console.WriteLine(guy.dude);
        guy.withdraw(150);
        guy.show();
        guy.deposit(200);
        guy.show();
        guy.withdraw(150);
        guy.show();
        Account gal = new Account(100, "Bobette");
        gal.transfer(guy, 50);
        guy.show();

        gal.show();
    }

    static void DisplayNullable(int? number)
    {
        if (number.HasValue)
            Console.WriteLine($"Value is {number.Value}");
        else
            Console.WriteLine("No value (null)");
    }
}
