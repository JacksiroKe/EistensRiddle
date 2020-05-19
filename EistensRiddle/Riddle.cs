using System;
using System.Collections.Generic;
using System.Text;

namespace EistensRiddle
{
    class Riddle
    {
        static Person person1 = new Person();
        static Person person2 = new Person();
        static Person person3 = new Person();
        static Person person4 = new Person();
        static Person person5 = new Person();

        static int answer;

        static string houses = "\nReply with the appropriate number for the house he lives in.\n"
            + " 1: House #1 \n 2. House #2 \n 3. House #3 \n 4. House #4 \n 5. House #5";

        static string colors = "\nReply with the appropriate number for color of the house he lives in.\n"
            + " 1: Blue \n 2. Green \n 3. Red \n 4. White \n 5. Yellow";

        static string nationality = "\nReply with the appropriate number for his Nationality.\n"
            + " 1: Brit \n 2. Dane \n 3. German \n 4. Norwegian \n 5. Swede";

        static string drinks = "\nReply with the appropriate number for what he drinks.\n"
            + " 1: Beer \n 2. Coffee \n 3. Milk \n 4. Tea \n 5. Water";

        static string cigarettes = "\nReply with the appropriate number for the cigarettes he smokes.\n"
            + " 1: Blends \n 2. BlueMaster \n 3. Dunhill \n 4. Pall Mall \n 5. Prince";

        static string pets = "\nReply with the appropriate number for the pets he keeps.\n"
            + " 1: Birds \n 2. Cats \n 3. Dogs \n 4. Horses \n 5. Fish";

        public static void Solve()
        {
            Console.WriteLine("The Brit lives in the Red house. " + houses);
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine(Algorithm.IsHouseCorrect(answer, House.House3));
            Console.WriteLine();
            Console.WriteLine("The Swede keeps Dogs as pets. " + houses);
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine(Algorithm.IsHouseCorrect(answer, House.House5));
            Console.WriteLine();
            Console.WriteLine("The Dane drinks Tea. " + cigarettes);
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine(Algorithm.IsCigarreteCorrect(answer, Cigarette.Blends));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The owner of the Green house drinks Coffee. " + nationality);
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine(Algorithm.IsNationalityCorrect(answer, Nationality.German));
            Console.WriteLine();
            Console.WriteLine("The person who smokes Pall Mall rears Birds. " + colors);
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine(Algorithm.IsColorCorrect(answer, Color.red));
            Console.WriteLine();
            Console.WriteLine("The owner of the Yellow house smokes Dunhill. " + pets);
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine(Algorithm.IsPetCorrect(answer, Pet.cats));
            Console.WriteLine();
            Console.WriteLine("The man living in the centre house drinks Milk. " + cigarettes);
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine(Algorithm.IsCigarreteCorrect(answer, Cigarette.PallMall));
            Console.WriteLine();
            Console.WriteLine("The man who smokes Blends lives next to the one who keeps Cats. " + houses);
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine(Algorithm.IsHouseCorrect(answer, House.House2));
            Console.WriteLine();
            Console.WriteLine("The man who keeps Horses lives next to the man who smokes Dunhill. " + houses);
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine(Algorithm.IsHouseCorrect(answer, House.House2));
            Console.WriteLine();
            Console.WriteLine("The man who smokes Blue Master drinks Beer. " + houses);
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine(Algorithm.IsHouseCorrect(answer, House.House5));
            Console.WriteLine();
            Console.WriteLine("Who owns the Fish. " + nationality);
            answer = int.Parse(Console.ReadLine());
            Console.WriteLine(Algorithm.IsNationalityCorrect(answer, Nationality.German));
            Console.WriteLine();
        }
    }
}
