namespace TimelineMeasureForVideoEditing.Core.Logic;

public class TimecodeRuler
{
    public static string Measure(string startTimecode, string endTimecode)
    {
        if (TimeOnly.TryParse(startTimecode, out var startTime) && TimeOnly.TryParse(endTimecode, out var endTime)) 
        {
            if(startTime > endTime)
            {
                return $"- {(startTime - endTime)}";
            }

            return (endTime - startTime).ToString();            
        }
        return "00:00:00";
    }
}
