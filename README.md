# FsCMS #

[![Join the chat at https://gitter.im/FsCMS/FsCMS](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/FsCMS/FsCMS?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![Build status](https://ci.appveyor.com/api/projects/status/8wgpay9i8ylfmmr7?svg=true)](https://ci.appveyor.com/project/JeroldHaas/fscms)


An F#-based CMS with a high level of modularity utilizing OWIN.

## Pluggable Architecture ##
Note that a combination where the client-server boundary between WebSharper client-generated code and other back-ends aren't _yet_ supported (progress underway), however The CMS should have a modular architecture permitting the mixture of items in the following categories.

### Server ###
* Kestrel
* Suave
* HttpListener (raw configuration)

### Framework ###
* Suave
* Katana
* Freya
* WebSharper
* Nancy
* Gluon

### API Boundary ###
* Gluon
* WebSharper
* Media-Type

### Client ###
* JS
* TypeScript
* WebSharper
* FunScript

### Templating ###
* FsRazor (needs love to update to current standards)
    * Include the use of HttpHelpers
    * Provide familiarity
* DotLiquid (markdown style)
* WebSharper
* SignalR

### Front-End vs. Back-End JS Library ###
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

### Database Support ###
* Create abstracted DAL to include support for:
    * Filesystem databases
    * NoSQL databases
        * MongDB
        * CouchDB
        * RavenDB
    * SQL databases
        * MSSQL
        * MySQL
        * PostgreSQL


## Features ##
* Caching
