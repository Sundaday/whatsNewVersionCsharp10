// C# 10 - GLOBAL USING
//global using Newtonsoft.Json; //Portée globale du newtonsoft = accessible dans la class person

//Struct C#10 
namespace cs10_structs 
{
    //contrairement aux class qui sont des reference Type, struct est valeur
    struct PersonStruct
    {
        public string name { get; set; }
        public int id { get; set; }

        //surcharge du constructeur
        public PersonStruct()
        {
            name = "Tata";
            id = 0;
        }

        public void Afficher()
        {
            Console.WriteLine("name: " + name + ", id: " + id);
        }
    }

    //record permet de tester toutes les égalitées par valeurs
    //Comparer l'age de deux personnes par exemple
    //Sur une class, nous ne pouvons pas faire cela. On testera si les références sont egale
    record PersonRecord
    {
        public string? name { get; set; }
        public int id { get; set; }
        public void Afficher()
        {
            Console.WriteLine("name: " + name + ", id: " + id);
        }
    }
    //deconstructor immutable
    record PersonRecord2(string? name, int id);

    record struct PersonRecordStruct
    {
        public string? name { set; get; }
        public int id { get; set; }
        public void Afficher()
        {
            Console.WriteLine("name: " + name + ", id: " + id);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Struct");
            var pa = new PersonStruct() { name = "toto", id = 5 };
            var p0 = pa;
            p0.Afficher();
            //Console.WriteLine(p0 == pa);
            Console.WriteLine(p0.Equals(pa));

            Console.WriteLine("Record");
            var p1 = new PersonRecord() { name = "toto", id = 5 };
            //var p2 = new PersonRecord() { name = "toto", id = 5 };

            //p2 va pointer p1 en mémoire
            var p2 = p1;
            p1.name = "titi";
            p1.Afficher();
            Console.WriteLine(p1 == p2);
            //Console.WriteLine(p1.Equals(p2));

            Console.WriteLine("Record Struct");
            var p3 = new PersonRecordStruct() { name ="toto", id = 5 };
            var p4 = p3;
            p4.Afficher();
            Console.WriteLine(p3 == p4);

        }
    }
}
