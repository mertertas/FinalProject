using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // Getterlar sadece constructor icinde set edilebilir
        //ilk constructorda parametre alındı ve ikinci constructorda set edildi 
        //Ve ilkine bagımlı haline getirildi.

        public Result(bool success, string message):this(success)
        {
            Message = message;
            
        }

        public Result(bool succes)
        {
            Success = succes;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
