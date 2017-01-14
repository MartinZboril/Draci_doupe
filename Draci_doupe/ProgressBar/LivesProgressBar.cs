using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draci_doupe.Interface;

namespace Draci_doupe.ProgressBar
{
    public class LivesProgressBar : IProgressBarValue
    {
        public LivesProgressBar()
        {

        }

        public LivesProgressBar(double lives, int level)
        {
            _minimum = 0;
            _maximum = 100 + (level * 80);
            _progress = lives;
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
    }
}
