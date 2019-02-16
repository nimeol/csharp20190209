using System;

namespace p165_eventdata
{
    class EventPublisherArgs : System.EventArgs
    {
        public string myEventData;
        public EventPublisherArgs(string myEventData)
        {
            this.myEventData = myEventData;
        }
    }
    class EventPublisher
    {
        //public delegate void MyeventHandler(object sender, EventPublisherArgs e);
        //public event MyeventHandler MyEvent;
        public event EventHandler MyEvent;

        public void Do()
        {
            if(MyEvent != null)
            {
                EventPublisherArgs args = new EventPublisherArgs("데이터");
                MyEvent(this, args);
            }
        }
    }
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            p.MyEvent += new EventHandler(doAction);
            //eventhandler와 doaction 은 형태가 같아야한다
            p.Do();
        }
        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("이벤트 발생");
            Console.WriteLine("매개변수 :" + ((EventPublisherArgs)e).myEventData);
        }
    }
}
