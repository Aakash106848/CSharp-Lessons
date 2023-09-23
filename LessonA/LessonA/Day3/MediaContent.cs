using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day3
{
    internal class MediaContent
    {
        public virtual void StartPlayingContent() 
        {
            Console.WriteLine("Start");
        }
        public virtual void StopPlayingContent()
        {
            Console.WriteLine("Stop");
        }
        public virtual void PausePlayingContent()
        {
            Console.WriteLine("Pause");
        }
        public virtual void ContinuePlayingContent()
        {
            Console.WriteLine("Continue");
        }
    }
    internal class AudioContent : MediaContent
    {
        public override sealed void StartPlayingContent() // cannot be overriden by other override methods anymore,child classes can only inherit them
        {             // CAN OVERRIDE ONLY WHEN THE PARENT IS VIRTUAL
            Console.WriteLine("Start");
        }
    }
    internal class VideoContent : AudioContent
    {
        //public override  void StartPlayingContent() // cannot be overriden by other override methods anymore,child classes can only inherit them
        //{             // CAN OVERRIDE ONLY WHEN THE PARENT IS VIRTUAL
        //    Console.WriteLine("Start");
        //}
    }
    internal class MediaTester 
    {

    }
}
