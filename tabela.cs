using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_sistema_sinuca
{
    class tabela: time
    {
        public List<time> times = new List<time>();

        public string nome_tabela;
        public string descricao;
        public int maior_pontuacao;
        public string regras;

        public tabela(string n, string d, int p, string r)
        {
            nome_tabela = n;
            descricao = d;
            maior_pontuacao = p;
            regras = r;
        }

        public tabela()
        {

        }

        public void Add_time(string nome, string j1, string j2)
        {
            if(times.Count() > 9)
            {
                Console.WriteLine("Lista completa com 10 times");
                return;
            }
            time t = new time();
            t.set_nome_time(nome);
            t.set_jogador1(j1);
            t.set_jogador2(j2);
            t.set_pontuacao(0);
            times.Add(t);
        }

        public void Print()
        {
            var objetos = times.OrderByDescending(o => o.get_pontuacao()).ToList();

            Console.WriteLine("{0,25} {1,25} {2,25} {3,25}", "nome time", "jogador 1","jogador 2","pontuacao");
            foreach (var time in objetos)
            {
                Console.WriteLine("{0,25} {1,25} {2,25} {3,25}", time.get_nome_time(), time.get_jogador1(), time.get_jogador2(), time.get_pontuacao());
                //Console.WriteLine( + "\t\t" +  + "\t\t" +  + "\t\t     " +  + "\n");
            }
        }



        public void add_pontuacao(int t)
        {
            if(times[t].get_pontuacao() > maior_pontuacao)
            {
                Console.WriteLine(times[t].get_nome_time() + "Ganhou!!!");
                Print();
                return;
            }
            times[t]++;
        }

        public int len()
        {
            return times.Count()-1;
        }
    }

    class lista_tabela : tabela
    {
        public List<tabela> tabelas = new List<tabela>();

        public void add_tabela(string n, string d, int p, string r)
        {
            tabela aux = new tabela(n,d,p,r);
            tabelas.Add(aux);
        }

        public void escolhe_tabela()
        {
            int i = 0;
            foreach (var tabela in tabelas)
            {
                Console.WriteLine(i++ +" - "+ tabela.nome_tabela);
            }
            Console.Write("numero: ");
            int escolhe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0,70}", "=====  " + tabelas[escolhe].nome_tabela + "  =====");
            tabelas[escolhe].Print();
        }

        public int indice()
        {
            return tabelas.Count() - 1;
        }
    }

}
