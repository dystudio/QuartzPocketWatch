#region License
/* 
 * All content copyright Grant Pexsa, unless otherwise indicated. All rights reserved. 
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not 
 * use this file except in compliance with the License. You may obtain a copy 
 * of the License at 
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0 
 *   
 * Unless required by applicable law or agreed to in writing, software 
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT 
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the 
 * License for the specific language governing permissions and limitations 
 * under the License.
 * 
 */
#endregion

using System;
using System.Collections.Generic;
using Quartz;

namespace QuartzPocketWatch.Plugin.Models
{
    public class TriggerModel
    {
        public TriggerModel(ITrigger trigger)
        {
            TriggerGroupName = trigger.Key.Group;
            TriggerName = trigger.Key.Name;
            StartTime = trigger.StartTimeUtc;
            EndTime = trigger.EndTimeUtc;
            FinalFireTime = trigger.FinalFireTimeUtc;
            Priority = trigger.Priority;
            Description = trigger.Description;
            JobDataMap = trigger.JobDataMap;
            NextFireTime = trigger.GetNextFireTimeUtc();
        }

        public string TriggerGroupName { get; private set; }
        public string TriggerName { get; private set; }
        public DateTimeOffset StartTime { get; private set; }
        public DateTimeOffset? EndTime { get; private set; }
        public DateTimeOffset? FinalFireTime { get; private set; }
        public DateTimeOffset? NextFireTime { get; private set; }
        public int Priority { get; private set; }
        public string Description { get; private set; }
        public IDictionary<string, Object> JobDataMap { get; set; }
    }
}