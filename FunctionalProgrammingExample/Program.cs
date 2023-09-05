namespace FunctionalProgrammingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? firstName = GetFirstName();
            string? lastName = GetLastName();
            NameFormat userDefinedNameFormat = GetNameFormat();
            string fullName = CombineFirstAndLastName(firstName, lastName, userDefinedNameFormat);

            OutputFormattedFullName(fullName);
        }

        public enum NameFormat
        {
            FirstCommaLast,
            LastCommaFirst,
            FirstLast,
            LastFirst
        }

        public static string? GetFirstName()
        {
            Console.Write("What is your first name?: ");
            return Console.ReadLine();
        }

        public static string? GetLastName()
        {
            Console.Write("What is your last name?: ");
            return Console.ReadLine();
        }

        public static NameFormat GetNameFormat()
        {
            Console.WriteLine();

            string[] names = Enum.GetNames(typeof(NameFormat));

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(i + 1 + ": " + names[i]);
            }

            Console.Write("Please select a name format from the list above: ");
            string? userSelection = Console.ReadLine();

            bool result = int.TryParse(userSelection, out int intUserSelection);

            if (result == true && intUserSelection >= 1 && intUserSelection <= names.Length)
            {
                return (NameFormat)(intUserSelection - 1);
            }
            else
            {
                return NameFormat.LastCommaFirst;
            }
        }

        public static string CombineFirstAndLastName(string? firstName, string? lastName, NameFormat nameFormat)
        {
            string fullName = "";

            if (nameFormat == NameFormat.FirstCommaLast) fullName = firstName + ", " + lastName;
            if (nameFormat == NameFormat.LastCommaFirst) fullName = lastName + ", " + firstName;
            if (nameFormat == NameFormat.FirstLast) fullName = firstName + " " + lastName;
            if (nameFormat == NameFormat.LastFirst) fullName = lastName + " " + firstName;

            return fullName;
        }

        public static void OutputFormattedFullName(string fullName)
        {
            Console.WriteLine("");
            Console.WriteLine("Your full name is: " + fullName);
        }
    }
}