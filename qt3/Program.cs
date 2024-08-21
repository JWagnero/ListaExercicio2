/*-------------------------------------------------------------------
Questão 3: Loja de Poções
•   Contextualização: Em uma loja de poções mágicas, o jogador pode comprar poções que 
    aumentam sua vida, mana ou resistência. O preço das poções é fixo: Vida custa 10 moedas, 
    Mana custa 15 moedas, e Resistência custa 20 moedas. Dependendo da classe do jogador, há 
    um desconto aplicável.
•   Comando: Crie um programa que receba a classe do jogador (Guerreiro, Mago, Paladino), o tipo 
    de poção (Vida, Mana, Resistência), e a qtnd_compra que deseja comprar. Calcule o preço total 
    das poções, aplicando o desconto correspondente:
•   Guerreiro recebe 10% de desconto na compra de poções de Vida.
•   Mago recebe 15% de desconto na compra de poções de Mana.
•   Paladino recebe 20% de desconto na compra de poções de Resistência.
•   Exiba o preço total com e sem desconto.

@Lista: 02 - Condicionais
@Autor: João Wagner
@Data: 21/08/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int classe, pocao, qtnd_compra;
        double desconto = 0, preço_des, preco;

        System.Console.WriteLine("ESCOLHA UMA CLASSE");

        System.Console.WriteLine("1-Guerriro  2-Arqueiro 3-Mago");
        int.TryParse(Console.ReadLine(), out classe);

        switch (classe)
        {
            case 1:
                desconto = 0.9;
                break;
            case 2:
                desconto = 0.85;
                break;
            case 3:
                desconto = 0.8;
                break;
            default:
                break;
        }
        System.Console.WriteLine("Agora escolha sua poção");
        System.Console.WriteLine("1-Vida  2-Mana  3-Resistancia");
        int.TryParse(Console.ReadLine(), out pocao);

        switch (pocao)
        {
            case 1:
                pocao = 10;
                break;

            case 2:
                pocao = 15;
                break;

            case 3:
                pocao = 20;
                break;
        }

        Console.Write("Quantas poções deseja?: ");
        int.TryParse(Console.ReadLine(), out qtnd_compra);

        preco = pocao * qtnd_compra;
        preço_des = preco * desconto;

        if (classe == 1 && pocao == 10 || classe == 2 && pocao == 15 || classe == 3 && pocao == 20)
        {
            Console.WriteLine($"O valor fica de: {preco} e com o desconto fica por: {preço_des}");
        }
        else
        {
            Console.WriteLine($"O valor fica de: {preco} e você não possui direito a um desconto");
        }


        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}