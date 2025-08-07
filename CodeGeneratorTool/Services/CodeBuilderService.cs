using CodeGeneratorTool.Models;

namespace CodeGeneratorTool.Services
{
    public class CodeBuilderService
    {
        public string GenerateController(CodeGenerationInput input)
        {
            var asyncKeyword = input.IsAsync ? "async Task" : "ActionResult";
            var methodName = input.IsAsync ? "Get" + input.ControllerName + "Async" : "Get" + input.ControllerName;

            return
    $@"[HttpPost(""{input.RouteName}"")]
        public {asyncKeyword}<{input.ReturnType}> {methodName}([{input.ParameterSource}] {input.ParameterType} {input.ParameterName})
        {{
    // Your logic here
        return {(input.IsAsync ? "await Task.FromResult(default(" + input.ReturnType + "))" : "Ok()")};
        }}";
        }
    }

}
