using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using BlazorRZ10012Repro;

namespace BlazorRZ10012Repro.Components
{
    //#review Uncomment the //: ComponentBase to observe that the RZ10012 warning goes away with a code behind that explicitly inherits from ComponentBase
    public partial class SampleBaseComponent //: ComponentBase
    {
        protected virtual int SomeCount => 5;
    }
}