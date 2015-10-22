# FsCMS #

An F#-based CMS.

## Frameworks.NetAPI ##
* Katana
* OWIN
* HttpListener (raw configuration)

## Frameworks.Lower ##
* Suave.IO
* Freya

## Frameworks.Middle ##
* WebSharper

## Templating ##
* FsRazor (needs love to update to current standards)
    * Include the use of HttpHelpers
    * Provide familiarity
* DotLiquid (markdown style)

## Front-End vs. Back-End JS Library ##
* Back-end
    * Run as SPA (preferred, higher responsivity)
    * Mobile-friendly
* Front-End
    * SPA vs. MPA support
    * considerations for routing
    * Library Support
        * reactjs
        * knockoutjs
        * angularjs
        * (material-based JS library *look up name*)

## Application Flow ##
1. Front-end library would handle calls to API
2. Start off as supporting MPAs with later adding support for SPAs (lift into API)
3. Routing handled by framework

## Database Support ##
* Create abstracted DAL to include support for:
    * Filesystem databases
    * NoSQL databases
        * MongDB
        * CouchDB
    * SQL databases
        * MSSQL
        * MySQL
        * PostgreSQL
    

## Features ##
* Caching

