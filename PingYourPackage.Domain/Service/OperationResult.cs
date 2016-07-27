using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingYourPackage.Domain.Service
{
    public class OperationResult
    {

        public OperationResult(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public bool IsSuccess { get; private set; }
    }

    public class OperationResult<TEntity> : OperationResult
    {

        public OperationResult(bool isSuccess)
            : base(isSuccess) { }

        public TEntity Entity { get; set; }
    }
}
