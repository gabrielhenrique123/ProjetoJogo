using System;

namespace filmes
{
    class Program
    {
        static void Main(string[] args)

        {
            int a1, a2, itens;
            ConsoleKeyInfo i;
            string op, ac, op1;






            Console.WriteLine("==================================================");
            Console.WriteLine("BEM VINDO  A ESSE MARAVILHOSO MUMNDO DE AVENTURAS");
            Console.WriteLine("==================================================");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("BOT :  OLA SEJA BEM VINDO MEU CARO AMIGO MEU NOME É  BOT ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("BOT : BEM VAMOS COMEÇAR A TREINAR");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("BOT : VAMOS TREINAR NESSE BONECO SELECIONE ATACAR OU POUPAR ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  (__)");
            Console.WriteLine("  (oo)");
            Console.WriteLine("    (O)");
            Console.WriteLine("  _||_   ");
            Console.WriteLine("/ __ / ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("=================MENU DE BATALHA===================");
            Console.WriteLine("||                                                 ||");
            Console.WriteLine("||  1-ATACAR                    4-POUPAR           ||");
            Console.WriteLine("||                                                 ||");
            Console.WriteLine("||  2-ITENS                     5-FUGIR            ||");
            Console.WriteLine("||                                                 ||");
            Console.WriteLine("||  3-AÇOES                     6-INFO             ||");
            Console.WriteLine(" ==================================================");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            if (a1 == 1)

            {
                Console.WriteLine(" SEU ATAQUE CASOU 10 DE DANO");
            }

            if (a1 == 4)
            {
                Console.WriteLine("VOCE POUPOU O NPC E ELE FUGU");
            }

            else if (a1 == 2)

            {
                Console.WriteLine("AINDA NAO ESTA NA HORA SELECIONA UM DOS OUTROS");
                Console.WriteLine("=================MENU DE BATALHA===================");
                Console.WriteLine("||                                                 ||");
                Console.WriteLine("||  1-ATACAR                    4-POUPAR           ||");
                Console.WriteLine("||                                                 ||");
                Console.WriteLine("||  2-ITENS                     5-FUGIR            ||");
                Console.WriteLine("||                                                 ||");
                Console.WriteLine("||  3-AÇOES                     6-INFO             ||");
                Console.WriteLine(" ==================================================");
                a1 = Convert.ToInt32(Console.ReadLine());
            }

            else if (a1 == 3)

            {
                Console.WriteLine("AINDA NAO ESTA NA HORA SELECIONA UM DOS OUTROS");
                Console.WriteLine("=================MENU DE BATALHA===================");
                Console.WriteLine("||                                                 ||");
                Console.WriteLine("||  1-ATACAR                    4-POUPAR           ||");
                Console.WriteLine("||                                                 ||");
                Console.WriteLine("||  2-ITENS                     5-FUGIR            ||");
                Console.WriteLine("||                                                 ||");
                Console.WriteLine("||  3-AÇOES                     6-INFO             ||");
                Console.WriteLine(" ==================================================");
                a1 = Convert.ToInt32(Console.ReadLine());
            }

            else if (a1 == 5)

            {
                Console.WriteLine("AINDA NAO ESTA NA HORA SELECIONA UM DOS OUTROS");
                Console.WriteLine("=================MENU DE BATALHA===================");
                Console.WriteLine("||                                                 ||");
                Console.WriteLine("||  1-ATACAR                    4-POUPAR           ||");
                Console.WriteLine("||                                                 ||");
                Console.WriteLine("||  2-ITENS                     5-FUGIR            ||");
                Console.WriteLine("||                                                 ||");
                Console.WriteLine("||  3-AÇOES                     6-INFO             ||");
                Console.WriteLine(" ==================================================");
                a1 = Convert.ToInt32(Console.ReadLine());
            }

            else if (a1 == 6)

            {
                Console.WriteLine("AINDA NAO ESTA NA HORA SELECIONA UM DOS OUTROS");
                Console.WriteLine("=================MENU DE BATALHA===================");
                Console.WriteLine("||                                                 ||");
                Console.WriteLine("||  1-ATACAR                    4-POUPAR           ||");
                Console.WriteLine("||                                                 ||");
                Console.WriteLine("||  2-ITENS                     5-FUGIR            ||");
                Console.WriteLine("||                                                 ||");
                Console.WriteLine("||  3-AÇOES                     6-INFO             ||");
                Console.WriteLine(" ==================================================");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                a1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("");
            }




            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" INCRIVEL VOCE APRENDE RAPIDO ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" AGORA VOU ENSINAR VOCE A ABRIR SEU INVENTARIO");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("PRECIONE (E) PARA ABRIR SEU INVENTARIO");
            Console.Write("");
            Console.WriteLine("");
            i = Console.ReadKey();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("===================INVERNTARIO====================");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("==================================================");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("BOT : UAU INFELIZMENTE VOCE NAO TEM ITENS :( ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("BOT : MAS EU TENHO UM ITEM E IREI LHE ENTREGAR");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("BOT : AQUI PEGUE ESSA (PEDRA FILOSOFAL) E A EQUIPE-A");
            Console.WriteLine("");
            Console.WriteLine("PEDRA FILOSOFAL ADQUIRIDA");
            Console.WriteLine("");
            Console.WriteLine("BOT : AGORA EQUIPEA EM SEU INVENTARIO ");

            Console.WriteLine("");
            i = Console.ReadKey();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("===================INVERNTARIO====================");
            Console.WriteLine("|| -1 Pedra filosofal                           ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("==================================================");

            Console.WriteLine("");
            Console.WriteLine("BOT : SELECIONE O ITEM INSERINDO O SEU NUMERO EM SEU INVENTARIO");
            itens = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("(DESEJA EQUIPAR ESSE ITEM?)");
            Console.WriteLine("");
            Console.WriteLine("(S/N)");
            Console.WriteLine("");
            Console.WriteLine("");
            op = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            if (op == "S")
            {
                Console.WriteLine("*ITEM EQUIPADO COM SUCESSO");
            }

            else if (op == "N")
            {
                Console.WriteLine("ITEM GUARDADO");
            }
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("BOT : MUITO BEM  VOÇE CONCLUIO SEU TUTORIAL AMIGO");
            Console.WriteLine("");
            Console.WriteLine("BOT : AGORA VOÇE PODE CONTINUAR EM FRENTE ");
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");





            Console.WriteLine(" - VA PARA O CASTELO DO REINO PARA OBTER INFORMAÇOES DO MONSTRO QUE ATERRORIZA A CIDADE - ");
            Console.WriteLine("");
            Console.WriteLine("*ANDANDO.....");
            Console.WriteLine("");
            Console.WriteLine("*ANDANDO.....");
            Console.WriteLine("");
            Console.WriteLine("*ANDANDO.....");
            Console.WriteLine("");
            Console.WriteLine("*ANDANDO.....");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("* VOCE CHEGOU AO SEU DESTINO *");
            Console.WriteLine("");
            Console.WriteLine(" DESEJA ENTRAR NO CASTELO PARA FALAR COM O REI?");
            ac = Console.ReadLine();

            if (ac == "S")
            {
                Console.Write("Loading.....");
            }

            else if (ac == "N")
            {
                Console.WriteLine("OKAY VOLTE AQUI MAS TARDE");
            }


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Clear();



            Console.WriteLine("");
            Console.WriteLine(" REI : OQUE VOCE DESEJA???");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("==================================================");
            Console.WriteLine("||  1- Me fale sobre o monstro                  ||");
            Console.WriteLine("||  2- Nada so vim aqui mesm                    ||");
            Console.WriteLine("||  3- Seu trono                                ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("==================================================");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            a2 = Convert.ToInt32(Console.ReadLine());

            if (a2 == 1)
            {
                Console.WriteLine("REI : O monstro esta em uma cidade aqui por perto ..");
                Console.WriteLine("REI : Ele mata as ovelhas e destroi as plantaçoes daquele lugar");
                Console.WriteLine("REI: As pessoas estao desesperadas por morarem la e ter um monstro..");
                Console.WriteLine(".....");
            }
            else if (a2 == 2)
            {
                Console.WriteLine("REI : A okay voce veio pela a fama da nossa cozinha real certo? hehehhe");

            }
            else if (a2 == 3)
            {
                Console.WriteLine("REI : Como ousa?!!!!");
            }

            Console.WriteLine("");
            Console.WriteLine("REI :A cidade é bem  perto vc poderia se livrar dele por mim ?");
            Console.WriteLine("(S/N)");
            Console.WriteLine("");
            Console.WriteLine("");
            op1 = Console.ReadLine();

            if (op1 == "S")
            {


                Console.WriteLine("REI : Otimo siga ao norte de nossa cidade e  encontre uma cidade por perto ");
                Console.WriteLine("REI : Voce é muito bom mesmo aqui tome isto ");
                Console.WriteLine("* ESPADA SAGRADA ADQUIRIDA*");




            }
            else if (op1 == "N")
            {
                Console.WriteLine(" A okay..");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" BOT : OLA MEU CARO AMIGO EU QUERIA LHE ENSINAR AGORA QUE AO ABRIR SEU IVENTARIO E SELECIONAR INFO SEM ESTAR EM UMA BATALHA VC PODERA VER AS INFORMACOES DE UM ITEM QUE VC DESEJAR");
            Console.WriteLine("");
            i = Console.ReadKey();


            Console.WriteLine("=================MENU DE BATALHA===================");
            Console.WriteLine("||                                                 ||");
            Console.WriteLine("||  1-ATACAR                    4-POUPAR           ||");
            Console.WriteLine("||                                                 ||");
            Console.WriteLine("||  2-ITENS                     5-FUGIR            ||");
            Console.WriteLine("||                                                 ||");
            Console.WriteLine("||  3-AÇOES                     6-INFO             ||");
            Console.WriteLine(" ==================================================");

            itens = Convert.ToInt32(Console.ReadLine());

            if (itens == 6)

            {
                Console.WriteLine("===================INVERNTARIO====================");
                Console.WriteLine("|| -1 pedra filosofal                           ||");
                Console.WriteLine("|| -2 espada sagrada                            ||");
                Console.WriteLine("||                                              ||");
                Console.WriteLine("||                                              ||");
                Console.WriteLine("||                                              ||");
                Console.WriteLine("||                                              ||");
                Console.WriteLine("==================================================");
                Console.WriteLine("");
                itens = Convert.ToInt32(Console.ReadLine());

                if (itens == 1)
                {
                    Console.WriteLine("- ESSA PEDRA É MUITO PODEROSA E PODE SER UMA FONTE DE ENERGIA ILIMITADA");

                }

                else if (itens == 2)
                {
                    Console.WriteLine("ESSA É UMA ESPADA SAGRADA MUITO AFIADA (DANO: 100)");
                }



            }

            else

            {
                Console.WriteLine("(ESSA ACAO NAO PODE SER FEITA AGORA)");

            }
            Console.WriteLine("");
            Console.WriteLine("BOT : AGORA SELECIONE A ESPADA ");
            Console.WriteLine("===================INVERNTARIO====================");
            Console.WriteLine("|| -1 pedra filosofal                           ||");
            Console.WriteLine("|| -2 espada sagrada                            ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("||                                              ||");
            Console.WriteLine("==================================================");
            Console.WriteLine("");
            itens = Convert.ToInt32(Console.ReadLine());

            if (itens == 2)
            {
                Console.WriteLine("DESEJA EQUIPAR ESSE ITEM? (S/N)");
                op = Console.ReadLine();

                if (op == "S")
                {
                    Console.WriteLine("*ITEM EQUIPADO COM SUCESSO");
                }

                else if (op == "N")
                {
                    Console.WriteLine("ITEM GUARDADO");
                }
            }

            else
            {
                Console.WriteLine(" NAO HÁ MAS ITENS OU OS ITENS QUE HAVIAM JA FORAM EQUIPADOS");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

















        }


    }
}
