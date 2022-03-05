using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace VP.BackgroundJobManager
{
    /// <summary>
    /// Interface Service xử lý đọc dữ liệu giao dịch từ file
    /// Created By: NVSon(05/03/2022)
    /// </summary>
    public interface IHandleFileAppService : IApplicationService
    {
        /// <summary>
        /// Hàm thực thi đọc dữ liệu giao dịch từ file
        /// Created By: NVSon(05/03/2022)
        /// </summary>
        /// <returns></returns>
        public Task Execute();
    }
}
