using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDeleagtesExample
{
    class Counter
    {
        //public event EventHandler SchwelleErreicht;

        private int total;
        readonly private int schwelle;
        public event EventHandler SchwellwertErreicht;

        public Counter(int schwelle)
        {
            this.schwelle = schwelle;
        }

        public void Add(int value)
        {
            total += value;
            if(total >= schwelle)
            {
                OnSchwellwertErreicht(EventArgs.Empty);
            }
        }
        
        public void OnSchwellwertErreicht(EventArgs e)
        {
            EventHandler handler = SchwellwertErreicht;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
