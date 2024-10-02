using Application.DTO;
using Appliction.DTO;
using Domain.Entities;
using Domain.Entities.Common;
using Domain.Exceptions;
using Domain.Interfaces;
using Infrastructure;
using Mapster;

namespace Application.Services.Common
{
    public abstract class BaseService<T,D>(IRepository<T> repository) where T : BaseEntity where D : BaseDTO
    {
        private readonly IRepository<T> _repository = repository;

        public virtual async Task AddAsync(D dto)
        {
            var entity = dto.Adapt<T>();
            await _repository.AddEntity(entity);
        }


        public virtual async Task<ICollection<T>> GetAllAsync()
        {
            return await _repository.GetAllEntitiesAsync();
        }

        public virtual async Task<T> GetAsync(Guid id)
        {
            var entity = await repository.GetEntityByIdAsync(id) ?? throw new NullEntityException($"can't find entity by given id: {id}");
            return entity;
        }

        public virtual async Task UpdateAsync(D dto, Guid id)
        {
            var entity = await _repository.GetEntityByIdAsync(id) ?? throw new NullEntityException($"can't find entity by given id: {id}");
            dto.Adapt(entity);
            _repository.UpdateEntity(entity);
            await _repository.SaveChangesAsync();

        }

        public virtual async Task DeleteAsync(Guid id)
        {
            var entity = await repository.GetEntityByIdAsync(id) ?? throw new NullEntityException($"can't find entity by given id: {id}");
            repository.DeleteEntity(entity);
        }


    }
}
