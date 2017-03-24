﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Itens
{
    public string name;
    public Itens next = null;

    public Itens(string name)
    {
        this.name = name;
    }
}

namespace ListaDeInventario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma fruta(Abacaxi, Limao, Maca, Tomate, Melancia, Pera, Pessego, Laranja, Banana, Antoanne)");
            string texto = Console.ReadLine();

            Itens Fruta1 = new Itens("Abacaxi");
            Itens Fruta2 = new Itens("Limao");
            Itens Fruta3 = new Itens("Maca");
            Itens Fruta4 = new Itens("Tomate");
            Itens Fruta5 = new Itens("Melancia");
            Itens Fruta6 = new Itens("Pera");
            Itens Fruta7 = new Itens("Pessego");
            Itens Fruta8 = new Itens("Laranja");
            Itens Fruta9 = new Itens("Banana");
            Itens Fruta10 = new Itens("Antoanne");

            Fruta1.next = Fruta2;
            Fruta2.next = Fruta3;
            Fruta3.next = Fruta4;
            Fruta4.next = Fruta5;
            Fruta5.next = Fruta6;
            Fruta6.next = Fruta7;
            Fruta7.next = Fruta8;
            Fruta8.next = Fruta9;
            Fruta9.next = Fruta10;

            Itens currentfruta = Fruta1;
            int id = 0;

            while (currentfruta != null)
            {
                id++;

                if (texto != null && texto == currentfruta.name)
                {
                    Console.WriteLine("Acertô mizeravi, id: " + id);
                }
            
                else if (currentfruta == null)
                {
                    Console.WriteLine("Não encontrei, cara, foi mal");
                    id = 0;
                }
                currentfruta = currentfruta.next;

            }

            Console.ReadKey();
        }
    }
}