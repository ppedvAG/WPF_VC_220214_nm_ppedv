using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    public class AsyncDataSource
    {
        private string _fastDP;
        private string _slowerDP;
        private string _slowestDP;

        public AsyncDataSource()
        {
        }

        public string FastDP
        {
            get { return _fastDP; }
            set { _fastDP = value; }
        }

        public string SlowerDP
        {
            get
            {
                // This simulates a lengthy time before the
                // data being bound to is actualy available.
                Thread.Sleep(3000);
                return _slowerDP;
            }
            set { _slowerDP = value; }
        }

        public string SlowestDP
        {
            get
            {
                // This simulates a lengthy time before the
                // data being bound to is actualy available.
                Thread.Sleep(5000);
                return _slowestDP;
            }
            set { _slowestDP = value; }
        }
    }
}
