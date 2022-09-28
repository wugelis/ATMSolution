using ServicesPackage;
using System;

namespace LoginBO
{
    /// <summary>
    /// ATM 登入服務類別
    /// </summary>
    public class LoginService : ILoginService
    {
        /// <summary>
        /// Login 登入方法
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Login(IAccount user)
        {
            throw new NotImplementedException();
        }
    }
}
