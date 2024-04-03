namespace Generics_Övning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LådaCollection lådacollection = new LådaCollection();

            lådacollection.Add(new Låda(5, 10, 15));
            lådacollection.Add(new Låda(15, 5, 10));
            lådacollection.Add(new Låda(11, 10, 15));
            lådacollection.Add(new Låda(14, 13, 10));
            lådacollection.Add(new Låda(17, 15, 12));

            
            Display(lådacollection);

            lådacollection.Add(new Låda(15,150,15));//Jag använder Add metoden för att lägga till en ny låda

            Console.WriteLine("--------------------------------------------------------");
            lådacollection.Remove(new Låda(15,5,10));//Remove metoden används för att ta bort en befintlig låda ur listan
            Console.WriteLine("Nu har vi lagt till en låda och tagit bort en låda!");
            Display(lådacollection);

            Console.WriteLine("--------------------------------------------------------");

            Låda lådaToCheck = new Låda(15,150,152);//Jag använder contains metoden för att se om det finns en låda med samma mått som jag har angett finns i listan.
            Console.WriteLine($"Finns det en låda med samma mått i våran lista? {lådaToCheck.Höjd}, {lådaToCheck.Längd}, {lådaToCheck.Bredd}?  " + $"{(lådacollection.Contains(lådaToCheck) ? "Ja" : "Nej")}");

            

            
        }

        public static void Display(LådaCollection lådacollection)//Metod som loopar igenom, våran lista med lådor.
        {
            foreach (var låda in lådacollection)
            {
                Console.WriteLine($"\tHöjd: {låda.Höjd}, \tLängd: {låda.Längd}, \tBredd: {låda.Bredd}");
            }
        }
    }
}
