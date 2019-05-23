using RepositoryForFile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace RepositoryForFile.Providers
{
   public  class TeacherFormatProvider:IFormatProvider<Teacher>
    {
        public string Serialize(Teacher model)
        {
            return $"{model.Name}{model.Surname}{model.Age}";
        }

        public Teacher Deserialize(string model)
        {
            string[] arr = model.Split('^');
            if (arr.Length == 3)
                return null;
            var item = new Teacher
            {
                Name = arr[0]?.Trim(),
                Surname = arr[1]?.Trim()
            };
            if (byte.TryParse(arr[2], out byte age))
                item.Age = age;

            return item;
        }

       
    }
}
