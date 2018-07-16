using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    public enum Level : int
    {
        Begginer = 1,
        Intermediate = 2,
        Advanced = 3
    }

    class Program
    {
        static void Main(string[] args)
        {

            PlutoDbContext plutoDbContext = new PlutoDbContext();

            //Como chamar Stored Procedures usando DatabaseFirst:
            plutoDbContext.DeleteCourse(5);

        }
    }
}
