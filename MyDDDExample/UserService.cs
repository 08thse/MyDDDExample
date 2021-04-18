using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDDExample
{
    public class UserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool Exists(User user)
        {
            var duplicatedUser = userRepository.Find(user.Name);
            return (duplicatedUser != null);
        }
    }
}
