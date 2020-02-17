using System;

class Program
{
    static void Main(string[] args)
    {
        AddressBook addressBook;
        AddressBook2 addressBook2 = new AddressBook2();

        addressBook.FirstName = "Victor";
        addressBook.LastName = "Storm";
        addressBook.Telephone = "698 479 478";
        
        addressBook2.FirstName = "Victor";
        addressBook2.LastName = "Storm";
        addressBook2.Telephone = "698 479 478";
        
        AddressBook[] a = new AddressBook[40];
        AddressBook2[] b = new AddressBook2[40];

        a[0].FirstName = "Max"; 
        a[20].FirstName = "Peter";

        for (int i = 0; i < b.Length; i++)
        {
            b[i] = new AddressBook2();
        }

        b[0].FirstName = "Paul";
        Console.ReadLine();

        AddressBook h = new AddressBook("John", "Bravo", "698 785 128");
        Console.WriteLine(h.FirstName);
        
        test(addressBook);
        test(addressBook2);
        
        Console.WriteLine(addressBook.FirstName);
        Console.WriteLine(addressBook2.FirstName);
    }

    public static void test(AddressBook t)
    {
        t.FirstName = "Tom";
    }
    
    public static void test(AddressBook2 t)
    {
        t.FirstName = "Tim";
    }
}

struct AddressBook
{
    public string FirstName;
    public string LastName;
    public string Telephone;
    public AddressBook(string firstName, string lastName, string telephone)
    {
        FirstName = firstName;
        LastName = lastName;
        Telephone = telephone;
    }
}

class AddressBook2
{
    public string FirstName;
    public string LastName;
    public string Telephone;
}

/*
  * NO INHERITANCE
  * BUT THERE IS IMPLEMENTATION
  * NO VIRTUAL F
  * FRAMEWORK CONSTRUCTOR
*/