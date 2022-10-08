using System;

namespace BussinessLogicLayer.Consoles
{
    public class ConsoleWrapper
    {
        public static T ReadType<T>(string message = "")
        {
            bool isSuccess = false;
            while (isSuccess == false)
            {
                try
                {
                    Console.Write(message);
                    return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                }
                catch
                {
                    ClearLastLine();
                }
            }
            return default;
        }

        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
        }
    }
}
