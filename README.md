stmpago
=======

Exemplo em C# de como consultar o status de um determinado pagamento no Mercado Pago

Adicionar um arquivo App.Config com o seguinte formato:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5" />
    </startup>
  <appSettings>
    <add key="CLIENT_ID" value="" />
    <add key="CLIENT_SECRET" value="" />
  </appSettings>
</configuration>
```

As credenciais podem ser obtidas em: https://www.mercadopago.com/mlb/ferramentas/aplicacoes

=====
Checagem de status de pagamento - Mercado pago
