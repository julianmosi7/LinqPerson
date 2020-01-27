using System;
using System.Collections.Generic;

using System.Linq;
using GenericDelegates.Linq;
using GenericDelegates.Db;


namespace GenericDelegates
{
  public class Program
  {

    private static void Main()
    {
      var db = new Database().Init();

      Console.WriteLine("--------------------- MalesStreetNrLessThan10");
      MalesStreetNrLessThan10(db).Select(x => $"{x.last_name} {x.first_name}").Print();
      Console.WriteLine("--------------------- FirstnamesInChina");
      FirstnamesInChina(db).Print();
      Console.WriteLine("--------------------- WriteLine");
      Console.WriteLine(MaxStreetNrPhilippines(db));
      Console.WriteLine("--------------------- CountriesWithEmailEndingWithOrg");
      CountriesWithEmailEndingWithOrg(db).Print();
      Console.WriteLine("--------------------- PersonsFromIndonesia");
      PersonsFromIndonesia(db).Select(x => $"{x.last_name} {x.first_name}").Print();

      Console.ReadKey();
    }

    public static List<Person> MalesStreetNrLessThan10(Database db)
    {
            return db.Persons.Where(x => x.gender == "male");
    }

    public static List<string> FirstnamesInChina(Database db)
    {
            return db.Persons.Select(x => x.first_name).Distinct().ToList();
    }

    public static int MaxStreetNrPhilippines(Database db)
    {
            return -1;
    }

    public static List<string> CountriesWithEmailEndingWithOrg(Database db)
    {
            return db.Persons.Where(x => x.email.EndsWith(".org")).Select(x => x.Adress.country).ToList();
    }

    public static List<Person> PersonsFromIndonesia(Database db)
    {
      return new List<Person>();
    }
  }
}
