namespace Fattoriale2
{
    internal class Program
    {
        static int Fattoriale(int n)
        {
            int f = 1;

            while (n > 1)
            {


                f = n * f;
                n = n - 1;


            }

            Console.WriteLine("Il fattoriale e " + f);

            return f;
        }
        static bool Fattoriale2(int n)
        {
            if (n % 2 == 0)
            {

                return true;

            }
            else
            {

                return false;

            }

        }


        static void Main(string[] args)
        {

            int s = 0;

            for (int i = 1; i <= 10; i++) {

                if ( Fattoriale2(i) == true ) {

                s = s + Fattoriale(i);

                }

            }

            Console.WriteLine("La somma dei fattoriali dei num pari fino a 10 e " + s);

        }
    }
}
