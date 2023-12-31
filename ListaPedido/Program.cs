﻿public class Pedido
{
    public string Cliente { get; set; }
    public string Produto { get; set; }
    public int Qtd { get; set; }
}


internal class ListaPedido
{
    static Queue<Pedido> filaPedidos = new Queue<Pedido>();
    static List<Pedido> pedidoConcluido = new List<Pedido>();

    static void Main(string[] args)
    {
        bool showMenu = true;
        while (showMenu)
        {
            showMenu = MainMenu();
        }
    }
    static bool MainMenu()
    {
        Console.WriteLine($"<---------------------------->");
        Console.WriteLine($"Digite 1 para incluir pedido:");
        Console.WriteLine($"Digite 2 para concluir pedido");
        Console.WriteLine($"Digite 3 para Listar pedidos pendentes");
        Console.WriteLine($"Digite 4 para Listar pedidos Concluidos");
        var linha = Console.ReadLine();
        if (linha == "1")
        {
            addPedido();
            return true;
        }
        else if (linha == "2")
        {
            ConcluirPedido();
            return true;
        }
        else if (linha == "3")
        {
            ListarPedidoPendente();
            return true;
        }
        else if (linha == "4")
        {
            ListarPedidoConcluidos();
            return true;
        }


        else
        {
            return true;
        }
    }

    public static void ConcluirPedido()
    {
        if (filaPedidos.Count > 0)
        {
            Pedido pedidoAtual = filaPedidos.Dequeue();
            Console.WriteLine($"<---------------------------->");
            Console.WriteLine($"Finalizandopedido do {pedidoAtual.Cliente} com o {pedidoAtual.Produto}(s)...");
           
            pedidoConcluido.Add(pedidoAtual);
        }
        else {
            Console.WriteLine($"<---------------------------->"); 
            Console.WriteLine("Sem pedido para Concluir"); }
    }

    public static void addPedido()
    {
        Console.WriteLine($"<---------------------------->");
        Console.WriteLine($"Digite seu nome");
        var Nome = Console.ReadLine();
        Console.WriteLine($"Lista de produtos");
        Console.WriteLine($"Pizza");
        Console.WriteLine($"Lanche");
        Console.WriteLine($"Pastel");
        Console.WriteLine($"Digite o produto");
        var produto = Console.ReadLine();
        Console.WriteLine("digite a quantidade");
        var qtd = Console.ReadLine();

        Pedido pedido = new Pedido
        {
            Cliente = Nome,
            Produto = produto,
            Qtd = Int16.Parse(qtd)
        };

        filaPedidos.Enqueue(pedido);
        Console.WriteLine($"Pedido de {qtd} {Nome}(s) adicionado à fila.");
    }

    public  static void ListarPedidoPendente()
    {
        if(filaPedidos.Count() > 0)
        {
            foreach( var pedido in filaPedidos)
            {
                Console.WriteLine($"<---------------------------->");
                Console.WriteLine($"pedido com o Cliente:{pedido.Cliente}");
                Console.WriteLine($"produto :{pedido.Produto}");
                Console.WriteLine($"quantidade {pedido.Qtd}");
            }
        }
        else
        {
            Console.WriteLine("Lista Vasia");
        }        
    }
    public static void ListarPedidoConcluidos()
    {
        if (pedidoConcluido.Count() > 0)
        {
            foreach (var pedido in pedidoConcluido)
            {
                Console.WriteLine($"pedido com o Cliente:{pedido.Cliente}");
                Console.WriteLine($"produto :{pedido.Produto}");
                Console.WriteLine($"quantidade {pedido.Qtd}");
            }
        }
        else
        {
            Console.WriteLine("Lista Vasia");
        }
    }
}