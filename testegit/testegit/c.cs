using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Program
    {
        struct Funcionarios
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public float Salario { get; set; }
            public string Cargo { get; set; }
        };
        static void Main(string[] args)
        {
            Funcionarios[] funcionario = new Funcionarios[3];
            
            int i = 0;
            bool loop;
            bool loop2;
            loop = funcionario[i].Idade >= 18;
            loop2 =(funcionario[2].Cargo ==  "senior" &&
funcionario[2].Cargo == "pleno" &&
                        funcionario[2].Cargo == "junior");

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine($"digite o nome do funcionario {i + 1}:");
                funcionario[i].Nome = Console.ReadLine();
                if (funcionario[i].Nome == "testecodigo")
                {
                    funcionario[0].Nome = "random";
                    funcionario[1].Nome = "random";
                    funcionario[2].Nome = "random";

                    funcionario[0].Idade = 19;
                    funcionario[1].Idade = 19;
                    funcionario[2].Idade = 19;

                    funcionario[0].Cargo = "senior";
                    funcionario[1].Cargo = "senior";
                    funcionario[2].Cargo = "senior";

                    funcionario[0].Salario = 1000;
                    funcionario[1].Salario = 2000;
                    funcionario[2].Salario = 3000;

                    if (funcionario[0].Salario > funcionario[1].Salario && funcionario[0].Salario > funcionario[2].Salario)
                    {
                        Console.WriteLine("o funcionario com maior salario foi: " + funcionario[0].Nome);

                        Console.WriteLine("idade do funcionario: " + funcionario[0].Idade);
                        Console.WriteLine("cargo do funcionario: " + funcionario[0].Cargo);
                        Console.WriteLine("salario do funcionario: " + funcionario[0].Salario);

                    }
                    if (funcionario[1].Salario > funcionario[0].Salario && funcionario[1].Salario > funcionario[2].Salario)
                    {
                        Console.WriteLine("o funcionario com maior salario foi: " + funcionario[1].Nome);

                        Console.WriteLine("idade do funcionario: " + funcionario[1].Idade);
                        Console.WriteLine("cargo do funcionario: " + funcionario[1].Cargo);
                        Console.WriteLine("salario do funcionario: " + funcionario[1].Salario);
                    }
                    if (funcionario[2].Salario > funcionario[0].Salario && funcionario[2].Salario > funcionario[1].Salario)
                    {
                        Console.WriteLine("o funcionario com maior salario foi: " + funcionario[2].Nome);

                        Console.WriteLine("idade do funcionario: " + funcionario[2].Idade);
                        Console.WriteLine("cargo do funcionario: " + funcionario[2].Cargo);
                        Console.WriteLine("salario do funcionario: " + funcionario[2].Salario);
                    }
                    return;

                }
                
            }
            do
            {
                for (i = 0; i < 3; i++)
                {
                    Console.WriteLine($"digite a idade do funcionario {i + 1}");
                    funcionario[i].Idade = int.Parse(Console.ReadLine());

                    if (funcionario[i].Idade < 18)
                    {
                        Console.WriteLine("idade invalida, tente novamente!");
                        i = 0;

                    }

                }


            } while (loop);
            do
            {
                for (i = 0; i < 3; i++)
                {
                    Console.WriteLine($"digite o cargo do funcionario {i + 1}");
                    funcionario[i].Cargo = Console.ReadLine();

                    if (funcionario[i].Cargo != "senior" &&
                        funcionario[i].Cargo != "pleno" &&
                        funcionario[i].Cargo != "junior")
                    {
                        Console.WriteLine("cargo invalido!");
                        i = 0;
                    }
                    

                }
            } while (loop2);
            for (i = 0; i < 3; ++i)
            {
                Console.WriteLine($"digite o salario do funcionario {i + 1}");
                funcionario[i].Salario = float.Parse(Console.ReadLine());

            }
            if (funcionario[0].Salario > funcionario[1].Salario && funcionario[0].Salario > funcionario[2].Salario)
            {
                Console.WriteLine("o funcionario com maior salario foi: "+ funcionario[0].Nome);
                
                Console.WriteLine("idade do funcionario: "+ funcionario[0].Idade); 
                Console.WriteLine("cargo do funcionario: "+ funcionario[0].Cargo); 
                Console.WriteLine("salario do funcionario: "+ funcionario[0].Salario); 
               
            }
            if (funcionario[1].Salario > funcionario[0].Salario && funcionario[1].Salario > funcionario[2].Salario)
            {
                Console.WriteLine("o funcionario com maior salario foi: " + funcionario[1].Nome);
                
                Console.WriteLine("idade do funcionario: "+ funcionario[1].Idade);
                Console.WriteLine("cargo do funcionario: "+ funcionario[1].Cargo);
                Console.WriteLine("salario do funcionario: "+ funcionario[1].Salario);
            }
            if (funcionario[2].Salario > funcionario[0].Salario && funcionario[2].Salario > funcionario[1].Salario)
            {
                Console.WriteLine("o funcionario com maior salario foi: " + funcionario[2].Nome);
                
                Console.WriteLine("idade do funcionario: "+ funcionario[2].Idade);
                Console.WriteLine("cargo do funcionario: "+ funcionario[2].Cargo);
                Console.WriteLine("salario do funcionario: "+ funcionario[2].Salario);
            }
        }
    }
}