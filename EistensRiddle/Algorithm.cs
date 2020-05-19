using System;
using System.Collections.Generic;
using System.Text;

namespace EistensRiddle
{
    public static class Algorithm
    {   

        public static string IsHouseCorrect(int answer, House quiz)
        {
            House value;

            if (answer == 1) value = House.House1;
            else if (answer == 2) value = House.House2;
            else if (answer == 3) value = House.House3;
            else if (answer == 4) value = House.House4;
            else value = House.House5;

            if (value == quiz) return "success";
            else return "failed";
        }

        public static string IsColorCorrect(int answer, Color quiz)
        {
            Color value;

            if (answer == 1) value = Color.blue;
            else if (answer == 2) value = Color.green;
            else if (answer == 3) value = Color.red;
            else if (answer == 4) value = Color.white;
            else value = Color.yellow;

            if (value == quiz) return "success";
            else return "failed";
        }

        public static string IsNationalityCorrect(int answer, Nationality quiz)
        {
            Nationality value;

            if (answer == 1) value = Nationality.Brit;
            else if (answer == 2) value = Nationality.Dane;
            else if (answer == 3) value = Nationality.German;
            else if (answer == 4) value = Nationality.Norwegian;
            else value = Nationality.Swede;

            if (value == quiz) return "success";
            else return "failed";
        }

        public static string IsDrinkCorrect(int answer, Drink quiz)
        {
            Drink value;

            if (answer == 1) value = Drink.beer;
            else if (answer == 2) value = Drink.coffee;
            else if (answer == 3) value = Drink.milk;
            else if (answer == 4) value = Drink.tea;
            else value = Drink.water;

            if (value == quiz) return "success";
            else return "failed";
        }

        public static string IsCigarreteCorrect(int answer, Cigarette quiz)
        {
            Cigarette value;

            if (answer == 1) value = Cigarette.Blends;
            else if (answer == 2) value = Cigarette.BlueMaster;
            else if (answer == 3) value = Cigarette.Dunhill;
            else if (answer == 4) value = Cigarette.PallMall;
            else value = Cigarette.Prince;

            if (value == quiz) return "success";
            else return "failed";
        }

        public static string IsPetCorrect(int answer, Pet quiz)
        {
            Pet value;

            if (answer == 1) value = Pet.birds;
            else if (answer == 2) value = Pet.cats;
            else if (answer == 3) value = Pet.dogs;
            else if (answer == 4) value = Pet.fish;
            else value = Pet.horses;

            if (value == quiz) return "success";
            else return "failed";
        }

    }
}
