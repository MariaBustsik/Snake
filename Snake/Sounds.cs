﻿using System;
using System.Collections.Generic;
using System.Text;
using WMPLib;


namespace Snake
{
    public class Sounds
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sounds (string pathToResources)
        {
            pathToMedia = pathToResources;
        }

        public void Play()
        {
            player.URL=pathToMedia + "play.mp3";
            player.settings.volume = 1;
            player.controls.play();
            player.settings.setMode("loop", true);


        }

        public void Play (string songName)
        {
            player.URL = pathToMedia + songName + ".mp3";
            player.controls.play();
        }

        public void PlayEat()
        {
            player.URL = pathToMedia + "eat.mp3";
            player.settings.volume = 300;
            player.controls.play();
        }

    }
}
