namespace Miane_Calculator_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Miane mohasebegar = new Miane();
            mohasebegar.MianeMohaseb();


        }
    }
    public class Miane
    {
        public void MianeMohaseb()
        {
            int[] Araye = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Adad mored nazar ra vared konid");
                Araye[i] = int.Parse(Console.ReadLine());
            }
            int Temp = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Araye[j] > Araye[j + 1])
                    {
                        Temp = Araye[j];
                        Araye[j] = Araye[j + 1];
                        Araye[j + 1] = Temp;
                    }


                }
            }
            int sum = (Araye[5] + Araye[6]) / 2;
            Console.WriteLine(sum);
        }
    }
}