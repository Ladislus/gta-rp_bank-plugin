﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCommon.Entity
{
    /// <summary>
    /// Transaction bancaire
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Type de transaction
        /// </summary>
        public TransactionType Type { get; set; }

        /// <summary>
        /// Montant de la transaction
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Date et heure de la transaction
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Source de la transaction (PlayerId)
        /// </summary>
        public long Source { get; set; }

        /// <summary>
        /// Receveur de la transaction (PlayerId)
        /// </summary>
        public long Target { get; set; }

        /// <summary>
        /// Compte source
        /// </summary>
        public Account SourceAccount { get; set; }

        /// <summary>
        /// Compte cible
        /// </summary>
        public Account TargetAccount { get; set; }

        public Transaction()
        {

        }

        public Transaction(long id, TransactionType type, int amount, DateTime date, long source, long target, Account sourceAccount, Account targetAccount)
        {
            Id = id;
            Type = type;
            Amount = amount;
            Date = date;
            Source = source;
            Target = target;
            SourceAccount = sourceAccount;
            TargetAccount = targetAccount;
        }
    }
}