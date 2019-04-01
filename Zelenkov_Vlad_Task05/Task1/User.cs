using System;
using System.Text;

namespace Task1
{
    public class User
    {
        public string Name { get; private set; }
        public string Fam { get; private set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = now.Year - Birthday.Year;
                if (now.Month < Birthday.Month)
                {
                    if (now.Day < Birthday.Day)
                    {
                        age--;
                    }
                }
                return age;
            }
        }

        public User(string parName, string parFam)
        {
            Name = parName;
            Fam = parFam;
        }

        public User(string parName, string parFam, string parLastName)
        {
            Name = parName;
            Fam = parFam;
            LastName = parLastName;
        }

        public User(string parName, string parFam, string parLastName, DateTime parBirthday)
        {
            Name = parName;
            Fam = parFam;
            LastName = parLastName;
            Birthday = parBirthday;
        }

        public string LongInfo()
        {
            StringBuilder user = new StringBuilder();
            user.Append($"{Fam,-15}").Append(' ');
            user.Append($"{Name,-15}").Append(' ');
            user.Append($"{LastName,-15}").Append(' ');
            user.Append($"{Birthday.ToShortDateString(),10}").Append(' ');
            user.Append($"{Age,4}").Append(" years old");
            return user.ToString();
        }

        public string ShortInfo()
        {
            StringBuilder user = new StringBuilder();
            user.Append(Fam).Append(' ');
            user.Append(Name).Append(' ');
            user.Append(Age).Append(" years old");
            return user.ToString();
        }

    }
}
