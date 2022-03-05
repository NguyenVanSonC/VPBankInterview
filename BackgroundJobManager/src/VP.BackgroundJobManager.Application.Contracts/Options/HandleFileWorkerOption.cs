using System;
using System.Collections.Generic;
using System.Text;

namespace VP.BackgroundJobManager
{
    /// <summary>
    /// Cấu hình worker
    /// </summary>
    public class HandleFileWorkerOption
    {
        /// <summary>
        /// Expression thời gian
        /// </summary>
        public string CronExpression { get; set; }
    }
}
