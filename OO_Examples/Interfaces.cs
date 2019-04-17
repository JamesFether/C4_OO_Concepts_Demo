using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Examples
{
    interface IContainer
    {
        List<String> Inventory { get; set; }
        void GetItemOut(string pItem);
        void PutItemIn(string pItem);
        void ListInventory();
    }

    interface ILockable
    {
        bool IsLocked { get; set; }
        void Lock();
        void Unlock();
    }

    interface ICloseable
    {
        bool IsOpen { get; set; }
        void Open();
        void Close();
    }
}
