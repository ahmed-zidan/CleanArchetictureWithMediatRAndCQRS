using Core.IRepo;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repo
{
    public class UnitOfWork : IUnitOFWork
    {
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IBlogRepo _blogRepo => new BlogRepo(_appDbContext);

        public async Task<bool> saveChangesAsync()
        {
           return await _appDbContext.SaveChangesAsync()>0;
        }
    }
}
