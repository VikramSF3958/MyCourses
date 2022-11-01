using System;
using System.Linq;
using System.Collections.Generic;

namespace Practise;

class Program
{
    public static void Main(string[] args)
    {
       
       List<TempClass> infoList = TempClass.Details();

       List<TempClassA> infoListA = TempClassA.Details();

        dynamic result = infoList.GroupJoin(
            infoListA, 
            info => info.Id, 
            infoA => infoA.TempId,
            (info, infoA) => new {
                tempInfo = info,
                tempInfoA = infoA
            }
       );

       foreach(var data in result)
       {
         System.Console.WriteLine(data.tempInfo.Id);

        foreach(var data1 in data.tempInfoA)
         {
            System.Console.WriteLine(data1.DeptName);
         }
       }

    }
}