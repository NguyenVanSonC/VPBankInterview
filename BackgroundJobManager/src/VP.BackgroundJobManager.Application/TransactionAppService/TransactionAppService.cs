using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using VP.BackgroundJobManager;

namespace Vp.TransactionManager
{
    /// <summary>
    /// Định nghĩa các hàm xử lý nghiệp vụ liên quan đến giao dịch
    /// Kế thừa CrudAppService sử dụng các hàm Crud cơ bản:(thêm, sửa, xóa,..)
    /// PagedAndSortedResultRequestDto sử dụng phân trang
    /// </summary>
    public class TransactionAppService : CrudAppService<Transaction, TransactionDto, Guid,PagedAndSortedResultRequestDto>, ITransactionAppService
    {
        #region Khai báo các biến injection dependency
        #endregion

        #region Hàm contructor

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="repository"></param>
        public TransactionAppService(IRepository<Transaction, Guid> repository) : base(repository)
        {
        }

        #endregion

        #region Khai báo các hàm xử lý

        #endregion

        #region Khai báo các hàm private
        #endregion
    }
}
