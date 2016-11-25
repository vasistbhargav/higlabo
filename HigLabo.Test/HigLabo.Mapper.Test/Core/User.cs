﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HigLabo.Mapper.Test
{
    public class User
    {
        public String Value { get; set; }
        public String Name { get; set; }
        
        public Int32 Int32 { get; set; }
        public Int32? Int32Nullable { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime? DateTimeNullable { get; set; }
        public Decimal Decimal { get; set; }
        public Decimal? DecimalNullable { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public DayOfWeek? DayOfWeekNullable { get; set; }

        public MapPoint MapPoint { get; set; }
        public Vector2 Vector2 { get; set; }
        public User ParentUser { get; set; }
        public List<User> Users { get; set; }
        public String[] Tags { get; set; }

        public User()
            : this("TestUser")
        {
        }
        public User(String name)
        {
            this.Name = name;
            this.Int32 = 3;
            this.DateTime = new DateTime(2014, 12, 16);
            this.Decimal = 20.4m;
            this.DayOfWeek = DayOfWeek.Monday;

            this.Vector2 = new Vector2(2m, 4m);
            this.MapPoint = new MapPoint();

            this.Users = new List<User>();
        }
    }
    public class UserFratten
    {
        public String Value { get; set; }
        public String Name { get; set; }

        public Int32 Int32 { get; set; }
        public Int32? Int32Nullable { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime? DateTimeNullable { get; set; }
        public Decimal Decimal { get; set; }
        public Decimal? DecimalNullable { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public DayOfWeek? DayOfWeekNullable { get; set; }

        public Decimal Longitude { get; set; }
        public Decimal Latitude { get; set; }
        public Decimal X { get; private set; }
        public Decimal Y { get; private set; }

        public String Users { get; set; }
        public String Tags { get; set; }
    }
    public class VipUser : User
    {
        public Int32 Grade { get; set; }

        public VipUser()
        {
        }
        public VipUser(String name)
            : base(name)
        {

        }
    }
    public class UserListInfo
    {
        public String GroupName { get; set; }
        public List<User> Users { get; set; }

        public UserListInfo()
        {
            this.Users = new List<User>();
        }
    }
    public class VipUserListInfo
    {
        public String GroupName { get; set; }
        public List<VipUser> Users { get; set; }

        public VipUserListInfo()
        {
            this.Users = new List<VipUser>();
        }
    }
}
