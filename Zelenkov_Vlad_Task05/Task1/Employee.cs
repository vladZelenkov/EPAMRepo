using System;

namespace Task1
{
    public class Employee : User
    {
        private static int _currentID = 0;
        public int ID { get; private set; }
        private int _experience;
        public int Experience
        {
            get { return _experience; }
            set
            {
                if (value > 0 || value < 100)
                {
                    _experience = value;
                }
            }
        }
        public string Position { get; private set; }

        public Employee() : base("Vitaly", "Milonov")
        {
            AssignmentID();
        }

        public Employee(string parName, string parFam, string parPosition) :
            base(parName, parFam)
        {
            Position = parPosition;
            AssignmentID();
        }

        private void AssignmentID()
        {
            ID = _currentID;
            _currentID++;
        }

        public bool DefinePosition(string parNewPosition)
        {
            if (Position.Equals(parNewPosition))
            {
                Console.WriteLine("Positions are equals");
                return false;
            }
            Console.WriteLine($"Employee {Name} wants to change position on {parNewPosition}. Allow? (y/n)");
            switch (Console.ReadLine())
            {
                case ("y"):
                    Position = parNewPosition;
                    return true;
                case ("n"):
                    return false;
                default:
                    Console.WriteLine("Error. Wrong command.");
                    return false;
            }
        }
    }
}
