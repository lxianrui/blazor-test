using System;
using System.ComponentModel;

namespace BlazorApp2.Data
{
    public class UserInfo
    {
        [DisplayName("编号")]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }
    }
}