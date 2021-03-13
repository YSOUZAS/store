using AutoMapper;
using Store.Business.Interfaces;
using Store.Data.Models;
using Store.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Business.Services
{
    public abstract class Service<TEntityViewModel, TEntity> : IService<TEntityViewModel> where TEntity : Entity
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        protected Service(IRepository<TEntity> repository, IMapper mapper)
        {
            this._repository = repository;
            _mapper = mapper;
        }

        public async Task Add(TEntityViewModel entity)
        {
            var entityToCreate = _mapper.Map<TEntity>(entity);
            await _repository.Add(entityToCreate);
        }

        public async Task Update(TEntityViewModel entity)
        {
            var entityToUpdate = _mapper.Map<TEntity>(entity);
            await _repository.Update(entityToUpdate);
        }

        public async Task<IEnumerable<TEntityViewModel>> GetAll()
        {
            return _mapper.Map<IEnumerable<TEntityViewModel>>(await _repository.GetAll());
        }

        public async Task<TEntityViewModel> GetById(Guid id)
        {
            return _mapper.Map<TEntityViewModel>(await _repository.GetById(id));
        }

        public async Task Remove(Guid id)
        {
            await _repository.Remove(id);
        }

        public async Task Update(TEntity entity)
        {
            await _repository.Update(entity);
        }

        public void Dispose()
        {
        }
    }
}
