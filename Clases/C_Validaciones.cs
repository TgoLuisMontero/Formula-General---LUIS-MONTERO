using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_General___LUIS_MONTERO.Clases
{
    public class C_Validaciones
    {
        //Constructor por defecto...
        public C_Validaciones() { }

        //Metodo para comprobar si una entrada de dato es del tipo entero
        public bool validarNumero(string entrada, out double numero)
        {
            //Validamos la entrada del dato opcion...   
            return double.TryParse(entrada, out numero);//Retornara verdadero si es correcto
                                                        //la entrada y con salida del tipo correcto tambien
        }

        //Metodo valida que 'a' sea siempre distinto de cero.
        public bool EsDistintoDeCero(double numero) => numero != 0;

        //Validar resultado de la raiz
        public bool tieneRaizDeterminada(double a, double b, double c) 
            => (Math.Pow(b, 2) - 4 * a * c) >= 0; //El valor debe ser un entero positivo
                                                  //para continua la ejecucion, debido a que los
                                                  //enteros negativos no tienen raiz determinada


    }
}
