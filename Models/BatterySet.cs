﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace KGSWebAGVSystemAPI.Models
{
    public partial class BatterySet
    {
        public int AGVID { get; set; }
        public int? UpperBound { get; set; }
        public int LowerBound { get; set; }
        public double? CheckVoltage { get; set; }
        public int? VoltageDiff { get; set; }
        public int? RecommBound { get; set; }
        public int? DelayChargeByMin { get; set; }
        public int? DeepChargeBound { get; set; }
        public int? ForceVoltage { get; set; }
        public int? DischargeCurrent { get; set; }
    }
}