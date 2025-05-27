namespace EspacioCalculadora
{
    public class Calculadora
    {
         private double dato=0;

         public void Sumar(double termino)
         {
            dato+=termino;   
         }
         
        void Restar(double termino)
        {
            dato-=termino;
        }
        void Multiplicar(double Termino){
            
        }
        void Dividir(double Termino){}
        void Limpiar(){}
        public double GetResultado()
        {
            return dato;
        }

    }
}