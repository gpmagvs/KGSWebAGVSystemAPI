﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace KGSWebAGVSystemAPI.Models;

public partial class TrackHistory
{
    public DateTime RecordTime { get; set; }

    public int Agvid { get; set; }

    public double? LocationX { get; set; }

    public double? LocationY { get; set; }
}