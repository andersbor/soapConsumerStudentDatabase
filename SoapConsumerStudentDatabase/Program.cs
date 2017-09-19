using System;
using SoapConsumerStudentDatabase.ServiceReferenceSchool;

namespace SoapConsumerStudentDatabase
{
    class Program
    {
        static void Main()
        {
            using (Service1Client client = new Service1Client("BasicHttpBinding_IService1"))
            {
                Student[] allStudents = client.GetAllStudents();
                foreach (var st in allStudents)
                {
                    Console.WriteLine(st.Name + " " + st.Semester);
                }

                Student stu = client.GetStudentById(1);
                Console.WriteLine(stu.Name + " " + stu.Semester);
            }
        }
    }
}
