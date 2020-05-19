namespace EistensRiddle
{
    public class Person
    {

        public Person() { }
        public House House { get; set; }
        public Color Color { get; set; }

        public Nationality Nationality { get; set; }
        public Drink Drink { get; set; }
        public Cigarette Cigarette { get; set; }
        public Pet Pet { get; set; }

    }

    public enum House
    {
        House1 = 1,
        House2 = 2,
        House3 = 3,
        House4 = 4,
        House5 = 5
    }

    public enum Color
    {
        blue = 1,
        green = 2,
        red = 3,
        white = 4,
        yellow = 5
    }

    public enum Nationality
    {
        Brit = 1,
        Dane = 2,
        German = 3,
        Norwegian = 4,
        Swede = 5
    }

    public enum Drink
    {
        beer = 1,
        coffee = 2,
        milk = 3,
        tea = 4,
        water = 5
    }

    public enum Cigarette
    {
        Blends = 1,
        BlueMaster = 2,
        Dunhill = 3,
        PallMall = 4,
        Prince = 5
    }

    public enum Pet
    {
        birds = 1,
        cats = 2,
        dogs = 3,
        horses = 4,
        fish
    }
}
