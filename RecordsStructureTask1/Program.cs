namespace RecordsStructureTask1
{
    internal class Program
    {
        struct Film
        {
            public string title;
            public string certificate;
            public int year;
            public bool beingShown;

            public Film(string title, string certificate, int year, bool beingShown)
            {
                this.title = title;
                this.certificate = certificate;
                this.year = year;
                this.beingShown = beingShown;

            }
        }
        static void Main(string[] args)
        {
            Film hulk = new Film("Hulk", "12A", 2005, false);
            Film ironMan = new Film("Iron Man","12A",2008,false);
            Film antMan = new Film("Ant-Man", "12A", 2015, false);
            Film[] filmCollection = new Film[] { antMan,hulk,ironMan };
            int year = 0;
            int position = 0;

            //  Write the code to do the following
            
            // Loop through the array of films and check for the newest film
            Film newestFilm = filmCollection[0];
            foreach (Film film in filmCollection)
            {
                if (film.year > newestFilm.year)
                {
                    newestFilm = film;
                }
            }
            
            // Produce one output to say the name of the newest film
            Console.WriteLine("The newest film is: " + newestFilm.title);

            // Write the code to update the andMan record to show the film is currently being shown

for (int i = 0; i < filmCollection.Length; i++)
            {
                if (filmCollection[i].title == "Ant-Man")
                {
                    filmCollection[i].beingShown = true;
                    break;
                }
            }

            Console.WriteLine("Ant-Man is now being shown: " + filmCollection[0].beingShown);

            
        }
    }
}
