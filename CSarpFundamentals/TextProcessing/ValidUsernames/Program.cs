using System;
using System.Text;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ");
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                string password = text[i];


                if (password.Length >= 3 && password.Length <= 16)
                {
                    bool IsValid = true;
                    for (int j = 0; j < password.Length; j++)
                    {
                        char symbol = password[j];

                        if (!(char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_'))
                        {
                            IsValid = false;
                        }
                    }
                    if (IsValid)
                    {
                        sb.AppendLine(password);
                    }

                }

            }
            Console.WriteLine(sb);
        }
    }
}
