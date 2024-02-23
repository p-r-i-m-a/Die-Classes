using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Die_Classes
{
    public class Die
    {
        // Mr. Aldworth is skeptical
        private Random _generator;
        private int _roll;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }

        public Die(int roll)
        {
            _generator = new Random(roll);
            _generator.Next(1, 7);
        }

        public int Roll { get { return _roll; } }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public void RollDie()
        {
            
        }
    }


}
