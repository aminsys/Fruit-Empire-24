using Banana_King.Models;

namespace Banana_King.Services
{
    public static class BananaService
    {
        static List<Banana> Bananas { get; }
        static int nextId = 12;

        static BananaService()
        {
            Bananas = new List<Banana>
            {
                new Banana { Id = 1,
                SortName = "Apple Banana",
                Description = "Apple bananas are native to Southeast Asia and got their name as their flavor has a hint of apple.",
                Price = 10.99M,
                Img = "https://www.liveeatlearn.com/wp-content/uploads/2023/08/apple-banana-650x650.jpg"},

                new Banana { Id = 2,
                SortName = "Barangan Banana",
                Description = "hey are a small and sweet variety that is both popular in Malaysia and exported by them",
                Price = 9.50M,
                Img = "https://www.liveeatlearn.com/wp-content/uploads/2023/08/barangan-banana-650x433.jpg"},

                new Banana{ Id = 3,
                SortName = "Blue Java Banana",
                Description = "They are grown primarily in Southeast Asia, but also Hawaii. They are said to taste something like vanilla ice cream",
                Price = 15.75M,
                Img = "https://www.liveeatlearn.com/wp-content/uploads/2023/08/blue-java-banana-650x433.jpg"},

                new Banana{ Id = 4,
                SortName = "Bluggoe Banana",
                Description = "They are fairly cold resistant, so they are also grown in the United States though we import most of the bananas we eat.",
                Price = 25.95M,
                Img = "https://www.liveeatlearn.com/wp-content/uploads/2023/08/bluggoe-banana-650x433.jpg"},

                new Banana{ Id = 5,
                SortName = "Burro Banana",
                Description = "Burro bananas are native to Central and South America, but mostly grown in Mexico.",
                Price = 5.95M,
                Img = "https://www.liveeatlearn.com/wp-content/uploads/2023/08/burro-banana-650x433.jpg"},

                new Banana{ Id = 6,
                SortName = "Cavendish Banana",
                Description = "They are the delicious dependable bananas we use as both snacks and cooking.",
                Price = 34.95M,
                Img = "https://www.liveeatlearn.com/wp-content/uploads/2023/08/cavendish-banana-650x433.jpg"},

                new Banana{ Id = 7,
                SortName = "Cooking Bananas",
                Description = "They are grown across Central and South America where they are a dietary staple.",
                Price = 7.95M,
                Img = "https://www.liveeatlearn.com/wp-content/uploads/2023/08/cooking-banana-650x325.jpg"},

                new Banana{ Id = 8,
                SortName = "Dwarf Jamaican Red Banana",
                Description = "Dwarf Jamaican bananas are a small but sweet banana grown in Jamaica.",
                Price = 58.50M,
                Img = "https://www.liveeatlearn.com/wp-content/uploads/2023/08/dwarf-jamaican-red-banana-650x433.jpg"},

                new Banana{ Id = 9,
                SortName = "Fehi Banana",
                Description = "Also known as Fe’i bananas, they are grown on several Pacific islands, but primarily French Polynesia.",
                Price = 70.90M,
                Img = "https://www.liveeatlearn.com/wp-content/uploads/2023/08/fehi-banana-650x433.jpg"},

                new Banana{ Id = 10,
                SortName = "Giant Cavendish",
                Description = "Also known as William Bananas, these are a larger version of the Cavendish.",
                Price = 17.90M,
                Img = "https://www.liveeatlearn.com/wp-content/uploads/2023/08/giant-cavendish-650x433.jpg"},

                new Banana{ Id = 11,
                SortName = "Gros Michel Banana",
                Description = "Gros Michel Bananas are also known as the Big Mike.",
                Price = 11.99M,
                Img = "https://www.liveeatlearn.com/wp-content/uploads/2023/08/gros-michel-banana-650x433.jpg"}
            };
        }

        public static List<Banana> GetAll() => Bananas;

        public static Banana? Get(int id) => Bananas.FirstOrDefault(p => p.Id == id);

        public static void Add(Banana banana)
        {
            banana.Id = nextId++;
            Bananas.Add(banana);
        }

        public static void Delete(int id)
        {
            var banana = Get(id);
            if(banana is null)
            {
                return;
            }
            Bananas.Remove(banana);
        }
    }
}
