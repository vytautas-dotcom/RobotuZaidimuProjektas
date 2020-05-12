using RobotoDalys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotai.RobotoDalys
{
    class userRobot : Robotas
    {
        public Vaziuokle Vaziuokle { get; set; }
        public Sarvai Sarvai { get; set; }
        public Variklis Variklis { get; set; }
        public Valdymas Valdymas { get; set; }
        public IDalis Ginklas { get; set; }
        public override int Ataka()
        {
            throw new NotImplementedException();
        }

        public override int Gyvybe()
        {
            throw new NotImplementedException();
        }

        public override void Konstravimas()
        {
            throw new NotImplementedException();
        }
    }
}
