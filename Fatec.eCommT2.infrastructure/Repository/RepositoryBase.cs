using Fatec.eCommT2.infrastructure.Data;
using System.ComponentModel;
using Fatec.eCommT2.Domain.Models;
using Fatec.eCommT2.Domain.ViewModels;

namespace Fatec.eCommT2.infrastructure.Repository
{
    public class RepositoryBase
    {
        private readonly ApplicationDataContext _applicationDataContext;
        public RepositoryBase(ApplicationDataContext applicationDataContext)
        {
            applicationDataContext = applicationDataContext;
        }

        public void Add(CategoryViewModel category)
        {
            var cat = new Category
            {
                Id = category.Id,
                Description = category.Description,
                IsActive = category.IsActive,
            };
            _applicationDataContext.categories.Add(cat);
        }
    }
}
