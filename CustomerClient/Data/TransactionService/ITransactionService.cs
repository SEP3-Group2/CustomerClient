using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerClient.Models;

namespace CustomerClient.Data
{
    interface ITransactionService
    {
        Task AddTransactionAsync(Transaction transaction);

        Task<int> GetLastTransactiontID();
    }
}
