using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem jake = new Personagem();
            jake.dragon = "Dragon form!!";
            jake.use = "Jake Long usa...";

            Console.WriteLine(jake.nome);

            Console.WriteLine(jake.idade);

            Console.WriteLine(jake.use);

            Console.WriteLine(jake.dragon);

            Console.WriteLine(jake.Atacar());

        }
    }
}
