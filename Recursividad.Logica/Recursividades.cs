namespace Recursividad.Logica
{
    public class Recursividades
    {
        public int CalcularFactorial(int num)
        {
            //Caso base o condición de salida

            if (num == 1)
            {
                return 1;
            }

            //Caso general
            return num * CalcularFactorial(num - 1);


        }


    }
}
