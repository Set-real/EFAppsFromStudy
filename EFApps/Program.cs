﻿using EFApps;
using System;
using System.Linq;
public class Program
{
    static void Main(string[] args)
    {
        using (var db = new ApplicationContext())
        {
            var user1 = new User { Name = "Arthur", Role = "Admin" };
            var user2 = new User { Name = "klim", Role = "User" };

            db.Users.Add(user1);
            db.Users.Add(user2);
            db.SaveChanges();
        }
    }
}