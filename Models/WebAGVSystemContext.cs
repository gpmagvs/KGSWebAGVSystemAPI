﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KGSWebAGVSystemAPI.Models
{
    public partial class WebAGVSystemContext : DbContext
    {
        public WebAGVSystemContext()
        {
        }

        public WebAGVSystemContext(DbContextOptions<WebAGVSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AGVInfo> AGVInfo { get; set; }
        public virtual DbSet<AGVRemoteSetting> AGVRemoteSetting { get; set; }
        public virtual DbSet<AlarmLog> AlarmLog { get; set; }
        public virtual DbSet<BatterySet> BatterySet { get; set; }
        public virtual DbSet<ExecutingSkdTask> ExecutingSkdTask { get; set; }
        public virtual DbSet<ExecutingTask> ExecutingTask { get; set; }
        public virtual DbSet<InstrumentMeasureResult> InstrumentMeasureResult { get; set; }
        public virtual DbSet<MapComparison> MapComparison { get; set; }
        public virtual DbSet<MeasureInfo> MeasureInfo { get; set; }
        public virtual DbSet<OccurringAlarm> OccurringAlarm { get; set; }
        public virtual DbSet<PMHistory> PMHistory { get; set; }
        public virtual DbSet<PMSetting> PMSetting { get; set; }
        public virtual DbSet<PathInfo> PathInfo { get; set; }
        public virtual DbSet<ProductInfo> ProductInfo { get; set; }
        public virtual DbSet<RunStatusChange> RunStatusChange { get; set; }
        public virtual DbSet<SMSPhoneNo> SMSPhoneNo { get; set; }
        public virtual DbSet<SkdTask> SkdTask { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TrafficTask> TrafficTask { get; set; }
        public virtual DbSet<UserGroup> UserGroup { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<UserLoginLog> UserLoginLog { get; set; }
        public virtual DbSet<ver> ver { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AGVInfo>(entity =>
            {
                entity.HasKey(e => e.AGVID);

                entity.Property(e => e.AGVID).ValueGeneratedNever();

                entity.Property(e => e.AGVName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AlarmDescription).IsUnicode(false);

                entity.Property(e => e.CSTID)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DoTaskName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.E82VehicleState)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AGVRemoteSetting>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<AlarmLog>(entity =>
            {
                entity.HasKey(e => new { e.OccuredDate, e.AlarmCode });

                entity.Property(e => e.OccuredDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OPID)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TaskName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BatterySet>(entity =>
            {
                entity.HasKey(e => e.AGVID)
                    .HasName("PK_BatterySet_1");

                entity.Property(e => e.AGVID).ValueGeneratedNever();
            });

            modelBuilder.Entity<ExecutingSkdTask>(entity =>
            {
                entity.HasKey(e => e.CommandID)
                    .HasName("PK__Executin__6B4108E6FC5A9447");

                entity.Property(e => e.CommandID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bay)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinishedPoints)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MeasurePoints)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatrolPoints)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Schedule_Time).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExecutingTask>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcquireTime).HasColumnType("datetime");

                entity.Property(e => e.ActionType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AssignUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CSTID)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DepositTime).HasColumnType("datetime");

                entity.Property(e => e.FromStation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                //entity.Property(e => e.FromStationName)
                //    .HasMaxLength(30)
                //    .IsUnicode(false);

                entity.Property(e => e.Receive_Time).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.ToStation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                //entity.Property(e => e.ToStationName)
                //    .HasMaxLength(30)
                //    .IsUnicode(false);
            });

            modelBuilder.Entity<InstrumentMeasureResult>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Acetone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CommandID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Decibel)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DustParticles1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DustParticles2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DustParticles3)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DustParticles4)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DustParticles5)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DustParticles6)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Humidity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IPA)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Illuminance)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PID)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TVOC)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Temperature)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<MapComparison>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<MeasureInfo>(entity =>
            {
                entity.HasKey(e => e.CommandID)
                    .HasName("PK__MeasureI__6B4108E638B57D6A");

                entity.Property(e => e.CommandID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bay)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Points)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Receive_Time).HasColumnType("datetime");

                entity.Property(e => e.SuccessPoints)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OccurringAlarm>(entity =>
            {
                entity.HasKey(e => new { e.OccuredDate, e.AlarmCode });

                entity.Property(e => e.OccuredDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Location)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OPID)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TaskName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PMHistory>(entity =>
            {
                entity.HasKey(e => new { e.AGVID, e.PMDate })
                    .HasName("PK__PMHistor__BF79F47E5B8B69E4");

                entity.Property(e => e.PMDate).HasColumnType("datetime");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PMSetting>(entity =>
            {
                entity.HasKey(e => e.AGVID)
                    .HasName("PK__PMSettin__FCDD6E55EF600E4B");

                entity.Property(e => e.AGVID).ValueGeneratedNever();
            });

            modelBuilder.Entity<PathInfo>(entity =>
            {
                entity.HasKey(e => new { e.ChangeTime, e.AGVID })
                    .HasName("PK__PathInfo__DBD97340F2E9DD81");

                entity.Property(e => e.ChangeTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductInfo>(entity =>
            {
                entity.Property(e => e.ID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommandID)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Frame)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InRackLDTime).HasColumnType("datetime");

                entity.Property(e => e.LayerNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotID)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutRackOPID)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OutRackULDTime).HasColumnType("datetime");

                entity.Property(e => e.OvenLDTime).HasColumnType("datetime");

                entity.Property(e => e.OvenULDTime).HasColumnType("datetime");

                entity.Property(e => e.PartID)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Receive_Time).HasColumnType("datetime");

                entity.Property(e => e.RecipeID)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialID)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Stamp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RunStatusChange>(entity =>
            {
                entity.HasKey(e => new { e.ChangeTime, e.AGVID });

                entity.Property(e => e.ChangeTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SMSPhoneNo>(entity =>
            {
                entity.HasKey(e => e.PhoneNumber)
                    .HasName("PK__SMSPhone__85FB4E39063540F8");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SkdTask>(entity =>
            {
                entity.HasKey(e => e.CommandID)
                    .HasName("PK__SkdTask__6B4108E6FBEE8DDE");

                entity.Property(e => e.CommandID)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bay)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FailedPoints)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MeasurePoints)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatrolPoints)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Schedule_Time).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcquireTime).HasColumnType("datetime");

                entity.Property(e => e.ActionType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AssignUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CSTID)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CancelUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepositTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FailReason).HasColumnType("text");

                entity.Property(e => e.FromStation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                //entity.Property(e => e.FromStationName)
                //    .HasMaxLength(30)
                //    .IsUnicode(false);

                entity.Property(e => e.Receive_Time).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.ToStation)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                //entity.Property(e => e.ToStationName)
                //    .HasMaxLength(30)
                //    .IsUnicode(false);

                entity.Property(e => e.TotalTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrafficTask>(entity =>
            {
                entity.HasKey(e => e.AGVID);

                entity.Property(e => e.AGVID).ValueGeneratedNever();

                entity.Property(e => e.BookingPath)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.CrossPoint)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullPath)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.InvolvePoint)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.MessageCH).IsUnicode(false);

                entity.Property(e => e.ShortPath)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.StartPos)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TargetPos)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.HasKey(e => e.UserGroup1);

                entity.Property(e => e.UserGroup1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserGroup");

                entity.Property(e => e.Functions)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserGroup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserLoginLog>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.DateTime });

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ver>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.version)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}