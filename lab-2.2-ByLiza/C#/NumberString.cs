namespace String  // Використовуйте іншу назву простору імен
{
    public class NumbersString : BaseString
    {
        public NumbersString(string input) : base(input) { }  // Конструктор з параметром, передаємо рядок в базовий клас

        // Перевизначення віртуальної функції для обчислення довжини рядка
        public override int GetLength()
        {
            return _value.Length;
        }

        // Перевизначення віртуальної функції для зсуву останнього символу на перше місце
        public override string Shift()
        {
            if (_value.Length > 1)
            {
                // Перетворюємо рядок на масив символів
                char[] chars = _value.ToCharArray();

                // Переміщаємо останній символ на перше місце
                char lastChar = chars[chars.Length - 1];
                for (int i = chars.Length - 1; i > 0; i--)
                {
                    chars[i] = chars[i - 1];  // зсуваємо кожен символ на одну позицію вправо
                }
                chars[0] = lastChar;  // ставимо останній символ на перше місце

                // Перетворюємо масив символів назад у рядок
                return new string(chars);
            }
            return _value;
        }
    }
}