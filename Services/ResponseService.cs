using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetpractice.Models.ApiModels;

namespace dotnetpractice.Services
{
    public class ResponseService
    {
        public static BaseResponse GetResponse(string Code, object Data)
        {
            return new BaseResponse
            {
                Code = Code,
                Data = Data
            };
        }
    }
}
