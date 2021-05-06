using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_App.Lesson17.EventTask
{
    public delegate void EmailSender();
    class Sender
    {
        public event EmailSender onChanged;


        public void ChangedEmailSender()
        {
            if(onChanged != null)
            {
                onChanged();
            }
        }
    }
}
