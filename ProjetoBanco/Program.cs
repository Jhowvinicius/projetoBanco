﻿using System;



namespace ProjetoBanco
{
    public class Program
    {
        private static readonly Banco banco = new Banco();
        private static readonly Conta contaDestino;

        static Program()
        {
            var cidade = new Cidade("Jundiaí", "SP");

            var endereco = new Endereco("Rua Gen. Osório", "Centro", "13219-000", 100, cidade);

            var cliente = new Cliente("Grillo", "12312312312", new DateTime(1985, 7, 2), endereco);

            contaDestino = banco.AbrirConta(cliente);
        }


        static void Main(string[] args)
        {
            try
            {
                var cidade = new Cidade("Jundiaí", "SP");

                var endereco = new Endereco("Rua Uncila Lorencini", "Terra da Uva", "13214-680", 151, cidade);

                var cliente = new Cliente("Ricardo", "12312312312", new DateTime(1985, 7, 2), endereco);

                var contaRicardo = banco.AbrirConta(cliente);

                contaRicardo.Depositar(2500);

                contaRicardo.Sacar(350);

                contaRicardo.TirarExtrato();

                contaRicardo.Tranferir(1, 1, 1200);

                contaRicardo.TirarExtrato();

                contaDestino.TirarExtrato();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            Console.ResetColor();
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.WriteLine("pressione qualquer tecla para sair...");
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
