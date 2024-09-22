using Core.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repo
{
    public class UnitOfWork : IUnitOFWork
    {
        public IBlogRepo _blogRepo => new BlogRepo();

        public Task<bool> saveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
