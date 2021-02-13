using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult//IResult un içindeki Saccess ve Message var ayrıva IDataResult un içindeki T Data da var demek
    {
        T Data { get; }
    }
}
