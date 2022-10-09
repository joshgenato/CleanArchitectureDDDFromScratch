using BubberDinner.Application.Common.Interface.Services;

namespace BubberDinner.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
