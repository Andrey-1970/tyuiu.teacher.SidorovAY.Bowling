using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyuiu.teacher.SidorovAY.Bowling
{
    public class Frame
    {
        private List<Throw> throws = new List<Throw>();
        public int Score
        {
            get
            {
                return throws.Sum(thr => thr.Score);
            }
        }

        public void AddThrow(int pins)
        {
            Throw thr = new Throw(pins);
            throws.Add(thr);
        }
        public bool IsSpare => (
            throws.Count == 2 &&
            throws.Sum(thr => thr.Score) == 10
        );
        public bool IsClosed => (
            throws.Count == 2 ||
            throws.FirstOrDefault()?.Score == 10
        );
    }
}
