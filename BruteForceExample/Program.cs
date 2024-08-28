using System.Text.RegularExpressions;

namespace BruteForceExample
{
    public class Program
    {
        public static string Password = "";
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Lösenord (Minst 6 tecken. Lösenordet måste innehålla minst en stor bokstav, minst ett nummer och minst ett specialtecken): ");
                Password = Console.ReadLine();
                
            } while (!IsPasswordValid(Password));
        }

        public static bool IsPasswordValid(string password)
        {
            if (password.Length < 6)
            {
                Console.WriteLine("Lösenordet måste vara minst 6 tecken långt.");
                return false;
            }

            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                Console.WriteLine("Lösenordet måste innehålla minst en stor bokstav.");
                return false;
            }

            if (!Regex.IsMatch(password, "[0-9]"))
            {
                Console.WriteLine("Lösenordet måste innehålla minst en siffra.");
                return false;
            }
            if (!Regex.IsMatch(password, "[^a-zA-Z0-9]"))
            {
                Console.WriteLine("Lösenordet måste innehålla minst ett specialtecken.");
                return false;
            }
            return true;
        }

    }
}