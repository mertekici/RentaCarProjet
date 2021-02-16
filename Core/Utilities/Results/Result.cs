using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // Eğer sadece başarıyı gönderirse mesajı set etmiyoruz.
        public Result(bool success)
        {
            Success = success;
        }
       // Eğer mesajı ve başarılı olup olmadığını gönderirse class da mesajı işliyor interface e de başarının sonucunu gönderiyor
        public Result(bool success,string message):this(success)
        {
            Message = message;
        }
        public bool Success { get; }             

        public string Message { get; }

        
    }
}
