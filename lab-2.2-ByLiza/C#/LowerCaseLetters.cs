namespace String
{
    public class LowerCaseString : BaseString
    {
        // Конструктор з параметром, передаємо рядок в базовий клас
        public LowerCaseString(string input) : base(input)
        {
            // Перетворюємо рядок в малі літери
            _value = input.ToLower();
        }

        // Перевизначення віртуальної функції для обчислення довжини рядка
        public override int GetLength()
        {
            return _value.Length;
        }

        // Перевизначення віртуальної функції для зсуву першого символу на останнє місце
        public override string Shift()
        {
            if (_value.Length > 1)
            {
                // Перетворюємо рядок на масив символів
                char[] chars = _value.ToCharArray();

                // Зсуваємо перший символ на останнє місце
                char firstChar = chars[0];
                for (int i = 0; i < chars.Length - 1; i++)
                {
                    chars[i] = chars[i + 1];  // зсуваємо кожен символ на одну позицію вліво
                }
                chars[chars.Length - 1] = firstChar;  // ставимо перший символ на останнє місце

                // Перетворюємо масив символів назад у рядок
                return new string(chars);
            }
            return _value;
        }
    }
}