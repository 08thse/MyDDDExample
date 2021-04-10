using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDDExample
{
    class User
    {
        private readonly UserId id;
        private String name;

        public User(UserId id, string name)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            this.id = id;

            ChangeUserName(name);
        }

        private void ChangeUserName(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (name.Length < 3) throw new ArgumentException("Username must be >3.", nameof(name);

            this.name = name;
        }
    }
}
