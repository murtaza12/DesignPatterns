using Adapter.ClassAdapter.Adapters;
using Adapter.ClassAdapter.Targets;

namespace Adapter.Test.ClassAdapter;

public class AudioPlayerTests
{
    [Fact]
    public void MediaAdapter_ShouldPlayVLCFileSuccessfully()
    {
        // Arrange
        IMediaPlayer mediaPlayer = new MediaAdapter();
        string audioType = "vlc";
        string fileName = "example.vlc";

        // Act
        var result = mediaPlayer.Play(audioType, fileName);

        // Assert
        Assert.Equal("Playing VLC file. Name: example.vlc", result);
    }

    [Fact]
    public void MediaAdapter_ShouldPlayMP4FileSuccessfully()
    {
        // Arrange
        IMediaPlayer mediaPlayer = new MediaAdapter();
        string audioType = "mp4";
        string fileName = "example.mp4";

        // Act
        var result = mediaPlayer.Play(audioType, fileName);

        // Assert
        Assert.Equal("Playing MP4 file. Name: example.mp4", result);
    }

    [Fact]
    public void MediaAdapter_ShouldHandleUnsupportedFormatGracefully()
    {
        // Arrange
        IMediaPlayer mediaPlayer = new MediaAdapter();
        string audioType = "avi";
        string fileName = "example.avi";

        // Act
        var result = mediaPlayer.Play(audioType, fileName);

        // Assert
        Assert.Equal("Invalid media format. Supported formats: VLC, MP4.", result);
    }
}
