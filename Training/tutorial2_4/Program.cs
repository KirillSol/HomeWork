namespace tutorial2_4
{
    internal class Program
    {
        static void Main(string[] args)
        { // ПРЕОБРАЗОВАНИЯ ДАННЫХ

            #region ТИПЫ ДАННЫХ
            //sbyte  от -128 до +127
            //short  от -32768 до +32767
            //int  от -2^31 до +2^31-1 >>> от -2 147 483 648 до + 2 147 483 647
            //long  от -2^63 до +2^63-1 >>> от -9 223 372 036 854 775 808 до +9 223 372 036 854 775 807

            //byte  от 0 до 2^8 >>> 255
            //ushort  от 0 до 2^16 >>> 65536
            //uint  от 0 до 2^32-1 >>> 4 294 967 296
            //ulong  от 0 до 2^64 >>> 18 446 744 073 709 551 616

            // Тип float принимает значения От ±1,5 х 10^(-45) до 3,4 x 10^38 точность - 7 цифр (после точки)
            // Тип double принимает значения От до точность - 15 цифр
            // Тип decimal принимает значения От до точность - 28 цифр
            #endregion

            #region НЕЯВНЫЕ ПРЕОБРАЗОВАНИЯ

            byte b = 100;
            int a = b; // All good

            //int i = 10;
            //byte j = i; // Error compilator

            double d = a;

            byte byteValue = 1;
            short shortValue = byteValue; // Неявное приведение byte к short
            int intValue = shortValue; // Неявное приведение short к int
            long longValue = intValue; // Неявное приведение int к long
            double doubleValue = longValue; // Неявное приведение long к double

            char c = 'a';
            int z = c;
            Console.WriteLine(z);   // будет число ибо у символов свои числа
            #endregion

            #region ЯВНОЕ ПРЕОБРАЗОВАНИЕ

            //int i = 300;
            //byte j = i;  // Error

            int i = 300;
            byte j = (byte)i; // ошибки нет, но
            Console.WriteLine($"j = {j}"); // данные потеряны из-за передачи из большего в меньшее

            //double x = 1.2;
            //byte byteValue = x; // Error

            double x = 1.2;
            byte ByteValue = (byte)x; // All good

            int h = (int)x;
            int q = (byte)x; // явное преобр. (byte)x в неявное int q

            #endregion

            #region Парсим! Parse

            string inputString = "2023";
            int IntValue = int.Parse(inputString);
            Console.WriteLine(IntValue); // 2023

            double DoubleValue = double.Parse(inputString);
            Console.WriteLine(DoubleValue); // 2023

            ulong ulongValue = ulong.Parse(inputString);
            Console.WriteLine(ulongValue); // 2023

            byte bytEValue = byte.Parse(inputString);
            Console.WriteLine(bytEValue); // Необработанное исключение:
                                          // Unhandled exception. System.OverflowException:
                                          // Value was either too large or too small for an unsigned byte.
                                          //*Потому что мы хотим из
                                          //Текста 2023 сделать число 2023 которое не влазит в диапазон byte
            #endregion

            #region Convert (данные любого типа в данные любого типа)

            string InputString = "2023";
            //int IntValue = int.Parse(InputString);
            int Inputvalue = Convert.ToInt32(InputString); //выделить int и нажать F1(есть инет) или F12(нет инета)
                                                            //Чтобы определить синоним для Convert
            Console.WriteLine(Inputvalue);


            //double DoubleValue = double.Parse(InputString);
            double Doublevalue = Convert.ToDouble(InputString);
            Console.WriteLine(Doublevalue); // 2023


            //ulong ulongValue = ulong.Parse(InputString);
            ulong Ulongvalue = Convert.ToUInt64(InputString);
            Console.WriteLine(Ulongvalue); // 2023
            #endregion

            #region Типы данных и их синонимы
             //Тип данных     Тип .NET
             //sbyte          System.SByte
             //short          System.Int16
             //int            System.Int32
             //long           System.Int64
             //byte           System.SByte
             //ushort         System.UInt16
             //uint           System.UInt32
             //ulong          System.UInt64
             //float          System.Single
             //double         System.Double
             //bool           System.Boolean
            #endregion
        }

    }
}