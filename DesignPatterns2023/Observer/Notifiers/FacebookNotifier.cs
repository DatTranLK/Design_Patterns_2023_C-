using DesignPatterns2023.Observer.Base;
using DesignPatterns2023.Observer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2023.Observer.Notifiers
{
    public class FacebookNotifier : Base.Observer
    {
        public FacebookNotifier(Subject subject)
        {
            Subject = subject;
            Subject.AttachObserver(this);
        }
        public override void Notify(object arg)
        {
            if(Subject is VideoData videoData)
            {
                Console.WriteLine("Notify all subscribers via FACEBOOK with new data" +
                                  "\n\tName: {0}" +
                                  "\n\tDescription: {1}" +
                                  "\n\tFile name: {2}", videoData.GetTitle(), videoData.GetDescription(), videoData.GetFileName());
            }
        }
    }
}
