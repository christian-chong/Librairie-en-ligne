using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DbInitializer
    {
        public static void Init()
        {
            Database.SetInitializer(new LibrairieInitializer());

            using (LibrairieContext context = new LibrairieContext())
            {
                context.Database.Initialize(false);
            }
        }
    }
}
