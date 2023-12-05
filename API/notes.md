Service lifetime in dependency injection is determined by scoped, Transient and Singleton.

Scoped: instance is created for each scope, equating to single request of web application . Database context is example of Scoped, a new instance of service will be created only when web request comes in.

Transient:  A new instance is created everytime request comes and it is confined to the method being accessed. 
It is lighweight and stateless. It is disposed of as soon as service or method request is ended. Data processing(likedata validation or transformation) is Transient service.

Singleton: instance of service is created in entire lifetime of application. This instance of service is shared
in the application. Singleton is used for services that are requried globally in entire application.
Logging service is the example of singleton, which need to be active all along the lifetime of application.