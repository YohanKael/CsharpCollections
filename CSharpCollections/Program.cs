namespace CSharpCollections
{
    class Program
    {


        static void Main(string[] args)
        {
            string aulaIntro = "Introdução as Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com conjuntos";

            //List<string> aulas = new List<string>()
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            List<string> aulas = new List<string>();

            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando); 
            aulas.Add(aulaSets);

            Imprimir(aulas);

            Console.WriteLine("A primeira aula é " + aulas[0]);
            Console.WriteLine("A primeira aula é " + aulas.First());
            Console.WriteLine("A primeira aula é " + aulas.Last());


            Console.WriteLine("A ultima aula é " + aulas[aulas.Count - 1]);


            aulas[0] = "Trabalhando com listas";
            Imprimir(aulas);

            Console.WriteLine("A Primeira aula 'Trabalhando' é: " + aulas.First(aula => aula.Contains("Trabalhando")));
            
            Console.WriteLine("A Ultima aula 'Trabalhando' é: " + aulas.Last(aula => aula.Contains("Trabalhando")));
            
            Console.WriteLine("A Primeira aula 'Conclusão' é: " + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

            aulas.Reverse();
            Imprimir(aulas);

            aulas.Reverse();
            Imprimir(aulas);

            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);

            aulas.Add("Conclusão");
            Imprimir(aulas);

            aulas.Sort();
            Imprimir(aulas);

            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);

            List<string> clone = new List<string>(aulas);
            Imprimir(clone);

            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);
        }

        private static void Imprimir(List<string> aulas)
        {
            aulas.ForEach(aula => Console.WriteLine(aula));

            //for (int i = 0; i < aulas.Count; i++) 
            //{
            //    Console.WriteLine(aulas[i]);
            //}
            //foreach (var aula in aulas) 
            //{
            //    Console.WriteLine(aula);
            //}
        }

        //        //string[] aulas = new string[]
        //        //{
        //        //    aulaIntro,
        //        //    aulaModelando,
        //        //    aulaSets
        //        //};

        //        string[] aulas = new string[3];
        //        aulas[0] = aulaIntro;
        //        aulas[1] = aulaModelando;
        //        aulas[2] = aulaSets;

        //        Imprimir(aulas);

        //        Console.WriteLine(aulas[0]);
        //        Console.WriteLine(aulas[aulas.Length -1]);

        //        aulas[0] = "Trabalhando com Arrays";
        //        Imprimir(aulas);

        //        Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas, aulaModelando));
        //        Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

        //        Array.Reverse(aulas);
        //        Imprimir(aulas);

        //        Array.Reverse(aulas);
        //        Imprimir(aulas);

        //        Array.Resize(ref aulas, 2);
        //        Imprimir(aulas);

        //        Array.Resize(ref aulas, 3);
        //        Imprimir(aulas);

        //        aulas[aulas.Length - 1] = "Conclusão";
        //        Imprimir(aulas);

        //        Array.Sort(aulas);
        //        Imprimir(aulas);

        //        string[] copia = new string[2];
        //        Array.Copy(aulas, 1, copia, 0, 2);
        //        Imprimir(copia);

        //        string[] clone = aulas.Clone() as string[];
        //        Imprimir(clone);

        //        Array.Clear(clone, 1, 2);
        //        Imprimir(clone);

        //    }

        //    private static void Imprimir(string[] aulas)
        //    {
        //        //foreach (var aula in aulas)
        //        //{
        //        //    Console.WriteLine(aula);
        //        //}
        //        for (int i = 0; i < aulas.Length; i++)
        //        {
        //            Console.WriteLine(aulas[i]);
        //        }
        //    }
        //}
    }
}
