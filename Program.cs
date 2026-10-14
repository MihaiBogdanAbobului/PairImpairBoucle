namespace PairImpairBoucle;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes
         * Demandez à l'utilisateur un nombre
         * Dites à l'utilisateur si le nombre fourni est pair ou impair
         * Demandez à l'utilisateur s'il veut proposer un autre nombre
         *  On lui permet de le faire lorsqu'il entre "y". Dans les autres cas, on termine le programme
         */

        int answer = 0;

        do
        {
            Console.WriteLine("Entrez Un Nombre Entier");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer % 2 == 0)
            {
                Console.WriteLine("Le nombre est pair");
            }
            else
            {
                Console.WriteLine("Le nombre est impair");
            }
            Console.WriteLine("Voulez Vous Réessayer");

        } while (Console.ReadLine() =="y");
        Console.WriteLine("Bismillah c'est les tenebres !!");
    }
}
