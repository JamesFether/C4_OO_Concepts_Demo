using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Examples
{
    public class Shelf : IContainer
    {
        public List<string> Inventory { get; set; }

        public Shelf()
        {
            Inventory = new List<string>();
        }

        public void GetItemOut(string pItem)
        {
            Inventory.Remove(pItem);
            Console.WriteLine("You have taken the " + pItem + " off the shelf");
        }
        public void ListInventory()
        {
            Console.WriteLine("You see the following items on the shelf");

            foreach(var item in Inventory)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void PutItemIn(string pItem)
        {
            Inventory.Add(pItem);
            Console.WriteLine("You have put the " + pItem + " onto the shelf");
        }
    }

    public class Chest : IContainer, ICloseable, ILockable
    {
        public List<string> Inventory { get; set; }
        public bool IsOpen { get; set; }
        public bool IsLocked { get; set; }

        public Chest()
        {
            Inventory = new List<string>();
            IsOpen = false;
            IsLocked = true;
        }

        public void Open()
        {
            if (!IsOpen)
            {
                if (IsLocked == false)
                {
                    Console.WriteLine("You have opened the chest");
                    IsOpen = true;
                }
                else
                {
                    Console.WriteLine("You open the chest it is locked!!");
                }
            }
            else
            {
                Console.WriteLine("The chest is already open");
            }
        }

        public void Close()
        {
            if (IsOpen)
            {
                    Console.WriteLine("You have closed the chest");
                    IsOpen = false;
            }
            else
            {
                    Console.WriteLine("The chest is already closed");
            }
        }

        public void GetItemOut(string pItem)
        {
            Inventory.Remove(pItem);
            Console.WriteLine("You have taken the " + pItem + " out of the chest");
        }
        public void ListInventory()
        {
            Console.WriteLine("You see the following items in the chest");

            foreach (var item in Inventory)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void PutItemIn(string pItem)
        {
            Inventory.Add(pItem);
            Console.WriteLine("You have put the " + pItem + " into the chest");
        }

        public void Lock()
        {
            Console.WriteLine("You have locked the chest");
            IsLocked = true;

        }

        public void Unlock()
        {
            Console.WriteLine("You have unlocked the chest");
            IsLocked = false;
        }
    }
}
