using GigHub.Core.Models;
using GigHub.Core.Repositories;
using System.Collections.Generic;

namespace GigHub.Core
{
    public interface IUnitOfWork
    {
        IGigRepository Gigs { get; }
        IAttendanceRepository Attendances { get; }
        IFollowingRepository Followings { get; }
        IGenreRepository Genres { get; }
        INotificationRepository Notifications { get; }
        IUserNotificationRepository UserNotifications { get; }
        IApplicationUserRepository Users { get; }
        void Complete();
    }
}