/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
*   Contextualização: Em um jogo de RPG, o jogador precisa inserir
    as informações básicas do personagem antes de começar a aventura.
*   Comando: Crie um programa que receba o nome, idade, nível inicial,
    classe, e raça do personagem e exiba esses dados no console.
@Lista: 02 - Condicionais
@Autor: João Wagner
@Data: 21/08/2024
---------------------------------------------------------------------*/

using System;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        int classe, defesa, penalidade = 0, defID = 0, pen = 0, adequada = 0;

        System.Console.WriteLine("ESCOLHA UMA CLASSE");

        System.Console.WriteLine("1-Guerriro  2-Arqueiro 3-Mago");
        int.TryParse(Console.ReadLine(), out classe);

        switch (classe)
        {
            case 1:
                defID = 50;
                pen = 20;
                break;

            case 2:
                defID = 30;
                pen = 10;
                break;

            case 3:
                defID = 20;
                pen = 40;
                break;

            default:
                break;
        }

        System.Console.WriteLine("Quanto de defesa você tem?");
        int.TryParse(Console.ReadLine(), out defesa);

        System.Console.WriteLine("qual sua penalidade?");
        int.TryParse(Console.ReadLine(), out pen);

        if (defesa > defID)
        {
            adequada++;
        }


        if (penalidade < pen)
        {
            adequada++;
        }

        if (adequada == 2)
        {
            Console.Clear();
            Console.WriteLine("Armadura é ideal a sua classe");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Armadura não é ideal a classe");
        }

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}