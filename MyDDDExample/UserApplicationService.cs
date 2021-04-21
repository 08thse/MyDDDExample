using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDDExample
{
    public class UserApplicationService
    {
        private readonly IUserRepository userRepository;
        private readonly UserService userService;

        public UserApplicationService(IUserRepository userRepository, UserService userService)
        {
            this.userRepository = userRepository;
            this.userService = userService;
        }

        public void Register(string name)
        {
            var user = new User(new UserName(name));

            if (userService.Exists(user))
            {
                // throw new CanNotRegisterUserException(user, "User already exist.");
            }
        }

        public User Get(string userId)
        {
            var targetId = new UserId(userId);
            var user = userRepository.Find(targetId);
            return user;
        }

        public void Update(string userId, string name)
        {

        }
    }
}
