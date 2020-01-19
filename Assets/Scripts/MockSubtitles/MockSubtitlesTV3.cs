using A11YTK;

public class MockSubtitlesTV3 : MockSubtitles
{
    private SRT.Subtitle[] subtitles =
    {
        new SRT.Subtitle
        {
            id = 1,
            startTime = 11.56,
            endTime = 14.08,
            text = "I told you we shouldn't have invited him."
        },
        new SRT.Subtitle
        {
            id = 2,
            startTime = 16.23,
            endTime = 17.36,
            text = "Wait, who is this?"
        }
    };
}