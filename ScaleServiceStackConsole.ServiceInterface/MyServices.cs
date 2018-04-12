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
        //================ { Port Info } ===============//

        public object Any(PortInfo request)
        {
            return new PortInfoReturn { PortResult = $"{request.Data}" };
        }
        //=============== { Scale Weight } ==============//

        public object Any(ScaleWeight request)
        {
            string ScaleDataResult = "newWeight";
            return ScaleDataResult;

        }
        //================ { NextButton } ===============//

        public object Any(NextIngredient request)
        {
            string IngredientSwitched = "Finished";
            return IngredientSwitched;
        }
        //=============== { Done Mixing } ===============//

        public object Any(DoneMixing request)
        {
            return new DoneMixingReponse { DoneResult = $"{request.Done}" };
        }
    }
}
