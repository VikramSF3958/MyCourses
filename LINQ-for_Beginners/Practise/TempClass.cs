
using System.Collections.Generic;

namespace Practise
{
    public class TempClass
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public long Phone { get; set; }

        public static List<TempClass> Details()
        {
            List<TempClass> student = new List<TempClass>();

            student.Add(new TempClass(){Name = "Vikram", Id=18, Phone=78687687});

            student.Add(new TempClass(){Name = "Krithi", Id=11, Phone=47545747});

            student.Add(new TempClass(){Name = "Jeeva", Id=24, Phone=324567});

            student.Add(new TempClass(){Name = "Yuva", Id=21, Phone=5677843});

            student.Add(new TempClass() { Name = "Krithi Jr", Id = 1811, Phone = 18110701 });

            return student;
        }
    }
}