using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensOpgave
{
    class SeasonalProduct : Product
    {
        private DateTime _seasonStartDate;
        private DateTime _seasonEndDate;

        public DateTime SeasonStartDate
        {
            get { return _seasonStartDate; }
            set
            {
                _seasonStartDate = value;
            }
        }

        public DateTime SeasonEndDate
        {
            get { return _seasonEndDate; }
            set
            {
                _seasonEndDate = value;
            }
        }
    }
}
