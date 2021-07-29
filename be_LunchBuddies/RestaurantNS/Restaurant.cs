using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_LunchBuddies.RestaurantNS 
{
  class Restaurant
  {
    private List<string> RestaurantNamesList { get; set; } = new List<string>() { "The Crusty Crab",
                                                                             "Chum Bucket",
                                                                             "Bob's Burgers",
                                                                             "Central Park Friends",
                                                                             "The Great Hall, Hogwarts",
                                                                             "Cafe 80'S",
                                                                             "Los Pollos Hermanos",
                                                                             "Mos Eisley Cantina",
                                                                             "Pizza Planet",
                                                                             "JJ's Diner" };

    public string RestaurantName { get; set; }


    public Restaurant()
    {
      Random rnd = new Random();
      int index = rnd.Next(RestaurantNamesList.Count);
      RestaurantName = RestaurantNamesList[index];

    }








  }
}
