using System;

namespace classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;

        public void Registrar(){
            Console.WriteLine("Registrado");
        }

        public override string Desconto(int valor)
        {
            return "";
        }
    }
}