using be_LunchBuddies.RestaurantNS;
using System;
using System.Collections.Generic;

namespace be_LunchBuddies.Buddy
{
  class LunchBuddy
  {
    public string BuddyFirstName { get; set; } = "Fist Name";
    public string BuddyLastName { get; set; } = "Fist Name";
    public List<string> ListOfRestaurantNames { get; set; } = new List<string>();
    //private List<string> LunchBuddies { get; set; } = new List<string>() { "Casey walker",
    //                                                                         "John Maple",
    //                                                                         "Chris Meffley",
    //                                                                         "Martin Sisk",
    //                                                                         "Katie Fry" };


    public LunchBuddy(string buddyFirstName,
                      string buddyLastName)
    {
      BuddyFirstName = buddyFirstName;
      BuddyLastName = buddyLastName;
    }

    public void Eat()
    {
      var tempReestaurant = new Restaurant();

      ListOfRestaurantNames.Add(tempReestaurant.RestaurantName);
    }

    public void Eat(string food)
    {
      Console.WriteLine($"{BuddyFirstName} {BuddyLastName} ate {food} at the office");
    }

    public void Eat(List<LunchBuddy> companions)
    {
      Random rnd = new Random();
      int index = rnd.Next(companions.Count);
      Random rnd2 = new Random();
      int index2 = rnd2.Next(ListOfRestaurantNames.Count);

      if (companions.Count > 0 && ListOfRestaurantNames.Count > 0)
      {
        Console.WriteLine($"\n\n{BuddyFirstName} {BuddyLastName} is eating at {ListOfRestaurantNames[index2]} with");
        foreach (var companion in companions)
        {
          Console.WriteLine($"{companion.BuddyFirstName},");
          if (companion.BuddyFirstName == "Casey")
          {
            Console.WriteLine("\n\nAnd Casey Walker is already eating pizza                                                 with pineapples.");
          }

        }
      }

    }

    public void Eat(string food, List<LunchBuddy> companions)
    {
      Random rnd = new Random();
      int index = rnd.Next(companions.Count);
      Random rnd2 = new Random();
      int index2 = rnd2.Next(ListOfRestaurantNames.Count);

      if (companions.Count > 0 && ListOfRestaurantNames.Count > 0)
      {
        Console.WriteLine($"\n\n{BuddyFirstName} {BuddyLastName} is eating {food} at {ListOfRestaurantNames[index2]} with");
        foreach (var companion in companions)
        {
          Console.WriteLine($"{companion.BuddyFirstName},");
          if (companion.BuddyFirstName == "Casey")
          {
            Console.WriteLine("\n\nAnd Casey Walker is already eating pizza                                                  with pineapples.");
          }

        }
      }
    }

  }
}
