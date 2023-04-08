namespace Iran.PersianDate.Events;

public enum CalendarType
{
    /// <summary>
    /// Shamsi calendar
    /// </summary>
    Solar = 0,
    
    /// <summary>
    /// The World standard Calendar
    /// </summary>
    Gregorian = 1,
    
    /// <summary>
    /// Islamic Calendar based on Moon!
    /// </summary>
    Lunar = 2
}