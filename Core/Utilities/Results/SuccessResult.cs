using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        // Eğer boş bir SuccessResult istenirse otomatik olarak başarısı true gönderiliyor
        public SuccessResult() : base(true)
        {
        }

        // mesaj gönderilmek istenirse yine direk true gönderiliyor.
        public SuccessResult( string message) : base(true, message)
        {
        }
    }
}
