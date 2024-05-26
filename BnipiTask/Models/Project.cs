﻿namespace BnipiTask.Models
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Cipher { get; set; }
        public string Name { get; set; }

        //navigation
        public ICollection<DesignObject> DesignObjects { get; set; }
    }
}
