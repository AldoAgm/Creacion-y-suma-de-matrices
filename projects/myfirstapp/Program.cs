using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
      
        static void Main(string[] args)
        {
           
        
            bool salir = false;
            int[,] mat = new int[3, 3];
            int[,] rand = new int[3,3];
            int[,] suma = new int [3,3];
            Random numeros = new Random();


            while (!salir){
                
                try
                {
                    Console.WriteLine("1. Crear matriz de 3x3");
                    Console.WriteLine("2. Imprimir Matriz");
                    Console.WriteLine("3. Crear aleatoriua y sumar");
                    Console.WriteLine("4. Salir\n");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        //ingresamos matrices por usuario 
                        case 1:
                        for (int i = 0; i<3; i++){
                            for (int j = 0; j<3; j++){
                                Console.WriteLine("Ingresa la posición ["+(i+1)+","+(j+1)+"]");
                                string linea;
                                linea = Console.ReadLine();
                                mat [i,j] = int.Parse(linea);
                            }
                        }
                        break; 

                        //Imprimimos matriz creada
                       case 2:
                        Console.WriteLine("La matriz creada es:");
                       for(int i = 0; i<3; i++)
                       {
                        for(int j = 0; j<3; j++)
                        {
                            
                            Console.Write(mat[i,j] + " ");
                        }
                        Console.WriteLine();
                       }
                       break;
                        //Creamos matriz random
                       case 3: 
                       for(int i = 0; i<3;i++){
                        for(int j = 0; j<3;j++){
                            rand[i,j] = numeros.Next(1,9);
                        }
                       }
                       //Imprimimos matriz creada
                       Console.WriteLine("Imprimimos matriz Random");
                       for(int i = 0; i<3;i++){
                        for(int j= 0; j<3;j++){
                            Console.Write(rand[i,j] + " ");
                        }
                        Console.WriteLine();
                       }

                       //sumamos matrices creada con random
                       for(int i=0; i<3;i++){
                        for(int j=0;j<3;j++){
                            suma[i,j]= mat[i,j] + rand[i,j];
                        }
                       }
                       Console.WriteLine("La suma es:");
                       //Visualizamos suma
                       for(int i=0; i<3;i++){
                        Console.Write("\n");
                        for(int j = 0; j<3;j++){
                            Console.Write(suma[i,j]+" ");
                        }
                        
                       }
                       Console.WriteLine("\n");
                       break;
                       case 4: 
                       salir = true;
                       break;

                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadLine();
        }
        
    }
}
