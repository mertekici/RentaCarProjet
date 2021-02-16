using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        // Eğer boş bir ErrorResult istenirse otomatik olarak başarısı false gönderiliyor

        public ErrorResult() : base(false)
        {
        }

        // mesaj gönderilmek istenirse başarısı yine direk false gönderiliyor.

        public ErrorResult( string message) : base(false, message)
        {
        }
    }
}
