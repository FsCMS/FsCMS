#I @"../packages/Suave/lib/net40/"
#r @"Suave.dll"

open Suave                 // always open suave
open Suave.Successful      // for OK-result
open Suave.Web             // for config

startWebServer defaultConfig (OK "Hello World!")
