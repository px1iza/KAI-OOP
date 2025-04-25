namespace String  
{
    public class NumbersString : BaseString
    {
        public NumbersString(string input) : base(input) { }  
 
        public override int GetLength()
        {
            return _value.Length;
        }

        public override string Shift()
        {
            if (_value.Length > 1)
            {
                char[] chars = _value.ToCharArray();

                char lastChar = chars[chars.Length - 1];
                for (int i = chars.Length - 1; i > 0; i--)
                {
                    chars[i] = chars[i - 1];  
                }
                chars[0] = lastChar; 

                return new string(chars);
            }
            return _value;
        }
    }
}