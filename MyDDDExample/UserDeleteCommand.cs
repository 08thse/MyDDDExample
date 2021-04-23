using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDDExample
{
    public class UserDeleteCommand
    {
        // 「Update を実行するための情報を格納するオブジェクト」というイメージを持った

        public string Id { get; }
        public string Name { get; }
        public string MailAddress { get; }

        public UserDeleteCommand(string id, string name = null, string mail = null)
        {
            Id = id;
            Name = name;
            MailAddress = mail;
        }
    }
}
