using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDDExample
{
    public interface IUserRepository
    {
        User Find(UserId id);
        User Find(UserName name);
        void Save(User user);
        void Delete(User user);
    }
}
