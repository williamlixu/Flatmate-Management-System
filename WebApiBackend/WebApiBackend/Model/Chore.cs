﻿using System;
using System.Collections.Generic;
using WebApiBackend.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace WebApiBackend.Model
{
    public class Chore : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public User AssignedUser { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }
        public bool Recurring{ get; set; }
    }
}
