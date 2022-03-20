//possibilité de mettre un
//namespace What_s_new_in_C10; et retirer un niveau d'indentation
//mais on ne pourra plus utiliser plusieurs namespace au sein d'une meme classe
using Newtonsoft.Json;

namespace What_s_new_in_C10
{
    class Person
    {
        public string? name { get; set; } //string? = string OR nullable
        public int age { get; set; }

        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        //Console.WriteLine("Hello, World!");

        //var p = new Person { name = "toto", age = 5 };
        //var json_p = JsonConvert.SerializeObject(p);
        //Console.WriteLine(json_p);
        //Console.WriteLine(p.GetJson());
    }
}
//pratique extremement rare
namespace What_s_new_in_C102
{
    class Person
    {
        public string? name { get; set; } //string? = string OR nullable
        public int age { get; set; }

        public string GetJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
