using System;
using System.Collections.Generic;
using static teste_sistema_sinuca.time;

namespace teste_sistema_sinuca
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int numero_tabela = r.Next(5)+1;
            lista_tabela lista = new lista_tabela();

            for(int i = 0; i < numero_tabela; ++i)
            {
                string nome = "Tabela " + i.ToString();
                lista.add_tabela(nome, "descricao", 10, "regras");
                insert(lista);
                soma_pontuacao(lista);
            }
            lista.escolhe_tabela();

        }

        static void insert(lista_tabela lista)
        {
            string[] times = { "Anjos do Inferno", "Alta voltagem.", "Insurgentes.", "Os Letais.", "Os Pulverizadores.", "Os Selvagens.", "Soldados do Campo.", "Os Terminadores." };
            string[] nomes_femino = { "Amanda", "Catarina", "Laís", "Ana Cecília Lara", "Antonela", "Clara", "Larissa", "Aurora" };
            string[] nomes_masculino = { "Miguel.", "Davi.", "Gabriel.", "Arthur.", "Lucas.", "Matheus.", "Pedro.", "Guilherme" };
            Random R = new Random();
            int numero_times = R.Next(10)+1;
            for(int i = 0; i < numero_times; ++i)
            {
                lista.tabelas[lista.indice()].Add_time(times[R.Next(8)], nomes_femino[R.Next(8)], nomes_masculino[R.Next(8)]);
            }
            
        }

        static void soma_pontuacao(lista_tabela lista)
        {
            Random r = new Random();
            int pontucao = r.Next(10);
            for (int i = 0; i < pontucao; ++i) 
            {
                int aux = r.Next(lista.tabelas[lista.indice()].len());
                lista.tabelas[lista.indice()].add_pontuacao(aux);
            }
        }

        
    }
}
