using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variaveis
            string[] r = new string[50];
            #endregion
            #region Tutorial
            Console.Write("Olá antes de começarmos gostaria de explicar algumas coisas: \n1. o texto será mostrado em partes \n2. para avançar basta pressionar qualquer tecla");
            Console.ReadKey();
            Console.Write("\n \nViu? é facil\nbom na proxima tela vou mostrar o sistema de escolhas\npara selecionar a sua resposta basta escolher entre a opção 1, 2 ou 3\ne pressinar qualquer tecla");
            Console.ReadKey();
            do
            {
                Console.Write("\n\nO que você é? \n1) Garoto \n2) Garota\n3) Dinossauro\n\n");
                r[1] = Console.ReadLine();
            }
            while (r[1] != "1" && r[1] != "2" && r[1] != "3");
            if (r[1] == "1")
            {
                Console.Write("Olha que facil agora sei que você é um garoto\nessa informação é util para o jogo? Não!!");
            }
            else
                if (r[1] == "2")
                {
                    {
                        do
                        {
                            Console.Write("Olha que facil agora sei que você é uma garota\nessa informação é util para o jogo? Não!!\n\nporem agora tenho outra pergunta, você está solteira?, sim ou não?");
                            r[1] = Console.ReadLine();
                            r[1] = r[1].ToUpper();
                        }
                        while (r[1] != "SIM" && r[1] != "NÃO" && r[1] != "NAO");
                    }

                    if (r[1] == "SIM")
                    {
                        Console.Write("\nInteressante, contate os criadores desse jogo \npara tirarmos algumas duvidas importantes :D");
                    }
                    else if (r[1] == "NÃO" || r[1] == "NAO")
                    {
                        Console.Write("\né uma pena, bom vaza daqui, vai logo jogar o jogo , xô xô");
                    }
                }
                else
                {
                    Console.Write("Então vc é um Dinossauro? Nossa que foda te amo :3");
                }

            Console.ReadKey();
            Console.Write("\n\nBom já terminamos o tutorial\nvamos limpar essa tela e começar o jogo\nDivirta-se :3");
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Começo
            Console.Write("\n\t\t\tQuinta Feira\n\nVocê é um estudante do ensino médio de 16 anos. \nVocê tem um grupo de amigos tão idiotas quanto você. \nE esta em horário de aula.\n\n");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Meu Amigo 'Matt' chegou animado na classe querendo me contar algo\n");
            Console.ReadKey();
            do
            {
                Console.Write("Quero Ouvir? \n1) Sim \n2) Não\n\n");
                r[2] = Console.ReadLine();
            }
            while (r[2] != "1" && r[2] != "2");
            if (r[2] == "2")
            {
                Console.Write("Digo que não quero ouvir as besteiras de sempre, \nmas ele fala mesmo assim\n");
                Console.ReadKey();
            }
            Console.Write("\nMatt: Cara ouvi um boato sobre uma casa abandonada aqui perto, \nque tal passarmos o final de semana lá com o pessoal? \nJá falei com eles, e eles gostaram da ideia\n");
            do
            {
                Console.Write("\nQuero ir? \n1) Sim \n2) Não\n\n");
                r[3] = Console.ReadLine();
            }
            while (r[3] != "1" && r[3] != "2");
            if (r[3] == "1")
            {
                Console.Write("Fico animado com a ideia, e digo que vou");
                Console.Write("\nApós a aula vou ao mercado comprar mantimentos para o fim de semana");
            }
            else if (r[3] == "2")
            {
                Console.Write("Digo que estou ocupado e não tenho interesse em ir");
            }
            #endregion
            #region Linha 1 - Casa Com Amigos
            if (r[3] == "1")
            {
                Console.Clear();
                Console.Write("\n\t\t\tSexta Feira\n\n");
                Console.Write("Chegando o `grande dia`, arrumei minha mochila,\ne fui me encontrar com o pessoal em frente a tal casa abandonada. \nAo chegarmos lá nos surpreendemos pelo estado de destruição da casa\n");
                Console.Write("Me pergunto como nunca tinha há notado ali-.. \n\nJhon corta meu pensamento sugerindo entrarmos na casa \nachamos uma porta escondida atrás de uma pilha de sacos de lixo. \nApós tirarmos os sacos, e Jhon chuta a porta a abrindo. \n\nPercebo que mesmo Matt sendo quem sugeriu a idéia é o último a entrar na casa. \nMe pergunto porque ele está com medo mesmo estando em um grupo de cinco pessoas.");
                Console.ReadKey();
                Console.Write("\n\nApós entrarmos notamos que o interior é totalmente diferente do que vimos do lado de fora, \ntoda a casa está impecável, limpa, e até mobiliada. \n\nAo olhar pra Matt percebo que ele está desesperado. \nAntes que eu possa dizer algo ele começa a quase gritar ofegando. \nMat: Temos que sair daqui!");
                Console.ReadKey();
                Console.Clear();
                do
                {
                Console.Write("\n\nTento acalma-lo? \n1)Sim \n2)Não\n");
                r[4] = Console.ReadLine();
                }
                while (r[4] != "1" && r[4] != "2");
                if (r[4] == "1")
                {
                Console.Write("Cara relaxa a porta está bem ali atrás\n");
                Console.ReadKey();
                }
                Console.Write("\nBianca: CADE A PORTA??? \na porta já não está mais lá \nBarbara: Talvez seja em outro lugar \nBianca: É IMPOSSÍVEL ACABAMOS DE ENTRAR");
                Console.Write("\n\nMatt sussurra: Droga é igual aos boatos...");
                Console.ReadKey();
                do
                {
                    Console.Write("\n\nQuestionar? \n1)Sim \n2)Não\n");
                    r[5] = Console.ReadLine();
                }
                while (r[5] != "1" && r[5] != "2");
                if (r[5] == "1")
                {
                    Console.Write("\nEi eu ouvi isso, do que está falando? \nos boatos não eram apenas de uma casa abandonada?");
                }
                else if (r[5] == "2")
                {
                    Console.Write("John: Ei eu ouvi o que você disse, acho bom ir abrindo a boca.. \nse não quiser que eu a feche ela pra sempre..");
                }
                Console.Write("\n\nMatt: Tá... o boato que contei não era o completo na verdade...");
                Console.Write("\n\nMatt para de falar de repente... \no vemos cuspindo sangue enquanto se ajoelha dando gemidos de dor, \ntudo que podemos ver é uma tesoura gigante cravada em seu peito \nlogo percebemos a figura feminina atrás de Matt \nela sorri de forma aterrorizante sem tirar os olhos de nós");
                Console.ReadKey();
                Console.Clear();
                do
                {
                    Console.Write("\n\nO que farei? \n1)Ficar \n2)Correr\n");
                    r[6] = Console.ReadLine();
                }
                while (r[6] != "1" && r[6] != "2");
                if (r[6] == "1")
                {
                    Console.Write("John tenta lutar contra ela, \nenfurecido por ter seu namorado morto ele a ataca");
                    Console.Write("\nela chuta o corpo de Matt em cima de John de forma violenta, \npodemos ve-la cravando a tesoura na garganta de John, \n\n...você ve a cena da cabeça dele caindo no chão e rolando até seu pé");
                    Console.Write("\n\nComeço a correr");
                }
                do
                {
                    Console.Write("\n\nOlho para trás? \n1)Sim \n2)Não\n");
                    r[7] = Console.ReadLine();
                }
                while (r[7] != "1" && r[7] != "2");

                if (r[7] == "1")
                {
                    Console.Write("Olho para trás e vejo a Bianca paralisada de medo");
                    Console.Write("\npuxo ela a forçando a correr comigo, \nEscapando por pouco de um golpe da tesoura");
                    Console.Write("\n\nProcuramos por uma saída");
                    Console.Write("\nEncontro uma janela e consigo passar por ela com a ajuda de Bianca");
                    Console.Write("\nEscapamos de lá, porém, nunca mais vimos aquela casa novamente nem Barbara..");
                    Console.Write("\n\nVocê Sobreviveu! :D");
                    Console.ReadKey();
                    return;
                }
                else if (r[7] == "2")
                {
                    Console.Write("Subo as escadas e entro na primeira porta que vejo");
                    Console.Write("\nde lá posso ouvir os gritos agonizantes de Bianca");
                    do
                    {
                        Console.Write("\n\nVoltar e ver o que houve? \n1)Sim \n2)Não\n");
                        r[8] = Console.ReadLine();
                    }
                    while (r[8] != "1" && r[8] != "2");
                }
                if (r[8] == "1")
                {
                    Console.Write("Vejo o rosto da figura... era a Barbara, \nEla está estripando a Bianca com a tesoura, \n\ntudo que vejo é aquele sorriso aterrorizante ");
                    Console.Write("\tERROR");
                    Console.ReadKey();
                    for (int i = 1; i < 300; i++)
                    {
                        Console.Write("123142134218372139812739218332173218732189371893721983721983721398739817393271398273189371298372198382139281732983173982137219");
                    }
                    Console.Write("\nz\nA vejo caminhando lentamente em minha direção\nela vem arrastando a tesoura que ainda pinga o sangue de meus amigos..");
                    Console.ReadKey();
                    for (int i2 = 1; i2 < 300; i2++)
                    {
                        Console.Write("Eu morri EU MORRI EU morri eu MORRI eu m0rri eu morr1 EU m0rr1 Eu MoRrI E U M O R R I UE MORRI e2 m2130 easter egg moda foca eu morri Eu MOrri");
                    }
                    Console.ReadKey();
                    Console.Write("Final DokiDoki");
                    return;
                }
                else if (r[8] == "2")
                {
                    Console.Write("Começo a correr desesperadamente a procura de uma saída");
                    Console.Write("\nApós correr por toda a casa, vejo que não há uma saída.. \n\ncomo última opção corro em direção a porta de entrada, \nvou para cima da figura correndo e dou um soco em sua mandíbula a quebrando... \nfoi uma péssima ideia, penso: ela está bem mais assustadora agora..  \nela sorri e fico paralisado de medo... Eu morri...");
                    Console.ReadKey();
                    return;
                }
            }
            
            Console.ReadKey();
            #endregion
            #region Linha 2 e 3 - Casa Sem Amigos Parte 1 / Policial
            if (r[3] == "2")
            {
                Console.Clear();
                Console.Write("Matt Anota algo em um pedaço de papel e me entrega,\nMatt: Caso você mude de ideia... \nele sai correndo trás dos otros indo ate a tal casa");
                Console.ReadKey();
                Console.Write("\n\n\tSegunda Feira\n\n");
                Console.Write("Meus amigos não vieram a aula, \no professor pulou eles na chamada, \nenviei mensagens porém eles não respondem, \n\npreocupado após a aula vou até a casa da Bianca, \nme supreendo ao ouvir a mãe dela dizer: \nnão conheço nenhuma Bianca, tenho apenas uma filha chamada Gabriela... \nvolto para casa confuso.");
            }
            do
            {
                Console.Write("\n\nO que faço? \n1)Vou até a casa \n2)Vou até a policia\n");
                r[9] = Console.ReadLine();
            }
            while (r[9] != "1" && r[9] != "2");
            if (r[9] == "1")
            {
                Console.Write("Me recordo do papel que Matt me deu e o leio, \ndescubro o endereço da casa e vou até lá");
                Console.Write("\nao entrar noto que o interior é completamente diferente do lado de fora, \na casa esta toda em perfeito estado, limpa e até mobilhada");
                Console.Write("\nme deparo com uma enorme mancha de sangue no chão, \npreocupado vou a procura de meus amigos");
                Console.ReadKey();
                Console.Clear();
                r[12] = "1"; 
            }
            else if (
                r[9] == "2")
            {
                Console.Write("ligo para a policia e explico a situação");
                Console.Write("\nEntrego o endereço e decidem me acompanhar até lá, \nao chegar no endereço me surpreendo vendo que o mesmo levava para um lixão, \no policial fica com raiva e diz sobre não ser legal fazer a polícia perder tempo ");
                Console.Write("\nO policial me pede o nome completo dos meus amigos para pesquisar");
                Console.ReadKey();
                Console.Clear();
                do
                {
                    Console.Write("\n\nEntrego os nomes? \n1)Sim \n2)Não\n");
                    r[10] = Console.ReadLine();
                }
                while (r[10] != "1" && r[10] != "2");
                if (r[10] == "1")
                {
                    Console.Write("Ele saca o telefone e liga para alguém, \nApós alguns minutos desliga e volta a atenção a mim");
                    Console.Write("\nPolicial: Não existe nenhum registro destes nomes, \nvocê terá que me acompanhar até a delegacia");
                }
                else if (r[10] == "2")
                {
                    Console.Write("Policial: A então você é engraçadinho, \nalém de me fazer vir até aqui atoa se recusa a cooperar. \nEle liga para os meus pais");
                    Console.Write("\nEle insiste novamente em saber os nomes e eu resolvo falar,\napós falar com os meus pais ele decide me levar para a delegacia");
                }

                Console.Write("\n\nAo chegar na delegacia encontro meus pais e uma pessoa estranha, \nessa pessoa se apresenta como um psicologo chamado Fred, \nFred me questiona do porque de eu ter inventado aquelas coisas");
                do
                {
                    Console.Write("\n\nO que faço? \n1)Fico em silencio \n2)Falo a verdade\n");
                    r[11] = Console.ReadLine();
                }
                while (r[11] != "1" && r[11] != "2");
                if (r[11] == "1")
                {
                    Console.Write("Fred: Já que você não pretende falar...\naVou creditar que o seu caso de Esquizofrenia esteja pior do que eu esperava");
                }
                else if (r[11] == "2")
                {
                    Console.Write("Digo que não inventei nada, \ne insisto em minha história\ndigo que enquanto perdemos tempo aqui meus amigos podem estar em perigo");
                }

                Console.Write("\nSou considerado esquizofrênico e me internam..  \nnunca mais vejo meus amigos, \n\nAgora passo meus dias trancado em uma sala no hospício...");
                Console.Write("Final Ruim");
                Console.ReadKey();
                return;

            }
            
            #endregion 
            #region Linha 2 - Casa Sem Amigos Parte 2
            if (r[12] == "1")
            do
            {
                Console.Write("\n\nPor onde vou? \n1)Subir Escadas \n2)Seguir pelo corredor\n");
                r[13] = Console.ReadLine();
            }
            while (r[13] != "1" && r[13] != "2");
            Console.Write("Após andar por um tempo você encontra Barbara, \nEla esta desesperada contando sobre o Matt ter sido assassinado, \nE também sobre os outros terem fugido, e se perdidos por aí, \nEla parece muito feliz por te-lo encontrado.. \nLogo vocês saem em busca dos outros.");
            Console.Write("\nEnquanto andam pelo lugar, você encontra um pedaço de jornal.");
            do
            {
                Console.Write("\n\nLer? \n1)Sim \n2)Não\n");
                r[14] = Console.ReadLine();
            }
            while (r[14] != "1" && r[14] != "2");
            if (r[14] == "1")
            {
                Console.Write("No jornal há uma notícia que diz o seguinte: \nMais relatos levam a população a acreditar na maldição das ga-... \nvocê é interrompido por algo...");
                Console.Write("Você sente uma dor muito forte em sua barriga.. \nA ultima coisa que vê é Barbara... \nEla esta arrancando uma tesoura enorme de sua barriga... \nVocê sente suas entranhas caindo pra fora de seu corpo... Você morreu...");
                Console.ReadKey();
                return;
            }
            else if (r[14] == "2")
            {
                Console.Write("Você ignora o papel o jogando novamente no chão, \nVocê continua acompanhando Barbara, \nAo tentar abrir uma certa porta... \nVocê percebe que Barbara parece um pouco desconfortável...\nBarbara: eu já os procurei ai...' ");
                Console.ReadKey();
                Console.Clear();
                do
                {
                    Console.Write("\n\nAbrir a porta? \n1)Sim \n2)Não\n");
                    r[15] = Console.ReadLine();
                }
                while (r[15] != "1" && r[15] != "2");

                if (r[15] == "2")
                {
                    Console.Write("Continuo andando com ela \noto que já demos a volta na casa inteira e não encontramos nada\nNem nossos amigos nem a saída.. \nEla sequer parece preocupada com isso...");
                    Console.Write("\nVou até aquela porta que não havia aberto.. \nEntro lá rapidamente");
                }
                    Console.Write("Ao abrir a porta tudo que você ve é... \nA pilha de corpos mutilados dos seus amigos... \nBarbara: Não queria que você tivesse visto isso...");
                    Console.Write("\nRecuo tropeçando em um dos corpos, \nvejo ela se aproximar com uma tesoura gigante em minha direção...");
                    Console.Write("\nBarbara: Você irá se juntar a eles \n...você morreu..");
                    Console.ReadKey();
                    return;           
            }
            #endregion
        }
    }
}