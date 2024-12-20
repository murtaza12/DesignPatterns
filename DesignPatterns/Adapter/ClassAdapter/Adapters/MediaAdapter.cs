﻿using Adapter.ClassAdapter.Aaptees;
using Adapter.ClassAdapter.Targets;

namespace Adapter.ClassAdapter.Adapters;

public class MediaAdapter : AdvancedMediaPlayer, IMediaPlayer
{
    public string Play(string audioType, string fileName)
    {
        if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
        {
            return PlayVlc(fileName); // Using Adaptee's method
        }
        else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
        {
            return PlayMp4(fileName); // Using Adaptee's method
        }
        else
        {
            return "Invalid media format. Supported formats: VLC, MP4.";
        }
    }
}

