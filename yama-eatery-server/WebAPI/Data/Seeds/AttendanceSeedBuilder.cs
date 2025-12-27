using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Utils;

namespace WebAPI.Data.Seeds
{
    public class AttendanceSeedBuilder : ISeedBuilder
    {
        public int Priority => 19;

        public ModelBuilder Seed(ModelBuilder modelBuilder)
        {
            var attendances = new List<object>();

            for (int i = 1; i <= 10; i++)
            {
                var checkInTime = new TimeOnly(8 + (i % 2), 0, 0);
                var checkOutTime = new TimeOnly(17 + (i % 2), 0, 0);
                var workHours = (checkOutTime - checkInTime).TotalHours;

                attendances.Add(new
                {
                    Id = i,
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(-i)),
                    CheckInTime = checkInTime,
                    CheckOutTime = checkOutTime,
                    WorkHours = workHours,
                    LateArrival = i % 5 == 0,
                    EarlyLeave = i % 7 == 0,
                    EmployeeId = ((i - 1) % 10) + 1
                });
            }

            modelBuilder.Entity<Attendance>().HasData(attendances.ToArray());
            return modelBuilder;
        }
    }
}
