using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SwinAdventure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World"); 

            // Lines of code to be ignored. just a personal testing while building the project
            
            

            

            
            Item shovel = new Item(new String[] { "shovel", "spade" }, "a shovel", "This is a shovel from the gods...");
            Item banana = new Item(new String[] { "banana", "spade" }, "a yellow banana", "This is a banana from the gods...");

            Console.WriteLine(shovel.ShortDescription);
            Console.WriteLine(shovel.FullDescription);
            
            Player player = new Player("Kavin", "A persistent programmer");

            player.Inventory.Put(shovel);
            player.Inventory.Put(banana);

            Console.WriteLine(player.Locate("banana"));
            Console.WriteLine(player.Locate("me"));

            Console.WriteLine(player.FullDescription);
        }
    }
}
