using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace VP.BackgroundJobManager
{
    /// <summary>
    /// Interface định nghĩa các hàm xử lý nghiệp vụ liên quan đến giao dịch
    /// Kế thừa ICrudAppService sử dụng các hàm Crud cơ bản:(thêm, sửa, xóa,..)
    /// PagedAndSortedResultRequestDto sử dụng phân trang
    /// Created By: NVSon(05/03/2022)
    /// </summary>
    public interface ITransactionAppService : ICrudAppService<TransactionDto, Guid, PagedAndSortedResultRequestDto>
    {

    }
}
