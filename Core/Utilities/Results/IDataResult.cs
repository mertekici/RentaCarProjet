using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult
    {
        T Data {get;}
        // I Result da zaten başarısı ve mesajı var burada da datayı eklemiş oluyoruz
}
}
