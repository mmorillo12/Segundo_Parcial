using System;

namespace segundo_parcial_2
{
    class Empleado{
        string[] nombre;
        int[] salario;

        public void Cargar(){
            nombre = new string[5];
            salario = new int[5];
            
            for(int i = 0; i < 5; i++){
            Console.WriteLine("Ingrese nombre: ");
            nombre[i] = Console.ReadLine();
            Console.WriteLine("Ingrese Salario");
            salario[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
            }
        }
        public void SalarioMayor(){
            int mx = salario[0];
            string mxn = nombre[0];
            for(int i = 0; i < 5; i++){
                if(salario[i] > mx){
                mx = salario[i];
                mxn = nombre[i];
                }
            }
            Console.WriteLine("El empleado con el salario mayor es: {0}", mxn);
            Console.WriteLine("Tiene un salario de: {0}", mx);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Empleado em = new Empleado();
            em.Cargar();
            em.SalarioMayor();
        }
    }
}
