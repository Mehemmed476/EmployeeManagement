﻿using EmployeeManagement.Models.Base;

namespace EmployeeManagement.Services.Abstractions
{
    public interface IGenericCCRUDService
    {
        Task<IEnumerable<T>> GetAllAsync<T>() where T : class;
        Task<T> GetByIdAsync<T>(int id) where T : class;
        Task CreateAsync<T>(T entity) where T : BaseAuditableEntity;
        Task UpdateAsync<T>(T entity) where T : BaseAuditableEntity;
        Task DeleteAsync<T>(int id) where T : BaseAuditableEntity;
        Task SoftDeleteAsync<T>(int id) where T : BaseAuditableEntity;
        Task RestoreAsync<T>(int id) where T : BaseAuditableEntity;
    }
}
