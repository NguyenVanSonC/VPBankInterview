using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace VP.BackgroundJobManager
{
    public class Transaction : Entity<Guid>
    {
        public Transaction()
        {
            CreationTime = DateTime.Now;
        }

        /// <summary>
        /// Số thẻ
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Số tiền
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Mô tả
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Thời gian giao dịch
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}
