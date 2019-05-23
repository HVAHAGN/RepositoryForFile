using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryForFile.Models;

namespace RepositoryForFile.Repositories
{
   public class StudentRepository:BaseRepository<Student>
    {
        public StudentRepository(string fileName, IFormatProvider provider)
            :base(fileName, provider)
        {


        }
    }
}
