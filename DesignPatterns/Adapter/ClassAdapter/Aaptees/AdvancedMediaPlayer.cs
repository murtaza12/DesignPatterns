namespace Adapter.ClassAdapter.Aaptees;

public class AdvancedMediaPlayer
{
    public void PlayVlc(string fileName)
    {
        Console.WriteLine($"Playing VLC file. Name: {fileName}");
    }

    public void PlayMp4(string fileName)
    {
        Console.WriteLine($"Playing MP4 file. Name: {fileName}");
    }
}
