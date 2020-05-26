using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public abstract class TimeLimitedCard : CardBase
    {
        private TimeSpan _startTime;
        private TimeSpan _endTime;
        private DateTime _firstDay;
        private DateTime _lastDay;

        public bool CheckIsTimeValid(TimeSpan startTime, TimeSpan endTime)
        {
            _startTime = startTime;
            _endTime = endTime;
            DateTime currentTime = DateTime.Now;
            if (currentTime.TimeOfDay >= _startTime && currentTime.TimeOfDay < _endTime)
            {
                return true;
            }
            return false;
        }
        public bool CheckIsTimeValid(DateTime firstDay, DateTime lastDay)
        {
            _firstDay = firstDay;
            _lastDay = lastDay;
            DateTime currentTime = DateTime.Now;
            if (currentTime.Date >= _firstDay && currentTime.Date <= _lastDay)
            {
                return true;
            }
            return false;
        }
    }

    public  class MorningCard : TimeLimitedCard
    {
        TimeSpan startTime = new TimeSpan(9, 0, 0);
        TimeSpan endTime = new TimeSpan(14, 0, 0);
        public override bool TryPass() => this.CheckIsTimeValid(startTime, endTime);

    }
    public class NoonCard : TimeLimitedCard
    {

        TimeSpan startTime = new TimeSpan(14, 0, 0);
        TimeSpan endTime = new TimeSpan(19, 0, 0);

        public override bool TryPass() => this.CheckIsTimeValid(startTime, endTime);

    }
    public class NightCard : TimeLimitedCard
    {
        TimeSpan startTime = new TimeSpan(19, 0, 0);
        TimeSpan endTime = new TimeSpan(24, 0, 0);

        public override bool TryPass() => this.CheckIsTimeValid(startTime, endTime);
    }
    public class N_daysCard : TimeLimitedCard
    {
        private DateTime _startDay;
        private DateTime _lastDay;

        public N_daysCard(DateTime startDay, int amountOfDays)
        {
            _startDay = startDay.Date;
            _lastDay = _startDay.Date.AddDays(amountOfDays);
        }
        public override bool TryPass() => this.CheckIsTimeValid(_startDay, _lastDay);
    }

}
