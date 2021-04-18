using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDDExample
{
    public class User
    {
        public UserId Id { get; }
        public UserName Name { get; private set; }


        public User(UserName name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            Id = new UserId(Guid.NewGuid().ToString());
            Name = name;
        }

        public User(UserId id, UserName name)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            if (name == null) throw new ArgumentNullException(nameof(name));
            Id = id;
            Name = name;
        }

        private void ChangeName(UserName name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            Name = name;
        }
    }

    public class UserId
    {
        public string Value { get; }

        public UserId(string value)
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentException("value is null or empty.");

            Value = value;
        }

        // コンストラクタしかない。値オブジェクト。
    }

    public class UserName
    {
        public string Value { get; }

        public UserName(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            if (value.Length < 3) throw new ArgumentException("Username must be >3.", nameof(value));
            if (20 < value.Length) throw new ArgumentException("Username must be <20.", nameof(value));

            Value = value;

        }

        // コンストラクタしかない。値オブジェクト。
    }
}
