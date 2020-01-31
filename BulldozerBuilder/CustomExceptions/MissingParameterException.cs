using System;
using System.Collections.Generic;
using System.Text;

namespace AICorporation.Bulldozer.BulldozerBuilderLibrary.CustomExceptions
{
    public class MissingParameterException:Exception
    {
        private string globalParamterName;
        private string globalFunctionName;

        public MissingParameterException(string parameterName, string functionName) :base()
        {
            globalParamterName = parameterName;
            globalFunctionName = functionName;
        }
        public MissingParameterException(string parameterName, string functionName, string message):base(message)
        {
            globalParamterName = parameterName;
            globalFunctionName = functionName;
        }
        public MissingParameterException(string parameterName, string functionName, string message, Exception innerException) : base(message,innerException)
        {
            globalParamterName = parameterName;
            globalFunctionName = functionName;
        }
        public string ParameterName { get { return globalParamterName; } }
        public string FunctionName { get { return globalFunctionName; } }
        public override string ToString()
        {
            return $"Missing Parameter {globalParamterName} in Function {FunctionName} {base.ToString()} ";
        }

    }
}
