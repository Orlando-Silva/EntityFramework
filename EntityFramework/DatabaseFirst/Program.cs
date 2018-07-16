using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
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
