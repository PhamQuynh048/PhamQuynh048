﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Audio;

namespace UWP49_SoundBoard.Model
{
    public class Sound
    {
        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string ImageFile { get; set; }
    }

    public enum SoundCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings
    }

    public Sound(string name, SoundCategory category)
    {
        Name = name;
        category = category;
        AudioFile = String.Format("/Assets/Audio/{0}/{1}.wav", category, name);
        AudioFile = String.Format("/Assets/Images/{0}/{1}.wav", category, name);
    }
}
