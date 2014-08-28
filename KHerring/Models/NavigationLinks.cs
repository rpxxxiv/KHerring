using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KHerring.Models
{
    public class NavigationLinks
    {
        public List<NavigationLink> GetLinks()
        {
            List<NavigationLink> navLinks = new List<NavigationLink>();
                navLinks.Add(new NavigationLink() { Title = "Home", View = "HomePage", ControllerName = "Home" });
                navLinks.Add(new NavigationLink() { Title = "About Us", View = "CheckItOut", ControllerName = "Home" });
                navLinks.Add(new NavigationLink() { Title = "Blog", View = "HomePage", ControllerName = "Home" });
                navLinks.Add(new NavigationLink() { Title = "Media", View = "CheckItOut", ControllerName = "Home" });
                navLinks.Add(new NavigationLink() { Title = "Contact Us", View = "HomePage", ControllerName = "Home" });
            return navLinks;
        }

       
    }
}