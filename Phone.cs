using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication1.ASM5
{
    public interface Phone
    {
        void insertPhone(string name, string phone);
        void removePhone(String name);
        void updatePhone(String name, String newphone);
        void searchPhone(String name);
    }
}