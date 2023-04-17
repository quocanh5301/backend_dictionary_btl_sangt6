﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUST.Core.Constants
{
    /// <summary>
    /// Key auth
    /// </summary>
    public static class AuthKey
    {
        public static string Authorization => "Authorization";
        public static string Bearer => "Bearer";
        public static string TokenExpired => "Token-Expired";
        public static string SessionId => "x-session-id";
    }

    /// <summary>
    /// Key jwt claim
    /// </summary>
    public static class JwtClaimKey
    {
        public static string UserId => "UserId";
        public static string UserName => "UserName";
        public static string Email => "Email";
        public static string DictionaryId => "DictionaryId";
        public static string Status => "Status";
    }

}
