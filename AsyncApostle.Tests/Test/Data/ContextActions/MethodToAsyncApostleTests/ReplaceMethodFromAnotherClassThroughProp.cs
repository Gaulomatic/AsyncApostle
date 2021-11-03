﻿using System.Threading.Tasks;

namespace AsyncApostle.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        private readonly IService service;

        public Class(IService service)
        {
            this.service = service;
        }

        public int {caret}Test()
        {
            var a = service.innerService.Method("lalala");
            return 4;
        }
    }

    public interface IService
    {
        IInnerService innerService {get;}
    }

    public interface IInnerService
    {
        string Method(string s);
        Task<string> MethodAsync(string s);
    }
}
