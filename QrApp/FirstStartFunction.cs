using Microsoft.EntityFrameworkCore;
using QrApp.EntityFrameworkCore;

namespace QrApp
{
    public class FirstStartFunction
    {
        public FirstStartFunction()
        {
            checkDatabase();
        }

        public void checkDatabase()
        {
            using (var context = new QrDbContext())
            {
                context.Database.Migrate();
            }
        }
    }
}
