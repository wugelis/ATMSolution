using ServicesPackage;
using System;

namespace Domain.ViewObjects.LoginServiceVO
{
    public class Account : IAccount
    {
        public string AID { get; set; }
        public string Password { get; set; }
    }
}
