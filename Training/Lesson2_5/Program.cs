namespace Lesson2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Арифметические операции 
            #region Сумма +
            int valueA = 5; int valueB = 5;
            int valueC = valueA + valueB;

            Console.WriteLine(valueC);

            int valueQ = 2_000_000_001; int valueW = 2_000_000_001; //когда число больше положенного для int
            double valueE = (double)valueQ + (double)valueW; // то делают явное приведение на тип сильнее

            Console.WriteLine(valueE);

            long valueK = 32; byte valueL = 11; // если разные типы данных
            var valueJ = valueK + valueL; // то var принимает высший (сильнейший) тип long

            #endregion

            #region Разность -
            // то же что и в сумме
            #endregion

            #region Произведение * 
            // что и в сумме и в разности
            #endregion

            #region Частное /
            //int valueZ = 10; int valueX = 2;
            //int valueV = valueZ / valueX;

            //Console.WriteLine(valueV); // 5

            int valueZ = 5; int valueX = 2;
            int valueV = valueZ / valueX;

            Console.WriteLine(valueV); // ожид: 2,5 реал: 2

            // потому что происходит деление в целых числах (byte, int, ulong и т.д)
            // если double то все ОК
            #endregion

            #region Остаток от деления %

            // a = b * q + r
            // Делимое / Делитель = Неполное частное + Остаток [ 0 =< Остаток < |Делитель| ]
            Console.WriteLine("Деление в целых числах. Остаток");
            Console.WriteLine($"5/2 = {5 / 2}");
            Console.WriteLine($"5%2 = {5 % 2}");
            Console.WriteLine($"59/8 = {59 / 8}");
            Console.WriteLine($"59%8 = {59 % 8}");
            #endregion

            // Сокращенные операции

            #region +=
            Console.ReadKey(); Console.WriteLine("\n+=");

            int a = 12;
            int b = 13;
            //int c = a + b;

            //Console.WriteLine(c); //25

            // можно проще и быстрее

            a += b;
            Console.WriteLine(a); //25
            #endregion

            #region -=
            Console.ReadKey(); Console.WriteLine("\n-=");

            int c = 13;
            int v = 12;

            // можно проще и быстрее

            c -= v;
            Console.WriteLine(c); //1
            #endregion

            #region *=
            Console.ReadKey(); Console.WriteLine("\n*=");

            int z = 13;
            int x = 12;

            // можно проще и быстрее

            z *= x;
            Console.WriteLine(z); // 156
            #endregion

            #region /=
            Console.ReadKey(); Console.WriteLine("/= то же что и произведение");
            #endregion

            #region %=
            Console.ReadKey(); Console.WriteLine("%= то же что и произведение");
            #endregion

            #region ++
            Console.ReadKey(); Console.WriteLine("\n++");

            int m = 10;

            m += 20;
            Console.WriteLine(m); //30

            m++; //31 постфиксный инкремент //ниже приорите в уравнении
            Console.WriteLine(m);

            ++m; //32 префиксный инкремент //выше приоритет в уравнении
            Console.WriteLine(m);
            #endregion

            #region --
            Console.ReadKey(); Console.WriteLine("-- то же что и ++");
            #endregion


            // Логические операции

            bool variable1 = true; //1
            bool variable2 = false; //0

            //Высказывание (в математический логике) - Высказывание - это грамматически правильное
            //повествовательное предложение языка (естественного или искуственного),
            //которое выражает некоторый смысл и явдяется либо истинным,
            //либо ложным, но не тем и другим сразу

            //Пример 1. Na - металл - истина
            //Пример 2. 2 + 2 = 5 - ложь
            //Пример 3. Проксима Центавра - ближайшая к Земле звезда - Ложь

            #region Инверсия / Отрицание / Логическое "не" / !

            Console.WriteLine("\nИнверсия: ");
            // Определение. Отрицанием высказывания, будет являться высказывание
            // "противоположное" исходному

            Console.WriteLine($"variable1 = {variable1}  !variable1 = {!variable1}");
            Console.WriteLine($"variabl2 = {variable2}  !variable2 = {!variable2}");
            #endregion

            #region Конъюнкция / Логическое умножение / Логическое "И" / &&
            Console.WriteLine("\nКонъюнкция: ");

            // Конъюнкция двух высказываний, будет являться высказывание истинное тогда и только тогда,
            // когда оба исходных суждения истинны

            variable1 = true;
            variable2 = false;

            bool result = variable1 && variable2;

            Console.WriteLine($"{true} && {true} = {true && true}"); // true
            Console.WriteLine($"{true} && {false} = {true && false}"); // false
            Console.WriteLine($"{false} && {true} = {false && true}"); // false
            Console.WriteLine($"{false} && {false} = {false && false}"); // false
            #endregion

            #region Дизъюнкция / Логическое сложение / Логическое "ИЛИ" / ||
            Console.WriteLine("\nДизъюнкция: ");

            //Определение. Дизъюнкцией двух высказываний, будет являться высказывание ложное тогда и только тогда,
            //когда оба исходных высказывания ложны

            variable1 = true;
            variable2 = false;

            bool Result = variable1 || variable2;

            Console.WriteLine($"{true} || {true} = {true || true}"); // true
            Console.WriteLine($"{true} || {false} = {true || false}"); // true
            Console.WriteLine($"{false} || {true} = {false || true}"); // true
            Console.WriteLine($"{false} || {false} = {false || false}"); // false
            #endregion

            #region Разделительная дизъюнкция / Строгая дизъюнкция / Исключающее "ИЛИ" / ^
            Console.WriteLine("\nРазделительная дизъюнкция: ");

            // Определение. Разделительная дизъюнкцией двух высказываний, будет являться высказывание
            // истинное тогда и только тогда, когда только одно из исходных суждений истинно

            variable1 = true;
            variable2 = false;

            bool resulT = variable1 ^ variable2;

            Console.WriteLine($"{true} ^ {true} = {true ^ true}"); // false
            Console.WriteLine($"{true} ^ {false} = {true ^ false}"); // true
            Console.WriteLine($"{false} ^ {true} = {false ^ true}"); // true
            Console.WriteLine($"{false} ^ {false} = {false ^ false}"); // false
            #endregion

            #region Другие операции (самые частые)
            Console.WriteLine("\nДругие операции");

            bool flag1 = 4 > 5; Console.WriteLine(flag1);
            bool flag2 = 1 < 3; Console.WriteLine(flag2);
            bool flag3 = 'f' == 'f'; Console.WriteLine(flag3);
            bool flag4 = 28 == 28; Console.WriteLine(flag4);
            bool flag5 = 28 >= 24; Console.WriteLine(flag5);
            bool flag6 = 9 <= 9; Console.WriteLine(flag6);
            bool flag7 = 28 != 90; Console.WriteLine(flag7);

            string s = "C#";
            bool flag8 = 28 != 90 && s == "C#"; Console.WriteLine(flag8);
            #endregion

            #region Задача

            Console.WriteLine("\nЗадача");

            int x1 = 30, x2 = 150, //Координаты вершин прямоугольника
                y1 = 20, y2 = 90;

            int pA = 100, pB = 70; // Координаты точки

            // Проверка условия принадлежности точки ограниченной области
            bool check = ((pA >= x1) && (pA <= x2) && (pB >= y1) && (pB <= y2));
            Console.WriteLine(check);

            #endregion
        }
    }
}