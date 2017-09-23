module FsCms.Server.Suave

open System
open System.Threading
open Suave

[<EntryPoint>]
let main argv =
    let cts = new CancellationTokenSource()
    let config = {
        defaultConfig with cancellationToken = cts.Token }
    let listening, server = startWebServerAsync config (Successful.OK "Hello World")

    Async.Start (server, cts.Token)
    printfn "Make requests now"
    Console.ReadKey true |> ignore

    cts.Cancel()

    0
