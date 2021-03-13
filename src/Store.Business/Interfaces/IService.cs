using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Business.Interfaces
{
    public interface IService<TEntityViewModel>
    {
        Task Add(TEntityViewModel entity);
        Task<TEntityViewModel> GetById(Guid id);
        Task<IEnumerable<TEntityViewModel>> GetAll();
        Task Remove(Guid id);
        Task Update(TEntityViewModel entity);
    }
}
