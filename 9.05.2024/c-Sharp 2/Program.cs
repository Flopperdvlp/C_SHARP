using System;
namespace Project
{
    public interface IMediaPlayer
    {
        void Audio_play();
        void Video_play();
    }
    public class LegacyPlayer
    {
        public void Play_Audio()
        {
            Console.WriteLine("Аудио включёно");
        }
        public void Play_Video()
        {
            Console.WriteLine("Видел включёно");
        }
    }
    public class AudioAdapter : IMediaPlayer
    {
        private readonly LegacyPlayer _legacyPlayer;
        public AudioAdapter(LegacyPlayer legacyPlayer)
        {
            _legacyPlayer = legacyPlayer;
        }
        public void Audio_play()
        {
            _legacyPlayer.Play_Audio();
        }
        public void Video_play()
        {
            _legacyPlayer.Play_Video();
        }
    }
    public interface IMediaDevice
    {
        void TurnOn();
        void TurnOff();
    }
    public class MediaControl
    {
        public MediaControl()
        {

        }
        public void Stop()
        {
            Console.WriteLine("Stop!");
        }
        public void Play()
        {
            Console.WriteLine("Play!");
        }
        public void Pause()
        {
            Console.WriteLine("Pause!");
        }
        public void TurnOn()
        {
            Console.WriteLine("Turn on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turn off");
        }
    }
    public class VideoMedia : MediaControl
    {
        public void TurnOnVideo()
        {
            Console.WriteLine("Turn on");
        }
    }
    public class AudioMedia : MediaControl
    {
        public void TurnOnAudio()
        {
            Console.WriteLine("Turn on");
        }
    }
    public class TV : IMediaDevice
    {
        public TV()
        {

        }
        public void TurnOn()
        {
            Console.WriteLine("Turn on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turn off");
        }
    }
    public class Speakers : IMediaDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turn off");
        }
    }
    public class Projector : IMediaDevice
    {
        public void Start()
        {
            Console.WriteLine("Start!");
        }
        public void Stop()
        {
            Console.WriteLine("Stop!");
        }
        public void TurnOn()
        {
            Console.WriteLine("Turn on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turn off");
        }
    }
    public class HomeTheatreFacade
    {
        private readonly TV _tv;
        private readonly Speakers _speakers;
        private readonly Projector _projector;
        public HomeTheatreFacade(TV tv, Speakers speakers, Projector projector)
        {
            _tv = tv;
            _speakers = speakers;
            _projector = projector;
        }
        public void WatchMovie()
        {
            Console.WriteLine("Movie On");
            _tv.TurnOn();
            _speakers.TurnOn();
            _projector.TurnOn();
            _projector.Start();
        }
        public void EndMovie()
        {
            Console.WriteLine("Movie Off");
            _projector.Stop();
            _tv.TurnOff();
            _speakers.TurnOff();
            _projector.TurnOff();
        }
    }
    public class Main1
    {
        public static void Main()
        {
            //LegacyPlayer legacyPlayer = new LegacyPlayer();
            //IMediaPlayer mediaPlayer = new AudioAdapter(legacyPlayer);
            //mediaPlayer.Audio_play();
            TV tV = new TV();
            Speakers speakers = new Speakers();
            Projector projector = new Projector();
            HomeTheatreFacade homeTheatreFacade = new HomeTheatreFacade(tV,speakers,projector);
            homeTheatreFacade.WatchMovie();
            homeTheatreFacade.EndMovie();
        }
    }
}