using System;

namespace Lesson12_31_08_2021
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

    public class Player : IPlayable, IRecordable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Music is playing");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Music is paused");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Music is stopped");
        }

        void IRecordable.Record()
        {
            Console.WriteLine("Recording");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Recording is paused");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Recording is stopped");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable player1 = new Player();
            IRecordable player2 = new Player();
            player2.Stop();
            player1.Play();
        }
    }
}