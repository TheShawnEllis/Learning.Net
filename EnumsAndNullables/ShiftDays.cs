namespace EnumsAndNullables
{
    [Flags]
    public enum ShiftDays : short
    {
        Sunday = 1,
        Monday = 2,
        // Sunday and Monday = 3
        Tuesday = 4,
        // Sunday Monday Tuesday = 7
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        // Monday - Friday = 63
        Weekdays = 63,
        Saturday = 64,
        Weekend = 65
    }
}