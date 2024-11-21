namespace Adapter.ClassAdapter.Aaptees;

public class AdvancedMediaPlayer
{
    public string PlayVlc(string fileName)
    {
        return $"Playing VLC file. Name: {fileName}";
    }

    public string PlayMp4(string fileName)
    {
        return $"Playing MP4 file. Name: {fileName}";
    }
}
