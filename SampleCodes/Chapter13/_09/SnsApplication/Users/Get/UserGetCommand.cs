﻿namespace _09.SnsApplication.Users.Get
{
    public class UserGetCommand
    {
        public UserGetCommand(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}
