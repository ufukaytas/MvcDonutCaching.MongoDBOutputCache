MvcDonutCaching.MongoDBOutputCache
==================================

Proveedor de cache de ASP.NET MVC para su uso junto a MvcDonutCaching

Para configurarlo es necesario agregar lo siguiente al fichero web.config

    <caching>
      <outputCache defaultProvider="AspNetMongoDB">
        <providers>
          <add name="AspNetMongoDB" type="MongoDBOutputCache.MongoDBOutputCacheProvider, MongoDBOutputCache" />
        </providers>
      </outputCache>
    </caching>

Además, es necesario agregar las siguientes claves en AppSettings:

    <add key="MongoDBOutputCacheProviderConnectionString" value="mongodb://localhost" />
    <add key="MongoDBOutputCacheProviderDatabaseName" value="aspnet" />
    <add key="MongoDBOutputCacheProviderCollectionName" value="outputCache" />