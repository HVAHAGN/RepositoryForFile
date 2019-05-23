using RepositoryForFile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RepositoryForFile.Providers
{
    public class StudentFormatProvider : IFormatProvider<Student>
    {
        public Student Deserialize(string model)
        {
            string[] arr = model.Split('^');
            if (arr.Length != 3)
                return null;
            var st = new Student
            {
                Name = arr[0]?.Trim(),
                Surname = arr[1]?.Trim()
            };
            if (byte.TryParse(arr[2], out byte age))
                st.Age = age;

            return st;
        }

        public string Serialize(Student model)
        {
            return $"{model.Name}^{model.Surname}^{model.Age}";
        }
    }
}
