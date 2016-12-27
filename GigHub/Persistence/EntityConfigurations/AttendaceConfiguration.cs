using GigHub.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace GigHub.Persistence.EntityConfigurations
{
    public class AttendaceConfiguration : EntityTypeConfiguration<Attendance>
    {
        public AttendaceConfiguration()
        {
            HasKey(a => new { a.GigId , a.AttendeeId });
        }
    }
}