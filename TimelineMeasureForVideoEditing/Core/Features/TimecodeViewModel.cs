using System.ComponentModel.DataAnnotations;

namespace TimelineMeasureForVideoEditing.Core.Features;
public class TimecodeViewModel
{
    [Required(ErrorMessage = "A Start Timecode is required")]
    public string StartTimecode { get; set; } = "00:00:00";

    [Required(ErrorMessage = "An End Timecode is required")]
    public string EndTimecode { get; set; } = "00:00:00";
}
