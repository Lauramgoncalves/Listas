using System;
using System.Collections.Generic; // adiciona varios tipos de estrutura de dados como  listas, dicionarios, sets e hashTables
using System.Linq; //o Linq é uma biblioteca que consegue fazer Filtragem, remoção,busca de um dado especifico.
using System.Text;
using System.Threading.Tasks;

namespace AprendendoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] clientesArr = new string[10];
            // { }
            //  string[] clientesArr = { "shssj" };


            // tipos nativo ou primitivo do CSharp (int, float, double,  string, char)
            List<string> materiais = new List<string>(); 
            //para criar uma variavel que recebe um valor de outro tipo, sempre tem que usar o new
            // se não colocar new List<string>() fica como = null e o programa não executa
            // está criando uma nova lista e salvando em uma variavel.
            materiais.Add("Caderno");
            materiais.Add("Lapis");
            materiais.Add("Caneta");
            materiais.Add("Estojo");
            materiais.Add("Apontador");
            string materia = "Borracha";
            materiais.Add(materia);


            foreach (string material in materiais)
            {
                Console.WriteLine(material);
            }

           // materiais.RemoveAt(2);// -> Para remover pelo indice.
            //materiais.RemoveAll( material => material == "Caderno" ); // Para remover por um predicado. É uma frase que se passa e o Csharp testa para cada elemento da lista,se for verdadeiro ele remove o elemento. (é mais pesado)


            foreach (string material in materiais)
            {
                Console.WriteLine(material);
            }



            // materiais[1] = "Lapis de cor"; -> para alterar.

            // materiais.Count; -> Para verificar quantos dados tem.
            //Console.WriteLine(materiais[4]);
            

           // string busca = materiais.Find( material => material.Length > 5); // -> muito semelhante com o removeAll, recebe um predicado. (só busca 1 elemento, o primeiro ue ele achar ele exibe).
            List<string> filtrada = materiais.FindAll(material => material.Length > 5); // Retorna todos os elementos com base na condição.
            //Console.WriteLine(busca);
            Console.WriteLine("-----------------");
            foreach (string material in filtrada)
            {
                Console.WriteLine(material);
            }
            Console.ReadLine();

        }
    }
}
    /* quando utilizar arrays? e uando utilizar listas?
     quando não souber o numero exato, (grandes quantidades) utilize a lista.*/
