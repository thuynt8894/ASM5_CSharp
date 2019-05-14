namespace ConsoleApplication1.ASM5
{
    public class ListDB
    {
        private string name;
        private string phone;
        
        public string Name

        {

            get { return name; }

            set { name = value; }

        }
        public string Phone

        {

            get { return phone; }

            set { phone = value; }

        }

        public ListDB(string name, string phone)
        {
            Name = name;
          
            Phone = phone;
        }


    }
}