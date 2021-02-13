using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        //Diğer Result tan farkı aynı zamanda data da var yani T data
        public DataResult(T data, bool success, string message) : base(success, message)//base ile diyoruz ki sen base ye de success i ve message yi yolla
        {
            Data = data;
        }
        public DataResult(T data,bool success):base(success)//Mesaj göndermek istemediğimiz zaman bura çalışsın
        {
            Data = data;
        }
        public T Data { get; }

    }
}
