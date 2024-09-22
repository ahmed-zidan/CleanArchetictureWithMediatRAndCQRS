using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IRepo
{
    public interface IUnitOFWork
    {
        public IBlogRepo _blogRepo {get;}
        Task<bool> saveChangesAsync();
    }
}
