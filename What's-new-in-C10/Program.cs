// C# 10 - GLOBAL USING
//global using Newtonsoft.Json; //Portée globale du newtonsoft = accessible dans la class person

//Struct C#10 
namespace cs10_structs 
{

    struct PersonStruct
    {
        public string name { get; set; }
        public int id { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var p = new PersonStruct() { name = "toto", id = 5 };
            Console.WriteLine(p);
        }
    }
}
