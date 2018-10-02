using System;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using CacheCow.Server.Core.Mvc;

using LogsMonitor.Core.Abstractions;

namespace LogsMonitor.Host.Controllers
{
    using Models;

    public sealed class ActivityLogsController : Controller
    {
        private readonly IActivityLogsService _logsService;

        public ActivityLogsController(IActivityLogsService logsService)
            => _logsService = logsService ?? throw new ArgumentNullException(nameof(logsService));

        [HttpGet]
        [HttpCacheFactory(20)]
        public async Task<ActionResult<IEnumerable<ActivityLogEntryViewModel>>> Index()
        {
            await Task.Delay(2000);
            
            return Json(_logsService.GetActivityLogs().Select(l => new ActivityLogEntryViewModel {
                EventTimestamp = string.Concat(l.EventTimestamp.ToShortDateString(), " ", l.EventTimestamp.ToShortTimeString()),
                UserIdentity = l.Who.ToString(),
                SystemArea = l.SystemArea,
                UserAction = l.UserAction
            }));
        }
    }
}
