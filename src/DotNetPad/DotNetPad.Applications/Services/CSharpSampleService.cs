﻿using System;
using System.ComponentModel.Composition;
using System.IO;

namespace Waf.DotNetPad.Applications.Services
{
    [Export(typeof(ICSharpSampleService))]
    internal class CSharpSampleService : ICSharpSampleService
    {
        public Lazy<string> NullConditionalOperator => new Lazy<string>(() => GetSampleCode("NullConditionalOperator.cs"));
        
        public Lazy<string> NameOfOperator => new Lazy<string>(() => GetSampleCode("NameOfOperator.cs"));

        public Lazy<string> AutoPropertyInitializers => new Lazy<string>(() => GetSampleCode("AutoPropertyInitializers.cs"));

        public Lazy<string> StringInterpolation => new Lazy<string>(() => GetSampleCode("StringInterpolation.cs"));


        internal static string GetSampleCode(string sampleFileName)
        {
            using (Stream stream = typeof(CSharpSampleService).Assembly.GetManifestResourceStream("Waf.DotNetPad.Applications.Samples." + sampleFileName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
