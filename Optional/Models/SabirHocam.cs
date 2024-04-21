using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional.Models
{
    internal class SabirHocam
    {
      public void Kesmek(Student student)
        {
            if (student.IsHelpToPlagiate || student.IsPlagiated) 
            {
                Console.WriteLine($"{student.Name}-ugurla kesildi ve tohmet verildi");
            }
            else { Console.WriteLine("ne kocurdurem nede kocurtmeye komek eliyirem:)"); }
        }
    }
}
