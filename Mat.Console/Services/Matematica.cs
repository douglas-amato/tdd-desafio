namespace Mat.Console.Services
{
    public class Matematica
    {
        public uint CalcularFatorial(uint n)
        {
            uint fatorial = 1;

            if (n > 1)
                fatorial = n * CalcularFatorial(n - 1);

            return fatorial;
        }

        public string VerificarExistenciaTriangulo(int medida1, int medida2, int medida3)
        {
            string existeTriangulo = "Sim";

            if ( !((medida1 > 0 && medida2 > 0 && medida3 > 0) &&
                  (Math.Abs(medida1 - medida2) < medida3 && medida3 < medida1 + medida2 ) &&
                  (Math.Abs(medida1 - medida3) < medida2 && medida2 < medida1 + medida3 ) &&
                  (Math.Abs(medida2 - medida3) < medida1 && medida1 < medida2 + medida3 )) )
                existeTriangulo = "Não";

            return existeTriangulo;
        }
    }
}