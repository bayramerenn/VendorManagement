﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class Result:IResult
    {
        public Result(string message,bool success):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; set; }
        public string Message { get; set ; }
    }
}
