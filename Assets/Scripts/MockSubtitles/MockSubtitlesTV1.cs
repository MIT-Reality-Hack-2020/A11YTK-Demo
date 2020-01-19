using A11YTK;

public class MockSubtitlesTV1 : MockSubtitles
{
    private SRT.Subtitle[] subtitles = new[]
    {
        new SRT.Subtitle
        {
            id = 1,
            startTime = 4.20,
            endTime = 5.38,
            text = "Uh ... no?"
        },
        new SRT.Subtitle
        {
            id = 2,
            startTime = 10.31,
            endTime = 11.45,
            text = "*laugh* Oh my god."
        },
        new SRT.Subtitle
        {
            id = 3,
            startTime = 18.59,
            endTime = 20.27,
            text = "Can they not understand us?"
        },
        new SRT.Subtitle
        {
            id = 4,
            startTime = 24.43,
            endTime = 25.16,
            text = "I think you're right!"
        }
    };
}