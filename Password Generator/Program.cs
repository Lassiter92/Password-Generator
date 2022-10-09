namespace Password_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string upperCase = "ABCDEFGHIJKALMNOPRSTQuWXYZ";
            string lowerCase = "abcdefghijklmnoprstquwxyz";
            string numbers = "0123456789";
            string specialSigns = ".,/\\;'!@#$%^&*()";

            int howManySigns = 0;
            int howManyGeneretedPasswords;

            Random rnd = new Random();

            int randomNumberToChooseWhatStringTypeUse;
            int randomNumberToChooseSignFromString;
            

            Console.WriteLine("Witaj w genereatorze haseł");
            Console.WriteLine("Wybierz ile znaków ma zawierać hasło");

            howManySigns = int.Parse(Console.ReadLine());
            char[] generatedPassword  = new char[howManySigns];

            Console.WriteLine("Wybierz ile haseł wygenerować:");

            howManyGeneretedPasswords = int.Parse(Console.ReadLine());

            for(int i = 0; i < howManyGeneretedPasswords; i++) //pętla do tworzenia określonej ilości haseł
            {
                for (int j = 0; j < howManySigns; j++)      // petla do wpisywania znaków do tablicy o określonej wielkości
                {
                    randomNumberToChooseWhatStringTypeUse = rnd.Next(0, 3); // losuje liczbę do switch, który rodzaj znaku wybrać

                    switch(randomNumberToChooseWhatStringTypeUse)   // w zalezności od wylosowanej liczby wybierany jest inny rodzaj znaku
                    {
                        case 0:     //losowe wielkie litery
                            randomNumberToChooseSignFromString = rnd.Next(0, upperCase.Length);     
                            generatedPassword[j] = upperCase[randomNumberToChooseSignFromString];
                            break;

                        case 1:     //losowe male litery
                            randomNumberToChooseSignFromString = rnd.Next(0, lowerCase.Length);
                            generatedPassword[j] = lowerCase[randomNumberToChooseSignFromString];
                            break; 

                        case 2:     //losowe cyfry
                            randomNumberToChooseSignFromString = rnd.Next(0, numbers.Length);
                            generatedPassword[j] = numbers[randomNumberToChooseSignFromString];
                            break;

                        case 3:     //losowe znaki specjalne
                            randomNumberToChooseSignFromString = rnd.Next(0, specialSigns.Length);
                            generatedPassword[j] = specialSigns[randomNumberToChooseSignFromString];
                            break;

                    }
                    Console.Write(generatedPassword[j]);
                }
                Console.WriteLine();
            }
        }
    }
}