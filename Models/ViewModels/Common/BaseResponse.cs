using System;
using System.Collections.Generic;

namespace dotnetpractice.Models.ViewModels.Common
{
    public class BaseResponse
    {
        public string Code { get; set; }
        public object Data { get; set; }
    }
}
