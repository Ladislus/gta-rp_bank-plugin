﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCommon.Entity
{
    /// <summary>
    /// Actions possédées par le joueur
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// ID du joueur possédant cette action
        /// </summary>
        public long PlayerId { get; set; }

        /// <summary>
        /// ID de l'entreprise de l'action en question
        /// </summary>
        public long CompanyId { get; set; }

        /// <summary>
        /// Nombre d'action
        /// </summary>
        public int Amount { get; set; }

        public Stock()
        {

        }

        public Stock(long id, long playerId, long companyId, int amount)
        {
            Id = id;
            PlayerId = playerId;
            CompanyId = companyId;
            Amount = amount;
        }
    }
}
