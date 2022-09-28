using ServicesPackage;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginBO
{
    /// <summary>
    /// ATM 使用者登入物件
    /// </summary>
    public interface ILoginService: IService
    {
        /// <summary>
        /// Login 登入方法
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool Login(IAccount user);
    }
}
