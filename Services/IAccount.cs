using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesPackage
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAccount
    {
        string AID { get; set; }
        string Password { get; set; }
    }
}
