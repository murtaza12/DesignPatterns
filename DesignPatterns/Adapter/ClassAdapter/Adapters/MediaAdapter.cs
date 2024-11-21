using Adapter.ClassAdapter.Aaptees;
using Adapter.ClassAdapter.Targets;

namespace Adapter.ClassAdapter.Adapters;

public class MediaAdapter : AdvancedMediaPlayer, IMediaPlayer
{
    public void Play(string audioType, string fileName)
    {
        if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
        {
            PlayVlc(fileName); // Using Adaptee's method
        }
        else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
        {
            PlayMp4(fileName); // Using Adaptee's method
        }
        else
        {
            Console.WriteLine("Invalid media format. Supported formats: VLC, MP4.");
        }
    }
}

