using System.Collections.Generic;

namespace Practise
{
    public class TempClassA
    {
        public string DeptName { get; set; }
        public int TempId { get; set; }

        public static List<TempClassA> Details()
        {
            List<TempClassA> studentA = new List<TempClassA>();

            studentA.Add(new TempClassA(){DeptName = "CSE", TempId=18 });

            studentA.Add(new TempClassA(){DeptName = "CSE", TempId=11});

            studentA.Add(new TempClassA(){DeptName = "ECE", TempId=24 });

            studentA.Add(new TempClassA(){DeptName = "EEE", TempId=21});

            return studentA;
        }
    }
}