using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerClient.Models;

namespace CustomerClient.Data
{
    interface ITransactionProductService
    {
        Task AddTransactionProductAsync(TransactionProduct transactionProduct);
    }
}
