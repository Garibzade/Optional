using Optional.Models;

namespace Optional
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Student student=new Student("Garib",false,false);
            SabirHocam sabirHocam = new SabirHocam();
            sabirHocam.Kesmek(student);

        }
    }
}
