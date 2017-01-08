using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draci_doupe.Interface;

namespace Draci_doupe.ProgressBar
{
    class LevelProgressBar : IProgressBarValue
    {
        public LevelProgressBar()
        {

        }

        public LevelProgressBar(int experience, int level)
        {
            _minimum = 0;
            _maximum = 100 + (level * 100);
            _progress = experience;
        }

        private int _maximum;
        public int Maximum
        {
            get { return _maximum; }
            set { _maximum = value; }
        }

        private int _minimum;
        public int Minimum
        {
            get { return _minimum; }
            set { _minimum = value; }
        }

        private double _progress;
        public double Progress
        {
            get { return _progress; }
            set { _progress = value; }
        }
        public int LevelUp(int experience, int level, int maximum)
        {
            int num = 0;
            if (experience >= maximum)
            {
                num = 1;
            }
            return num;
        }
    }
}
