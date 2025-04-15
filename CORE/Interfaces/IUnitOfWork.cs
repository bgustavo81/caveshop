using System;
using CORE.Entities;

namespace CORE.Interfaces;

public interface IUnitOfWork : IDisposable
{
  IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
  Task<bool> Complete();
}
