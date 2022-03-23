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
    record struct PersonRecordStruct2(string? name, int id); //deconstructor mutable ! ReadOnly pour le rendre immutable
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Struct
            Console.WriteLine("Struct");
            var pa = new PersonStruct() { name = "toto", id = 5 };
            var p0 = pa;
            p0.Afficher();
            //Console.WriteLine(p0 == pa); //interdit
            Console.WriteLine(p0.Equals(pa));
            #endregion

            #region Record
            Console.WriteLine();
            Console.WriteLine("Record");
            var p1 = new PersonRecord() { name = "toto", id = 5 };
            //var p2 = new PersonRecord() { name = "toto", id = 5 };
            
            //p2 va pointer p1 en mémoire
            var p2 = p1;
            p1.name = "titi";
            p1.Afficher();
            Console.WriteLine(p1 == p2);
            #endregion

            #region Record immutable
            Console.WriteLine();
            Console.WriteLine("Record immutable");
            var p5 = new PersonRecord2("Toto",20); 
            var p6 = p5 with { name = "Tata" };
            Console.WriteLine(p5);
            Console.WriteLine(p6);
            Console.WriteLine(p5 == p6);
            #endregion

            #region Record Struct
            Console.WriteLine();
            Console.WriteLine("Record Struct");
            var p3 = new PersonRecordStruct() { name = "toto", id = 5 };
            var p4 = p3;
            p4.Afficher();
            Console.WriteLine(p3 == p4);
            #endregion

            #region Record Struct mutable
            Console.WriteLine();
            Console.WriteLine("Record Struct mutable");
            var p7 = new PersonRecordStruct2("Toto",20); 
            var p8 = p7 with { name = "Tata" };
            p7.name = "Tata";
            Console.WriteLine(p7);
            Console.WriteLine(p8);
            Console.WriteLine(p7 == p8);

            string? name = "Toto";
            //int id = 5;

            (name, var id) = p7;
            Console.WriteLine(p7);
            #endregion

        }
    }
}
