using System;
using ServiceStack;
using ScaleServiceStackConsole.ServiceModel;

namespace ScaleServiceStackConsole.ServiceInterface
{
    public class MyServices : Service
    {
        //================== { Test } ==================//

        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
        //================= { Port Info } ================//

        public object Any(PortInfo request)
        {
            return new PortInfoReturn { PortResult = $"{request.Data}" };
        }

        //=============== { Scale Weight }==============//

        public object Any(ScaleWeight request)
        {
            return new ScaleWeightResponse { ScaleDataResult = $"{ request.Data }" };
        }

    }
}
