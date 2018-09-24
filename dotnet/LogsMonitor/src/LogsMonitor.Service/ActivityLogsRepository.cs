using System.Collections.Generic;

using LogsMonitor.Core.Model;
using LogsMonitor.Core.Abstractions;

namespace LogsMonitor.Service
{
    public sealed class ActivityLogsRepository : IActivityLogsRepository
    {
        public IEnumerable<ActivityLogEntry> GetActivityLogs()
        {
            return new ActivityLogEntry [] {
                new ActivityLogEntry {
                    Who = new User {
                        GivenName = "Julia",
                        MiddleName = "Miranda",
                        LastName = "Hernandez",
                        EmailAddress = "jhernandez@buynlarge.com"
                    },
                    SystemArea = "Invoicing",
                    UserAction = "Process Invoice"
                },
                new ActivityLogEntry {
                    Who = new User {
                        GivenName = "Peter",
                        MiddleName = "Federick",
                        LastName = "Floyd",
                        EmailAddress = "pfloyd@buynlarge.com"
                    },
                    SystemArea = "User Management",
                    UserAction = "Remove User"
                },
                new ActivityLogEntry {
                    Who = new User {
                        GivenName = "Samuel",
                        LastName = "Holopalukaiko",
                        EmailAddress = "sholo@buynlarge.com"
                    },
                    SystemArea = "User Management",
                    UserAction = "Add User"
                },
                new ActivityLogEntry {
                    Who = new User {
                        GivenName = "Patrik",
                        LastName = "Johnson",
                        EmailAddress = "pjohnson@buynlarge.com"
                    },
                    SystemArea = "Inventory",
                    UserAction = "Query Item"
                },
                new ActivityLogEntry {
                    Who = new User {
                        GivenName = "Joseph",
                        LastName = "Fitzpatrick",
                        EmailAddress = "jfitzpatrick@buynlarge.com"
                    },
                    SystemArea = "Inventory",
                    UserAction = "Pull Monthly Report"
                }
            };
        }
    }
}