using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryForFile.Repositories
{
    class BaseRepository<T>
    {

         public BaseRepostiory(string fileName, IFormatProvider<T> provider)

        {
            this.fileName = fileName;
            this.provider = provider;
            _cache = new List<T>();
        }
    }
}