using System;

namespace classes
{
    public abstract class Pagamento
    {
        private DateTime data;

        protected float valor;

        public string Cancelar(){
            return "";
        }
        public string Desconto(float valor){
            if(valor>20){
                return "Desconto de 50%";
            }
            else{
                return "Sem Desconto";
            }
        }
        public abstract string Desconto(int valor);       
    }
}