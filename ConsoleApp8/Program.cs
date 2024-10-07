using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;


namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var dbclient = new MongoClient("mongodb://localhost:27017/");
            IMongoDatabase db = dbclient.GetDatabase("mydb");
            var tutorial = db.GetCollection<tutorail>("tutorial");


            var list = tutorial.Find(FilterDefinition<tutorail>.Empty).ToList();

            foreach (var doc in list)
            {
                Console.WriteLine($"Title: {doc.title}, By: {doc.by}");
            }

            Console.WriteLine("Enter title ");

            string title;
            title = Console.ReadLine();
            //Console.WriteLine("Enter title ");

            var m = tutorial.Find(x => x.title == title).FirstOrDefault();
            Console.WriteLine(m.by.ToString());
        }
    }
}
