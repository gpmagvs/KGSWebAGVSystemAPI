﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace KGSWebAGVSystemAPI.Models
{
    public partial class ExecutingTask
    {
        public string Name { get; set; }
        public int Status { get; set; }
        public DateTime Receive_Time { get; set; }
        public int? FromStationId { get; set; }
        public int? ToStationId { get; set; }
        public string FromStation { get; set; }
        public string ToStation { get; set; }
        public string FromStationName { get; set; }
        public string ToStationName { get; set; }
        public string ActionType { get; set; }
        public int AGVID { get; set; }
        public string CSTID { get; set; }
        public int Priority { get; set; }
        public int RepeatTime { get; set; }
        public int ExeVehicleID { get; set; }
        public DateTime? StartTime { get; set; }
        public double Distance { get; set; }
        public DateTime? AcquireTime { get; set; }
        public DateTime? DepositTime { get; set; }
        public string AssignUserName { get; set; }
        public int? CSTType { get; set; }
        public int? FromStationPortNo { get; set; }
        public int? ToStationPortNo { get; set; }
        public int? ExeVehiclePos { get; set; }
        public int? CSTLayers { get; set; }
    }
}