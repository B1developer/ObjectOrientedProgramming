// 1. Encapsulation: BankAccount class with private balance field and public methods
public class BankAccount
{
    // Private balance field (encapsulation)
    private decimal balance;

    // Public method to deposit money
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    // Public method to get the balance
    public decimal GetBalance()
    {
        return balance;
    }

    // Virtual method for polymorphism example
    public virtual void ShowAccountType()
    {
        Console.WriteLine("This is a generic bank account.");
    }
}

// 2. Inheritance: SavingsAccount class inheriting from BankAccount
public class SavingsAccount : BankAccount
{
    private decimal interestRate = 0.05m; // Example interest rate

    // Method to add interest to the balance
    public void AddInterest()
    {
        // Accessing the protected balance field from the base class
        Deposit(GetBalance() * interestRate);
    }

    // Overriding ShowAccountType method for polymorphism
    public override void ShowAccountType()
    {
        Console.WriteLine("This is a savings account.");
    }
}

// 3. Inheritance: CheckingAccount class inheriting from BankAccount
public class CheckingAccount : BankAccount
{
    // Overriding ShowAccountType method for polymorphism
    public override void ShowAccountType()
    {
        Console.WriteLine("This is a checking account.");
    }
}

// 4. Abstraction: Abstract Animal class with an abstract method
public abstract class Animal
{
    // Abstract method with no implementation
    public abstract void MakeSound();

    // Concrete method with implementation
    public void Sleep()
    {
        Console.WriteLine("The animal is sleeping.");
    }
}

// Derived class Dog from abstract Animal class
public class Dog : Animal
{
    // Overriding the abstract method
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

// Main Program to demonstrate all concepts
class Program
{
    static void Main()
    {
        // 1. Demonstrate Encapsulation
        Console.WriteLine("Encapsulation:");
        BankAccount myAccount = new BankAccount();
        myAccount.Deposit(100);
        Console.WriteLine("Balance after deposit: " + myAccount.GetBalance()); // Output: 100

        // 2. Demonstrate Inheritance and Polymorphism with BankAccount
        Console.WriteLine("\nInheritance and Polymorphism:");
        BankAccount savings = new SavingsAccount();
        savings.Deposit(500);
        savings.ShowAccountType();  // Output: This is a savings account.

        BankAccount checking = new CheckingAccount();
        checking.ShowAccountType(); // Output: This is a checking account.

        // 3. Demonstrate Abstraction with Animal class
        Console.WriteLine("\nAbstraction:");
        Animal myDog = new Dog();
        myDog.MakeSound();  // Output: Woof!
        myDog.Sleep();      // Output: The animal is sleeping.
    }
}
