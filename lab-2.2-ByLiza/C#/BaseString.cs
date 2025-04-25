namespace String
{
    public class BaseString
    {
        protected string _value; 

        public string Value { get => _value; } 

        public BaseString(string input)
        {
            _value = input;
        }

        public virtual int GetLength()
        {
            return _value.Length;
        } 

        public virtual string Shift()
        {
            return _value;
        }
    }
}