using ServiceStack;

namespace ScaleServiceStackConsole.ServiceModel
{
    //================== { Test } ==================//
    [Route("/hello")]
    [Route("/hello/{Name}")]
    public class Hello : IReturn<HelloResponse>
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }
    //================= { Port Info } ================//
    [Route("/PortInfo/{Data}", Verbs = "GET")]

    public class PortInfo: IReturn<PortInfoReturn>
    {
       public string Data { get; set; }
    }
    public class PortInfoReturn
    {
        public string PortResult { get; set; }
    }

    //=============== { Scale Weight } ==============//
    [Route("/ScaleWeight")]
    [Route("/ScaleWeight/{Data}")]
    public class ScaleWeight: IReturn<ScaleWeightResponse>
    {
        public string Weight { get; set; }
    }

    public class ScaleWeightResponse
    {
        public string ScaleDataResult { get; set; }
    }
    //================ { NextButton } ===============//

    [Route("/NextIngredient", Verbs = "GET")]
    public class NextIngredient: IReturn<NextIngredientResponse>
    {
        //
    }
    public class NextIngredientResponse
    {
        public string IngredientSwitched { get; set; }
    }
    //=============== { Done Mixing } ===============//

    [Route("/DoneMixing/{Done}")]
    public class DoneMixing: IReturn<DoneMixingReponse>
    {
        public string Done { get; set; }
    }
    public class DoneMixingReponse
    {
        public string DoneResult { get; set; }
    }


}
