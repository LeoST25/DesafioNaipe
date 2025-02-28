﻿using System;

public enum Naipe { Paus = 0, Ouros = 1, Copas = 2, Espadas = 3 }
public enum Valor { As = 1, Valete = 2, Dama = 3, Rei = 4 }

public class Carta
{
    private Naipe naipe;
    private Valor valor;

    public Carta(Naipe n, Valor v)
    {
        naipe = n;
        valor = v;
    }

    public Naipe GetNaipe()
    {
        return naipe;
    }

    public Valor GetValor()
    {
        return valor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Input para escolher a carta desejada
        int valorEscolhido, naipeEscolhido;
        do
        {
            Console.WriteLine("Escolha um valor (1 para Ás, 2 para Valete, 3 para Dama, 4 para Rei):");
            valorEscolhido = int.Parse(Console.ReadLine());
        } while (valorEscolhido < 1 || valorEscolhido > 4);

        do
        {
            Console.WriteLine("Escolha um naipe (0 para Paus, 1 para Ouros, 2 para Copas, 3 para Espadas):");
            naipeEscolhido = int.Parse(Console.ReadLine());
        } while (naipeEscolhido < 0 || naipeEscolhido > 3);

        // Criação da carta escolhida pelo usuário
        Carta cartaEscolhida = new Carta((Naipe)naipeEscolhido, (Valor)valorEscolhido);

        // Exibição da carta escolhida pelo usuário
        string nomeValor = "", nomeNaipe = "";

        switch (cartaEscolhida.GetValor())
        {
            case Valor.As:
                nomeValor = "Ás";
                break;
            case Valor.Valete:
                nomeValor = "Valete";
                break;
            case Valor.Dama:
                nomeValor = "Dama";
                break;
            case Valor.Rei:
                nomeValor = "Rei";
                break;
        }

        switch (cartaEscolhida.GetNaipe())
        {
            case Naipe.Paus:
                nomeNaipe = "Paus";
                break;
            case Naipe.Ouros:
                nomeNaipe = "Ouros";
                break;
            case Naipe.Copas:
                nomeNaipe = "Copas";
                break;
            case Naipe.Espadas:
                nomeNaipe = "Espadas";
                break;
        }

        Console.WriteLine($"Carta escolhida: {nomeValor} de {nomeNaipe}");
    }
}
