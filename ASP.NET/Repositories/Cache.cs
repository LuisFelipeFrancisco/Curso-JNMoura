using System;
using System.Runtime.Caching;

namespace Repositories
{
    internal class Cache
    {
        private static readonly ObjectCache cache = MemoryCache.Default; // MemoryCache.Default: Obtém o objeto MemoryCache padrão.

        public static object Get(string chave)
        {
            return cache.Get(chave); // Retorna o objeto armazenado em cache para a chave especificada.
        }

        public static void Set(string chave, object valor, int minutos)
        {
            CacheItemPolicy policy = new CacheItemPolicy(); // CacheItemPolicy: Define políticas de remoção de cache para itens adicionados ao cache de memória.
            policy.AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(minutos); // TimeSpan.FromMinutes: Retorna um TimeSpan que representa um número especificado de minutos.
            cache.Set(chave, valor, policy); // Adiciona um objeto ao cache de memória com políticas de remoção de cache opcionais e informações de rastreamento especificadas.
        }

        public static void Set(string chave, object valor)
        {
            cache.Set(chave, valor, null); // Sobrecarga do método Set que não recebe o parâmetro policy. Nesse caso, o objeto é armazenado em cache sem políticas de remoção de cache.
        }

        public static void Remove(string chave)
        {
            cache.Remove(chave); // Remove o objeto armazenado em cache para a chave especificada.
        }
    }
}
