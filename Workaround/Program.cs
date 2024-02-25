
using Business.Concrete;
using Entities.Concrete;

public class Program
{
    private static void Main(string[] args)
    {
        Person person1= new Person();
        person1.FirstName ="Çilem";
        person1.LastName = "Yamaç";
        person1.DateOfBirthYear = 1991;
        person1.NationalIdentity = 24238310632 ;

        Person person2= new Person();
        person2.FirstName = "Ayşe";

        Person person3 = new Person();
        person3.FirstName = "Adem";

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
    }
    
}