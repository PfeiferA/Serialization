using System;

namespace Serialisation
{ 
    [Serializable]
    public class Group
    {
        private readonly Random rnd = new Random(DateTime.Now.Millisecond);
        private int privateint;
        public int Number { get; set; }
        public string Name { get; set; }
        public Group()
        {
            Number = rnd.Next(1, 10);
            Name = "Group" +rnd;
        }
        public Group(int number,string name)
        {
            if(number!=0 && name!=null)
            {
                Number = number;
                Name = name;
            }
        }
        public void SetPrivet(int i)
        {
            privateint = i;
        }
        public int GetPrivet()
        {
            return privateint;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
