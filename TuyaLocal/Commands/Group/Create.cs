﻿namespace TuyaLocal.Commands.Group
{
    using System.ComponentModel.DataAnnotations;

    public class Create
    {
        public Create(string name)
        {
            Name = name;
        }

        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string Name { get; }
    }
}
