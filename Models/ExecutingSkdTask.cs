﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace KGSWebAGVSystemAPI.Models
{
    public partial class ExecutingSkdTask
    {
        public string CommandID { get; set; }
        public string Bay { get; set; }
        public int? Status { get; set; }
        public DateTime? Schedule_Time { get; set; }
        public int? AGVID { get; set; }
        public string MeasurePoints { get; set; }
        public string PatrolPoints { get; set; }
        public string FinishedPoints { get; set; }
        public double? Progress { get; set; }
        public DateTime? StartTime { get; set; }
    }
}