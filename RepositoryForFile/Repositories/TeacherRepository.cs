using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryForFile.Models;

namespace RepositoryForFile.Repositories
{
    public class TeacherRepository:BaseRepository<Teacher>
        
    {
        public TeacherRepository(string fileName, IFormatProvider provider)
            :base(fileName, provider)
        {

        }
    }
}
