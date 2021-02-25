using System;

namespace NewUdemy_StopWatch
{
    public class StopWatch
    {
        private DateTime _starttime { get; set; }
        private TimeSpan _interval { get; set; }

        public DateTime start()
        {
            var starttime = DateTime.Now;
            _starttime = starttime;
            return  starttime;

        }
        public TimeSpan stop()
        {
            var interval = DateTime.Now - _starttime;
            _interval = interval;
            return _interval;
        }
    }
}
