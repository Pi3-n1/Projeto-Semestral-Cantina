using System;
using System.Collections.Generic;

namespace Projeto_Semestral_Cantina
{
    public static class PedidoManager
    {
        private static List<string> _pedidosCozinha = new List<string>();
        private static List<string> _pedidosProntos = new List<string>();
        private static readonly object _lock = new object();

        public static void AdicionarPedidoCozinha(List<string> itensPedido)
        {
            lock (_lock)
            {
                var pedidoCompleto = new List<string>();
                pedidoCompleto.Add($"======= PEDIDO {DateTime.Now:HH:mm:ss} =======");
                pedidoCompleto.AddRange(itensPedido);
                pedidoCompleto.Add("----------------------------");
                _pedidosCozinha.AddRange(pedidoCompleto);
            }
            NovoPedidoCozinha?.Invoke();
        }

        public static List<string> ObterPedidosCozinha()
        {
            lock (_lock) { return new List<string>(_pedidosCozinha); }
        }

        public static void AdicionarPedidoPronto(List<string> pedidoPronto)
        {
            lock (_lock)
            {
                _pedidosProntos.AddRange(pedidoPronto);
            }
            NovoPedidoPronto?.Invoke();
        }

        public static List<string> ObterPedidosProntos()
        {
            lock (_lock) { return new List<string>(_pedidosProntos); }
        }

        public static event Action NovoPedidoCozinha;
        public static event Action NovoPedidoPronto;
    }
}