﻿using HUST.Core.Constants;
using HUST.Core.Enums;
using HUST.Core.Interfaces.Service;
using HUST.Core.Models.DTO;
using HUST.Core.Models.Param;
using HUST.Core.Models.ServerObject;
using HUST.Core.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HUST.Api.Controllers
{
    /// <summary>
    /// Lớp controller cung cấp api liên quan đến tài khoản
    /// </summary>
    public class AccountController : BaseApiController
    {
        #region Fields
        private readonly IAccountService _service;
        #endregion

        #region Constructors

        public AccountController(IHustServiceCollection serviceCollection, IAccountService service) : base(serviceCollection)
        {
            _service = service;
        }

        #endregion

        #region Methods

        [HttpPost("Login"), AllowAnonymous]
        public async Task<IServiceResult> Login([FromBody]LoginParam param)
        {
            var res = new ServiceResult();
            try
            {
                return await _service.Login(param.userName, param.password);
            }
            catch (Exception ex)
            {
                this.ServiceCollection.HandleControllerException(res, ex);
            }
            
            return res;
        }

        [HttpGet("Logout")]
        public async Task<IServiceResult> Logout()
        {
            var res = new ServiceResult();
            try
            {
                return await _service.Logout();
            }
            catch (Exception ex)
            {
                this.ServiceCollection.HandleControllerException(res, ex);
            }

            return res;
        }

        #endregion
    }
}
