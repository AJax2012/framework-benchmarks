namespace FsharpBenchmark.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging

[<ApiController>]
[<Route("Home")>]
type HomeController (logger : ILogger<HomeController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get() =
        let response = "Hello FSharp!"
        ActionResult<string>(response)
