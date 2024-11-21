using Adapter.ClassAdapter.Targets;

namespace Adapter.ClassAdapter.Client;

public class AudioPlayer
{
    private readonly IMediaPlayer _mediaPlayer;

    public AudioPlayer(IMediaPlayer mediaPlayer)
    {
        _mediaPlayer = mediaPlayer;
    }

    public void Play(string audioType, string fileName)
    {
        Console.WriteLine("AudioPlayer delegating playback to adapter...");
        _mediaPlayer.Play(audioType, fileName);
    }
}

