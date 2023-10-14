using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tyuiu.teacher.SidorovAY.Bowling
{
    public class Throw
    {
        private readonly int pins;

        public Throw(int pins)
        {
            this.pins = pins;
        }
        public bool IsStrike => pins == 10;

        public int Score => pins;
    }
}
