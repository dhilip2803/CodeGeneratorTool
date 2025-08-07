namespace CodeGeneratorTool.Models
{
    public class CodeGenerationInput
    {
        public string ControllerName { get; set; }
        public string ParameterName { get; set; }
        public string ReturnType { get; set; }
        public string ParameterType { get; set; }
        public bool IsAsync { get; set; }
        public string RouteHeader { get; set; }
        public string RouteName { get; set; }
        public string ParameterSource { get; set; } 
    }

}
