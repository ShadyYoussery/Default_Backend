﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Default_Backend.Common.Core;

namespace Default_Backend.Service.Services.Base
{
    public interface IBaseService<T, TDto, TGetDto, TKey , TKeyDto>
        where T : class
        where TDto : IEntityDto<TKeyDto>
        where TGetDto : IEntityDto<TKeyDto>
    {
        Task<IResult> GetByIdAsync(object id);

        Task<IResult> GetAllAsync(bool disableTracking = false, Expression<Func<T, bool>> predicate = null);

        Task<IResult> AddAsync(TDto model);

        Task<IResult> AddListAsync(List<TDto> model);

        Task<IResult> UpdateAsync(TDto model);

        Task<IResult> DeleteAsync(object id);

        Task<IResult> DeleteSoftAsync(object id);
        
    }
}