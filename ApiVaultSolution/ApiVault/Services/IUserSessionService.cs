﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiVault.Services
{
    // Dependency injection interface for user session
    public interface IUserSessionService
    {
        string Username { get; set; }
    }

    // User session implementation
    public class UserSessionService : IUserSessionService
    {
        // Interface variables
        public string Username {  set; get; }
    }
}
