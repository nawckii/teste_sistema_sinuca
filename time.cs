using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_sistema_sinuca
{
    class time
    {
        protected string nome_time;
        protected string jogador1;
        protected string jogador2;
        protected int pontuacao;


        public string get_nome_time()
        {
            return nome_time;
        }

        public void set_nome_time(string n)
        {
            nome_time =  n;
        }

        public string get_jogador1()
        {
            return jogador1;
        }

        public void set_jogador1(string n)
        {
            jogador1 = n;
        }

        public string get_jogador2()
        {
            return jogador2;
        }

        public void set_jogador2(string n)
        {
            jogador2 = n;
        }

        public int get_pontuacao()
        {
            return pontuacao;
        }

        public void set_pontuacao(int n)
        {
            pontuacao = n;
        }

        public static time operator ++(time op1)
        {
            op1.pontuacao++;
            return op1;
        }


    }
    
}
