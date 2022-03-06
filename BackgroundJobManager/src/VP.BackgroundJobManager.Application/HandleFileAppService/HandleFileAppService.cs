using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace VP.BackgroundJobManager
{
    /// <summary>
    /// Class Service xử lý đọc dữ liệu giao dịch từ file
    /// Created By: NVSon(05/03/2022)
    /// </summary>
    public class HandleFileAppService : ITransientDependency
    {
        #region Khai báo các biến injection dependency

        public readonly ITransactionRepository _transactionRepository;

        public readonly IObjectMapper<BackgroundJobManagerApplicationModule> _objectMapper;

        #endregion

        #region Hàm contructor

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="objectMapper"></param>
        /// <param name="transactionRepository"></param>
        public HandleFileAppService(
            IObjectMapper<BackgroundJobManagerApplicationModule> objectMapper,
            ITransactionRepository transactionRepository)
        {
            _objectMapper = objectMapper;
            _transactionRepository = transactionRepository;
        }

        #endregion

         #region Khai báo các hàm xử lý

        /// <summary>
        /// Hàm thực thi đọc dữ liệu giao dịch từ file và thêm mới vào db
        /// Created By: NVSon(05/03/2022)
        /// </summary>
        /// <returns></returns>
        public async Task ExecuteAsync()
        {
            List<TransactionDto> transactionDtos = await ReadAsync();
            if (transactionDtos?.Count() > 0)
            {
                var transactions = _objectMapper.Map<List<TransactionDto>, List<Transaction>>(transactionDtos);
                await _transactionRepository.InsertManyAsync(transactions);
            }
        }

        #endregion

        #region Khai báo các hàm private

        /// <summary>
        /// Đọc dữ liệu từ file
        /// Created By: NVSon(05/03/2022)
        /// </summary>
        /// <returns>Danh sách giao dịch đọc được</returns>
        private async Task<List<TransactionDto>> ReadAsync()
        {
            string path = $"{Directory.GetCurrentDirectory()}/CSVStorageFile/Transaction.csv";
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                HeaderValidated = null,
                MissingFieldFound = null,
            };
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<TransactionDto>();
                return records.ToList();
            }
        }
        #endregion
    }
}
