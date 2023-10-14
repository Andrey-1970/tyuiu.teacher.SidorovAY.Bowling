using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyuiu.teacher.SidorovAY.Bowling
{
    public class Game
    {
        private List<Frame> frames = new List<Frame>();
        public int Score
        {
            get
            {
                return frames.Sum(frame => frame.Score);
            }
        }

        public void AddThrow(int pins)
        {
            Frame frame = frames.LastOrDefault();
            if(frame is null) { 
                frame = new Frame();
                frames.Add(frame);
            }
            if (frame.IsClosed)
            {
                frame = new Frame();
                frames.Add(frame);
            }
            frame.AddThrow(pins);
        }
        public int FrameCount => frames.Count;
    }
}
