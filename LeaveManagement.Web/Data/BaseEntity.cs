﻿namespace LeaveManagement.Web.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime DateCraeted { get; set; }
        public DateTime DateModified { get; set; }

    }
}
