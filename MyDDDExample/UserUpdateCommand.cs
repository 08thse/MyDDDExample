using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDDExample
{
    public class UserUpdateCommand
    {
        public string Id { get; }
        public string Name { get; }
        public string MailAddress { get; }
        
        public UserUpdateCommand(string id, string name = null, string mail = null)
        {
            Id = id;
            Name = name;
            MailAddress = mail;
        }
    }
}
