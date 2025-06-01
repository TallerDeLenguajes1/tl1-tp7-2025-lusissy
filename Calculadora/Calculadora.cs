namespace EspacioCalculadora
{
    public class Calculadora
    {
         private double dato=0;

         public void Sumar(double termino)
         {
            dato+=termino;   
         }
         
        public void Restar(double termino)
        {
            dato-=termino;
        }
        public void Multiplicar(double Termino){
            dato=dato*Termino;
        }
        public void Dividir(double Termino){
            if(Termino!=0){
                dato=dato/Termino;
            }else {
                Console.WriteLine("No se puede dividir en 0");
            }
        }
        public void Limpiar(){
             dato = 0;
        }
        public double Resultado
        {
            get { return dato; }
        }


    }
}