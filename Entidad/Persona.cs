using System.Diagnostics;
using System;

namespace Entidad
{
    public class Persona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; } 
        public int Edad { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public decimal ValorApoyo { get; set; }
        public string Modalidad { get; set; }
        public string Fecha { get; set; }
        public decimal Valor { get; set; }

        public void validarValor(){
            if(ValorApoyo == 0 || ValorApoyo > 600000000){
                
            }
            else{
                
            }
        }
    }
}
