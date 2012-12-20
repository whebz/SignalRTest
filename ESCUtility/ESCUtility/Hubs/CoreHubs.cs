using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;

namespace ESCUtility.Hubs
{
    public class CoreHubs : Hub
    {
        public void NotifyAdminOnUserJoined(string name)
        {
            Clients.Others.joined(name, DateTime.Today.ToString());
        }

        public void LogIn(string userName, string clientID)
        {

        }

        public void JoinGroup(string groupName, string userName, string clientId)
        {
            
        }

        public override Task OnDisconnected()
        {
            return base.OnDisconnected();
        }

    }
}