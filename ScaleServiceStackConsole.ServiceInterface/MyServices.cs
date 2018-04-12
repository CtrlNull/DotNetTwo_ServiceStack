﻿using System;
using ServiceStack;
using ScaleServiceStackConsole.ServiceModel;

namespace ScaleServiceStackConsole.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
