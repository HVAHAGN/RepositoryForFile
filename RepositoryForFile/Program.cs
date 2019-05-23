using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryForFile.Providers;
using RepositoryForFile.Repositories;
using RepositoryForFile.Models;


namespace RepositoryForFile
{
    class Program
    {
                  //static void WriteStudents(List<Student> list, string path)
            //{
            //    using (var sw = new StreamWriter(path))
            //    {
            //        foreach (var item in list)
            //        {
            //            sw.WriteLine(item);
            //        }
            //    }
            //}
            //static List<Student> ReadStudents(List<Student> list, string path)
            //{
            //    var srlist = new List<Student>();
            //    using (var sr=new StreamReader(path))
            //    {

            //        var text = "";
            //        while((text=sr.ReadLine())!=null)
            //        {
            //            srlist.Add(new Student
            //            {
            //                Name = text.Split(new char[] { ' ' })[0],
            //                SurName = text.Split(new char[] { ' ' })[1],
            //                Age = Convert.ToByte(text.Split(new char[] { ' ' })[2]),
            //            });

            //        }

            //    }
            //    return srlist;
            //}
            static void Main(string[] args)
            {
                //var list = CrateStudents(15);
                string pathStudent = @"C:\Users\ar.tonoyan\Desktop\student.txt";
                string pathTeacher = @"C:\Users\ar.tonoyan\Desktop\teacher.txt";
                var provider = new StudentFormatProvider();
                //string value=provider.Serialize(list[0]);
                //Student model = provider.Deserialize(value);
                //var repo = new StudentRepasitory(pathStudent, provider);
                //repo.Add(list);

                //var list = repo.Read().Where(p => p.Age == 20).ToArray();

                var listTeacher = CreateTeacher(15);
                var teacherProvider = new TeacherFormatProvider();

                var teacherRepo = new TeacherRepository(pathTeacher, teacherProvider);
                //teacherRepo.Add(listTeacher);
                //teacherRepo.SaveChanges();

                var list = teacherRepo.ReadAllToList();
                Console.ReadLine();
            }

            static List<Student> CrateStudents(int count)
            {
                var list = new List<Student>(count);
                var rand = new Random();
                for (int i = 0; i < count; i++)
                {
                    list.Add(new Student
                    {
                        Name = $"A{i + 1}",
                        Surname = $"A{i + 1}yan",
                        Age = (byte)rand.Next(18, 50),
                    });
                }
                return list;
            }
            static List<Teacher> CreateTeacher(int count)
            {
                var list = new List<Teacher>(count);
                var rand = new Random();
                for (int i = 0; i < count; i++)
                {
                    list.Add(new Teacher
                    {
                        Name = $"A{i + 1}",
                        Surname = $"A{i + 1}yan",
                        Age = (byte)rand.Next(18, 50),
                    });
                }
                return list;
            }



        
    }
}
