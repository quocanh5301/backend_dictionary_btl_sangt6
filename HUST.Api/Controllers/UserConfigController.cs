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
    /// Lớp controller cung cấp api lấy cấu hình: concept link, example link, tone, mode...
    /// </summary>
    public class UserConfigController : BaseApiController
    {
        #region Fields
        private readonly IUserConfig _service;
        #endregion

        #region Constructors

        public UserConfigController(IHustServiceCollection serviceCollection, IUserConfig service) : base(serviceCollection)
        {
            _service = service;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Lấy danh sách concept link
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_list_concept_link")]
        public async Task<IServiceResult> GetListConceptLink()
        {
            var res = new ServiceResult();
            try
            {
                return await _service.GetListConceptLink();
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
