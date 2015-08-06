namespace _02.Code_Formatting
{
    using System;

    public static class Messages
    {
        public static void EventAdded()
        {
            EventApplication.Output.Append("Event added\n");
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                EventApplication.Output.AppendFormat("{0} events deleted\n", x);
            }
        }

        public static void NoEventsFound()
        {
            EventApplication.Output.Append("No events found\n");
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
               EventApplication.Output.Append(eventToPrint + "\n");
            }
        }
    }
}
