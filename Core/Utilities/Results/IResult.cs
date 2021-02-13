using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }//başarılı mı başarısız mı
        string Message { get; }//başarılıysa veya başarısızsa gösterilecek mesaj döndür
    }
}
