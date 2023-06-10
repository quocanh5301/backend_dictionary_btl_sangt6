﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUST.Core.Utils
{
    public interface ICacheSqlUtil
    {
        /// <summary>
        /// Thêm dữ liệu vào cahce cache
        /// </summary>
        /// <param name="cacheKey">Cache key</param>
        /// <param name="cacheValue">Giá trị cần cache</param>
        /// <param name="cacheType">Loại cache</param>
        /// <param name="timeout">Thời gian hết hạn</param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        Task<bool> SetCache(string cacheKey, string cacheValue, int? cacheType, TimeSpan? timeout = null, IDbTransaction transaction = null);

        /// <summary>
        /// Xóa giá trị trong cache
        /// </summary>
        /// <param name="cacheKey"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        Task<bool> DeleteCache(string cacheKey, IDbTransaction transaction = null);

        /// <summary>
        /// Xóa giá trị trong cache với tham số truyền vào
        /// </summary>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        Task<bool> DeleteCache(object param, IDbTransaction transaction = null);

        /// <summary>
        /// Lấy dữ liệu trong cache
        /// </summary>
        /// <param name="cacheKey"></param>
        /// <returns></returns>
        Task<string> GetCache(string cacheKey);
    }
}
