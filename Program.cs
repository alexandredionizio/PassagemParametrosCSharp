using System;

namespace PassagemParam
{
    //Goal..: Entender as quatro formas de passar um parâmetro para um método no C#
    //Date..: 09-07-2021
    //Author: Alexandre Dio
    
    public class Program
    {
        //São quatro formas de se passar um parâmetro para um método no C#:
        //• Value
        //• Out
        //• Ref 
        //• Params
        
        static int value;
        static void Main(string[] args)
        {
            //Value
            Console.WriteLine("======= Value ========");
            value = 2;
            MethodValue(value);
            //Mesmo que o valor do parâmetro paramValue tenha sido modificado dentro do método
            //"MethodValue(valor)", essa mudança não ocorreu na Main (que chamou o método). 
            //Isso ocorreu porque o value é um parâmetro apenas de entrada.
            Console.WriteLine("Valor em Main: " + value);
            
            //Out
            Console.WriteLine("======= Out ========");
            value = 5;
            MethodOut(out value);
            Console.WriteLine("Valor em Main: " + value);

            //Ref
            Console.WriteLine("======= Ref ========");
            value = 10;
            MethodRef(ref value);
            Console.WriteLine("Valor em Main: " + value);

            //Params
            Console.WriteLine("======= Params ========");
            Console.WriteLine(Sum(10,10,10,50));
            Console.WriteLine("================");
        }


        //Value: É um parâmetro somente de entrada. Seu valor é passado para a função.
        //Assim qualquer mudança em seu valor é feita na própria função
        //e não é passado ao código que chamou a função.
        static void MethodValue(int paramValue) 
        {
            paramValue = 200;
            //Notem que aqui a saída será de 200
            Console.WriteLine("Valor em MethodValue: " + paramValue);
        }
        
        //Out: É um parâmetro "emissor", ou seja, seu valor  é passado somente de uma função.
        //Ele é criado precedendo o tipo de dado com o modificador out. 
        //Sempre que um parâmetro out é passado, somente a referência da variável é passada para a função.
        static void MethodOut(out int paramValue)
        {
            paramValue = 100;
            Console.WriteLine("Valor em MethodOut: " + paramValue);
        }

        //Ref: É um parâmetro de entrada e saída, o que significa que ele pode passar um valor
        //para uma função ou receber de volta esse valor de uma função. 
        //É criado precedendo um tipo de dado com o modificador ref.
        static void MethodRef(ref int paramValue)
        {
            paramValue += 100;
            Console.WriteLine("Valor em MethodRef: " + paramValue);
        }

        //Params: É muito útil quando o número de argumentos a ser passado é variável.
        //O parâmetro necessita ser um Array (Matriz) unidimensional ou um Jagged Array (Matriz multidimensional).
        static int Sum(params int[] paramNumbers)
        {
            int val = 0;
            foreach (var item in paramNumbers)
            {
                val += item;
            }
            return val;
        }
    }
}
