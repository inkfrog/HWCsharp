HWCsharp - a C# Encapsulation of the Highwire API
===============================================

Highwire - online stores
------------------------

Highwire makes it easy to create online stores and allows for easy multi-channel selling.

> Sell on your own online store, eBay, Facebook and mobile all from one place. Whether
> you're new to selling online or just getting started, Highwire provides all the tools
> needed to set up and manage a successful online store.

Highwire is available at http://www.highwire.com/


Highwire -- The API
-------------------

The Highwire API and API documentation are available for Highwire here: http://docs.highwire.com/apiv2/rest/

Usage Example: Categories
-------------------------

All requests and responses handled by HWCSharp are encapsulated by a corresponding request or response object. Before the first time your app calls
HWCSharp, the library must be initialized with a developer api key.

```c#

HighwireAPI.APIKey = ConfigurationManager.AppSettings["MyAPIKey"]; //A static initializer. Only needs to be done once per application instance

int storeid = 12451;

GetAllCategoriesResponse allCatsResponse = HighwireAPI.DoRequest<GetAllCategoriesRequest, GetAllCategoriesResponse>(new GetAllCategoriesRequest(storeid));

```