using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryForFile.Providers
{
   interface IFormatProvider<T>
    {
        string Serializ(T model);
        T Deserialize(string model);
    }
}
