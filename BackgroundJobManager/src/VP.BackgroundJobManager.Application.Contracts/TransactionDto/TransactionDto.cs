using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Auditing;

namespace VP.BackgroundJobManager
{
    /// <summary>
    /// Dto sử dụng lấy thông tin giao dịch
    /// </summary>
    public class TransactionDto : EntityDto<Guid>
    {
        /// <summary>
        /// Số thẻ
        /// </summary>
        [Index(0)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Số tiền
        /// </summary>
        [Index(1)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Mô tả
        /// </summary>
        [Index(2)]
        public string Description { get; set; }

        /// <summary>
        /// Thời gian giao dịch
        /// </summary>
        [Index(3)]
        public DateTime CreationTime { get; set; }
    }
}
