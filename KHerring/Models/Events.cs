using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace KHerring.Models
{
    public class Events
    {

        static Random _r = new Random();
        public List<Event> GetEvents()
        {

            List<Event> events = new List<Event>();
            //Populate Events Here
            for (var i = 0; i < 15; i++)
            {
                events.Add(
                    new Event()
                    {
                        EventDate = RandomDateTime(),
                        EventName = "Performance: " + i
                    });
            }
            return events;//new JavaScriptSerializer().Serialize(events);
            //events.Add(new Event(){

            
        }

        private DateTime RandomDateTime()
        {
            DateTime dt = DateTime.Today;
            int i = _r.Next(90);
            dt = dt.AddDays(double.Parse(i.ToString()));
            return dt;
        }
    }
}