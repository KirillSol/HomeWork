namespace tutorial2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Конкатенация строк
            string firstName = "Александр";
            string lastName = "Пушкин";
            string specialization = "Писатель";

            byte age = 37;
            ulong yearOfBirth = 1799;

            //АлександрПушкниПисатель371799
            Console.WriteLine(firstName + lastName + specialization + age + yearOfBirth);
            Console.ReadKey();

            //Александр Пушкни Писатель 37 1799
            Console.WriteLine(firstName + " " + lastName + " " + specialization + " " + age + " " + yearOfBirth);
            Console.ReadKey();

            //Имя: Александр Фамилия: Пушкни Специалтзация: Писатель Возраст: 37 Год рождения: 1799
            Console.WriteLine("Имя: " + firstName + " Фамилия: " + lastName + " Специализация: " + specialization + " Возраст: " + age + " Год рождения: " + yearOfBirth);
            Console.ReadKey();

            //Имя: Александр Фамилия: Пушкни Специализация: Писатель Возраст: 37 Год рождения: 1799
            Console.WriteLine("Имя: {0} Фамилия: {1} Специализация: {2} Возраст: {3} Год рождения: {4}",
                firstName,
                lastName,
                specialization,
                age,
                yearOfBirth);
            Console.ReadKey();

            //Имя: Александр Фамилия: Пушкни Специализация: Писатель Возраст: 37 Год рождения: 1799
            string pattern = "Имя: {0} Фамилия: {1} Специализация: {2} Возраст: {3} Год рождения: {4}";
            Console.WriteLine(pattern,
                              firstName,
                              lastName,
                              specialization,
                              age,
                              yearOfBirth);

            //переиспользование pattern
            string fName = "Петя";
            string lName = "Пупкович";
            string profession = "Маляр";

            byte years = 37;
            ulong birth = 1815;

            Console.WriteLine(pattern,
                              fName,
                              lName,
                              profession,
                              years,
                              birth);

            string newPattern = "Имя: {0} \nФамилия: {1} \nСпециализация: {2} \nВозраст: {3} \nГод рождения: {4}";
            Console.WriteLine(newPattern,
                              fName,
                              lName,
                              profession,
                              years,
                              birth);
            Console.ReadKey();

            //   \n Новая строка
            //   \r Возврат каретки
            //   \t Горизонтальная табуляция
            //   \' Одиночная кавычка
            //   \" Двойная кавычка
            //   \\ Обратная косая черта
            //   \? Литерал вопросительного знака

            Console.WriteLine($"Имя: {fName} \nФамилия: {lName} \nСпециализация: {profession} \nВозраст: {years} \nГод рождения: {birth}");

            #region Калькулятор

            Console.ReadKey(); Console.Clear();

            int a = 100;
            int b = 11;
            int c = 111;
            Console.WriteLine($"{a} + {b} = {c}");

            #endregion

            #region База данных v 1.0
            Console.ReadKey(); Console.Clear();

            string name1 = "Вася", lastName1 = "Пупкин";
            string name2 = "Петя", lastName2 = "Помидоров";
            string name3 = "Андрей", lastName3 = "Голожопов";
            string name4 = "Семен", lastName4 = "Рукожопов";
            string name5 = "Сергей", lastName5 = "Аутистович";

            Console.WriteLine($"{name1} {lastName1}");
            Console.WriteLine($"{name2} {lastName2}");
            Console.WriteLine($"{name3} {lastName3}");
            Console.WriteLine($"{name4} {lastName4}");
            Console.WriteLine($"{name5} {lastName5}");
            #endregion


            #region База данных v 2.0
            Console.ReadKey(); Console.Clear();

            string Name1 = "Вася", LastName1 = "Пупкин";
            string Name2 = "Петя", LastName2 = "Помидоров";
            string Name3 = "Андрей", LastName3 = "Голожопов";
            string Name4 = "Семен", LastName4 = "Рукожопов";
            string Name5 = "Сергей", LastName5 = "Аутистович";

            Console.WriteLine($"{Name1,10} {LastName1,11}");
            Console.WriteLine($"{Name2,10} {LastName2,11}");
            Console.WriteLine($"{Name3,10} {LastName3,11}");
            Console.WriteLine($"{Name4,10} {LastName4,11}");
            Console.WriteLine($"{Name5,10} {LastName5,11}");
            #endregion


            #region Пример работы с числовым типом
            Console.ReadKey(); Console.Clear();

            double d = 123456.654321;
            Console.WriteLine(d); //123456.654321

            string dFormated = d.ToString("#.###");
            Console.WriteLine(dFormated); //123456.654

            Console.WriteLine("{0:0.000}", d); //123456.654

            Console.WriteLine(d.ToString("#.###"));

            dFormated = d.ToString("#.## ## ## ## ##");
            Console.WriteLine(); //123456.65 43 21

            dFormated = d.ToString("### ###.## ## ## ## ##");
            Console.WriteLine(); //123 456.65 43 21

            Console.WriteLine("{0:000 000 000.000 000 000}", d); // 000 123 456, 654 321 000
            #endregion

            #region Настройки региональных стандартов системы
            Console.ReadKey(); Console.Clear();
            // Замечание
            // В зависимости от настроек языкового стандарта программы
            // выводимые символы могут отличаться.
            Console.WriteLine();
            var date = new DateTime(2023, 06, 22, 21, 11, 51);
            Console.WriteLine(date);

            Console.ReadLine(); // если надо можно настроить
            Console.WriteLine($"{date:HH:mm}");
            Console.WriteLine($"{date:yyyy-MM-dd}");
            Console.WriteLine($"{date:yy.MM.dd}");
            Console.WriteLine($"{date:dd.MM.yyyy}");
            #endregion
        }
    }
} 