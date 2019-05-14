using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication1.ASM5
{
    class PhoneBook : Phone
    {
        List<ListDB> PhoneList = new List<ListDB>();

        public PhoneBook(List<ListDB> phoneList)
        {
            PhoneList = phoneList;
        }
        
        public void insertPhone(string name, string phone)
        {
            
            foreach (ListDB item in PhoneList)
            {
                if (!item.Name.Equals(name))
                {
                    Console.WriteLine("Test");
                    PhoneList.Add(new ListDB(name, phone));
                }
                if (!item.Name.Equals(phone))
                {
                    item.Phone += phone;
                }

            }
        }

        public void removePhone(string name)
        {
            foreach (ListDB item in PhoneList)
            {
                if (item.Equals(name))
                {
                    PhoneList.Remove(item);
                }
            }
        }

        public void searchPhone(string name)
        {
            foreach (ListDB item in PhoneList)
            {
                if (item.Name.Equals(name))
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void updatePhone(string name, string newphone)
        {
            foreach (ListDB item in PhoneList)
            {
                if (item.Name.Equals(name))
                {
                    item.Phone = newphone;

                }
            }
        }
        
    }
}