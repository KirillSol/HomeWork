namespace Practice_task_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Соболев Кирилл Сергеевич";
            byte age = 20;
            string eMail = "sobolev_mdf119@mail.ru";
            decimal scoreProgramm = 79M; // баллы на экзаменах всегда целые числа
            decimal scoreMath = 80M;
            decimal scorePhys = 65M;

            string pattern = "Ф.И.О.  {0} \nВозраст: {1} \nEmail: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";
            Console.WriteLine(pattern, fullName, age, eMail, scoreProgramm, scoreMath, scorePhys);
            Console.ReadKey();

            decimal amountScore = scoreProgramm + scoreMath + scorePhys; // сумма балов
            Console.WriteLine($"\nСумма всех баллов: {amountScore}");
            Console.ReadKey();

            decimal averageScore = amountScore / 3; //среднее арифметическое
            string formatedAverage = averageScore.ToString("#.##"); //сокращаем до сотых
            Console.WriteLine($"\nCреднее арифметическое: {formatedAverage}");
            Console.ReadKey();
        }
    }
}
