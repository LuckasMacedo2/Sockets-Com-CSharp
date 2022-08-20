namespace ChatServer.Classes
{
    public class StatusChangedEventArgs : EventArgs
    {
        private string EventMsg;
        public string EventMessage
        {
            get { return EventMsg; }
            set { EventMsg = value; }
        }

        public StatusChangedEventArgs(string eventMsg)
        {
            EventMsg = eventMsg;
        }
    }
}
