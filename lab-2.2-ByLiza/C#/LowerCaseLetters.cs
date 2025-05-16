namespace String
{
    public class LowerCaseString : BaseString
    {
        public LowerCaseString(string input) : base(input)
        {
            _value = input.ToLower(); 
        }

        public override string Shift()
        {
            if (_value.Length > 1)
            {
                char[] chars = _value.ToCharArray();

                char firstChar = chars[0];
                for (int i = 0; i < chars.Length - 1; i++)
                {
                    chars[i] = chars[i + 1];  
                }
                chars[chars.Length - 1] = firstChar;  

                return new string(chars);
            }
            return _value;
        }

    }
}