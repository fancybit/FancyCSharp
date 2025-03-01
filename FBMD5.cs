using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FancyCSharp
{
    public static class FBMD5
    {
        public static byte[] HashData(byte[] data)
        {
            byte[] hashBytes;
            using (MD5 md5 = MD5.Create())
            {
                hashBytes = md5.ComputeHash(data);
            }
            return hashBytes;
        }
    }
}
