open System
open System.Threading

open Suave
open Suave.Successful
open Suave.Web


[<EntryPoint>]
let main argv =
    let cts = new CancellationTokenSource()
    let conf = { defaultConfig with cancellationToken = cts.Token }

    let listening, server =
        startWebServerAsync conf (Successful.OK "Hello World")

    Async.Start(server, cts.Token)

startWebServer defaultConfig (OK "Hello World")
