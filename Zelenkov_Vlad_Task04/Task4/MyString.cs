using System.Text;

namespace Task4
{
    public class MyString
    {
        public char[] Value { get; set; }

        public MyString()
        {

        }

        public MyString(string parStr)
        {
            Value = parStr.ToCharArray();
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (var item in Value)
            {
                str.Append(item);
            }
            return str.ToString();
        }

        public static MyString operator +(MyString parStr1, MyString parStr2)
        {
            return new MyString(parStr1.ToString() + parStr2.ToString());
        }

        public static MyString operator -(MyString parStr1, MyString parStr2)
        {
            if (!parStr1.ToString().Contains(parStr2.ToString()))
            {
                return parStr1;
            }
            int i = parStr1.ToString().IndexOf(parStr2.ToString());
            return new MyString(parStr1.ToString().Remove(i, parStr2.ToString().Length));
        }

        public static bool operator ==(MyString parStr1, MyString parStr2)
        {
            if (parStr1.ToString().Equals(parStr2.ToString()))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(MyString parStr1, MyString parStr2)
        {
            return !(parStr1 == parStr2);
        }
    }
}
