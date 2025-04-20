namespace String
{
    public class BaseString
    {
        protected string _value;

        // Тільки читання значення рядка
        public string Value { get => _value; }

        public BaseString(string input)
        {
            _value = input;
        }

        // Віртуальна функція обчислення довжини
        public virtual int GetLength()
        {
            return _value.Length;
        }

        // Віртуальна функція зсуву символів — для базового класу нехай нічого не змінює
        public virtual string Shift()
        {
            return _value;
        }
    }
}