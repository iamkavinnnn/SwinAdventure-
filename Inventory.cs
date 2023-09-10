using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class Inventory
    {
        List<Item> _lists;
        public Inventory()
        { 
            _lists = new List<Item>();
        }

        public bool HasItem(string id)
        {
            foreach (Item item in _lists) 
            {
                if(item.AreYou(id)) {  return true; }
            }
            return false;
        }
        
        public void Put(Item itm)
        {
            _lists.Add(itm);
        }

        public Item Take(string id)
        {
            foreach(Item item in _lists)
            {
                if(item.AreYou(id))
                {
                    _lists.Remove(item);
                } 

                return item;
            }

            return null;
        }

        public Item Fetch(string id)
        {
            foreach(Item item in _lists)
            {
                if(item.AreYou(id))
                {
                    return item;
                }
            }
            return null;
        }

        public string ItemList
        {
            get
            {
                string listitems = "";
                foreach(Item item in _lists)
                {
                    listitems = listitems + item.ShortDescription + "\n ";
                }

                return listitems;
            }
        }
    }
}
