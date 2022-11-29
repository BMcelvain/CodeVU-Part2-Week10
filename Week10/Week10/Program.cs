using System;
using System.Collections.Generic;

namespace Week10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, dynamic> inventory = new Dictionary<string, dynamic>();

            inventory.Add("gold", 500);
            List<string> pouchList = new List<string>() {"flint", "twine", "gemstone"};
            inventory.Add("pouch", pouchList);
            List<string> backpackList = new List<string>() { "xylophone", "dagger", "bedroll", "bread loaf" };
            inventory.Add("backpack", backpackList);
            List<string> pocketList = new List<string>() { "seashell", "strange berry", "lint" };
            inventory.Add("pocket", pocketList);
        }
    }
}
