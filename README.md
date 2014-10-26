MvcDonutCaching.MongoDBOutputCache
==================================

Proveedor de cache de ASP.NET MVC para su uso junto a MvcDonutCaching

Para configurarlo es necesario agregar lo siguiente al fichero web.config

<pre><code><caching>
      <outputCache defaultProvider="AspNetMongoDB">
        <providers>
          <add name="AspNetMongoDB" type="MongoDBOutputCache.MongoDBOutputCacheProvider, MongoDBOutputCache" />
        </providers>
      </outputCache>
    </caching>
</code></pre>

Además, es necesario agregar las siguientes claves en AppSettings:

<pre><code><add key="MongoDBOutputCacheProviderConnectionString" value="mongodb://user:password@yourhost/yourdatabase" />
    <add key="MongoDBOutputCacheProviderCollection" value="yourcollection" /></code></pre>

La cadena de conexión de MongoDB, podría o on incluir autenticación, es decir, user:password@ es opcional.