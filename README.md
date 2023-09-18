# Beam - the C# library for the Beam game development API

The Beam game development API is a service to integrate your game with Beam

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```
<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Beam.Api;
using Beam.Client;
using Beam.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Beam.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

### Connections
Each ApiClass (properly the ApiClient inside it) will create an instance of HttpClient. It will use that for the entire lifecycle and dispose it when called the Dispose method.

To better manager the connections it's a common practice to reuse the HttpClient and HttpClientHandler (see [here](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net) for details). To use your own HttpClient instance just pass it to the ApiClass constructor.

```csharp
HttpClientHandler yourHandler = new HttpClientHandler();
HttpClient yourHttpClient = new HttpClient(yourHandler);
var api = new YourApiClass(yourHttpClient, yourHandler);
```

If you want to use an HttpClient and don't have access to the handler, for example in a DI context in Asp.net Core when using IHttpClientFactory.

```csharp
HttpClient yourHttpClient = new HttpClient();
var api = new YourApiClass(yourHttpClient);
```
You'll loose some configuration settings, the features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings. You need to either manually handle those in your setup of the HttpClient or they won't be available.

Here an example of DI setup in a sample web project:

```csharp
services.AddHttpClient<YourApiClass>(httpClient =>
   new PetApi(httpClient));
```


<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Beam.Api;
using Beam.Client;
using Beam.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: Beam API game key
            config.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("x-api-key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new AssetsApi(httpClient, config, httpClientHandler);
            var assetAddress = "assetAddress_example";  // string | 
            var assetId = "assetId_example";  // string | 
            var profileId = "profileId_example";  // string? |  (optional) 

            try
            {
                // Get a single NFT (e.g. ERC721 / ERC1155)
                GetAssetResponse result = apiInstance.GetAsset(assetAddress, assetId, profileId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AssetsApi.GetAsset: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AssetsApi* | [**GetAsset**](docs/AssetsApi.md#getasset) | **GET** /v1/assets/{assetAddress}/{assetId} | Get a single NFT (e.g. ERC721 / ERC1155)
*AssetsApi* | [**GetContractAssets**](docs/AssetsApi.md#getcontractassets) | **GET** /v1/assets/{assetAddress} | Get all the assets of contract (NFT assets, e.g. ERC721 / ERC1155)
*AssetsApi* | [**GetProfileAssets**](docs/AssetsApi.md#getprofileassets) | **GET** /v1/assets/profiles/{profileId} | Get all the assets of a profile (NFT assets, e.g. ERC721 / ERC1155)
*AssetsApi* | [**GetProfileCurrencies**](docs/AssetsApi.md#getprofilecurrencies) | **GET** /v1/assets/profiles/{profileId}/currencies | Get all the currencies owned by an account (ERC20)
*AssetsApi* | [**GetProfileNativeCurrency**](docs/AssetsApi.md#getprofilenativecurrency) | **GET** /v1/assets/profiles/{profileId}/native | Get the native token balance
*AssetsApi* | [**TransferAsset**](docs/AssetsApi.md#transferasset) | **POST** /v1/assets/profiles/{profileId}/transfer-asset | Transfer an asset (NFT assets, ERC721 / ERC1155)
*AssetsApi* | [**TransferNativeToken**](docs/AssetsApi.md#transfernativetoken) | **POST** /v1/assets/profiles/{profileId}/transfer-native | Transfer the native token (MC)
*AssetsApi* | [**TransferToken**](docs/AssetsApi.md#transfertoken) | **POST** /v1/assets/profiles/{profileId}/transfer-token | Transfer a token (token assets, ERC20)
*ChainApi* | [**Chain**](docs/ChainApi.md#chain) | **GET** /v1/chain | 
*ExchangeApi* | [**ConvertInput**](docs/ExchangeApi.md#convertinput) | **POST** /v1/exchange/profiles/{profileId}/convert/input | Trade an exact amount of `tokenIn` for a minimum amount of `tokenOut`
*ExchangeApi* | [**ConvertToOutput**](docs/ExchangeApi.md#converttooutput) | **POST** /v1/exchange/profiles/{profileId}/convert/output | Swap a maximum amount of `tokenIn` for an exact amount of `tokenOut`
*ExchangeApi* | [**GetQuoteForInput**](docs/ExchangeApi.md#getquoteforinput) | **GET** /v1/exchange/quote/input | Returns the maximum necessary input amount for a token trade, given a desired output amount
*ExchangeApi* | [**GetQuoteForOutput**](docs/ExchangeApi.md#getquoteforoutput) | **GET** /v1/exchange/quote/output | Returns the minimum expected output amount for a token trade, given an input amount
*GameApi* | [**GetGame**](docs/GameApi.md#getgame) | **GET** /v1/game | Get information about your game
*GameApi* | [**RegenerateApiKeys**](docs/GameApi.md#regenerateapikeys) | **POST** /v1/game/regenerate-api-keys | Regenerate API keys
*GameApi* | [**UpdateGame**](docs/GameApi.md#updategame) | **PATCH** /v1/game | Updating name, description and/or coverImageUrl
*HealthApi* | [**Check**](docs/HealthApi.md#check) | **GET** /v1/health | 
*MarketplaceApi* | [**BuyListedAsset**](docs/MarketplaceApi.md#buylistedasset) | **POST** /v1/marketplace/profiles/{profileId}/listing/{orderId} | Buy listed asset
*MarketplaceApi* | [**CancelListing**](docs/MarketplaceApi.md#cancellisting) | **DELETE** /v1/marketplace/profiles/{profileId}/listing/{orderId} | Cancel asset listing
*MarketplaceApi* | [**GetListedAssets**](docs/MarketplaceApi.md#getlistedassets) | **GET** /v1/marketplace | Get all listed assets for a game (NFT assets, e.g. ERC721 / ERC1155)
*MarketplaceApi* | [**GetListedAssetsForProfile**](docs/MarketplaceApi.md#getlistedassetsforprofile) | **GET** /v1/marketplace/profiles/{profileId} | Get all the assets listed by a profile (NFT assets, e.g. ERC721 / ERC1155)
*MarketplaceApi* | [**ListAsset**](docs/MarketplaceApi.md#listasset) | **POST** /v1/marketplace/profiles/{profileId}/listing | List an asset for sale
*ProfilesApi* | [**CreateConnectionRequest**](docs/ProfilesApi.md#createconnectionrequest) | **POST** /v1/profiles/{profileId}/create-connection-request | Generates a challenge which can be encoded in a QR code / app link for the user to take control of the profile
*ProfilesApi* | [**CreateProfile**](docs/ProfilesApi.md#createprofile) | **POST** /v1/profiles | Creating a profile
*ProfilesApi* | [**CreateSignInRequest**](docs/ProfilesApi.md#createsigninrequest) | **POST** /v1/profiles/{profileId}/create-sign-in-request | Generates a challenge which can be encoded in a QR code / app link for the user to sign in to the game
*ProfilesApi* | [**GetAllProfiles**](docs/ProfilesApi.md#getallprofiles) | **GET** /v1/profiles | Getting all profiles
*ProfilesApi* | [**GetProfile**](docs/ProfilesApi.md#getprofile) | **GET** /v1/profiles/{profileId} | Getting information on a profile
*ProfilesApi* | [**UpdateProfile**](docs/ProfilesApi.md#updateprofile) | **PATCH** /v1/profiles/{profileId} | Update a profile
*TransactionsApi* | [**CreateProfileTransaction**](docs/TransactionsApi.md#createprofiletransaction) | **POST** /v1/transactions/profiles/{profileId} | Creating a new transaction on behalf of a profile
*TransactionsApi* | [**GetProfileTransactions**](docs/TransactionsApi.md#getprofiletransactions) | **GET** /v1/transactions/profiles/{profileId} | Get a paginated list of transactions created on behalf of a profile
*TransactionsApi* | [**GetTransaction**](docs/TransactionsApi.md#gettransaction) | **GET** /v1/transactions/{transactionId} | Getting a transaction
*TransactionsApi* | [**GetTransactions**](docs/TransactionsApi.md#gettransactions) | **GET** /v1/transactions | Get a paginated list of transactions from your game


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.BuyAssetRequestInput](docs/BuyAssetRequestInput.md)
 - [Model.BuyAssetResponse](docs/BuyAssetResponse.md)
 - [Model.CancelAssetListingRequestInput](docs/CancelAssetListingRequestInput.md)
 - [Model.Check200Response](docs/Check200Response.md)
 - [Model.Check200ResponseInfoValue](docs/Check200ResponseInfoValue.md)
 - [Model.Check503Response](docs/Check503Response.md)
 - [Model.ConvertTokenRequestInput](docs/ConvertTokenRequestInput.md)
 - [Model.ConvertTokenRespone](docs/ConvertTokenRespone.md)
 - [Model.CreateProfileRequestInput](docs/CreateProfileRequestInput.md)
 - [Model.CreateProfileResponse](docs/CreateProfileResponse.md)
 - [Model.CreateProfileResponseWalletsInner](docs/CreateProfileResponseWalletsInner.md)
 - [Model.CreateTransactionRequestInput](docs/CreateTransactionRequestInput.md)
 - [Model.CreateTransactionRequestInputInteractionsInner](docs/CreateTransactionRequestInputInteractionsInner.md)
 - [Model.CreateTransactionResponse](docs/CreateTransactionResponse.md)
 - [Model.GenerateLinkCodeRequestInput](docs/GenerateLinkCodeRequestInput.md)
 - [Model.GenerateLinkCodeResponse](docs/GenerateLinkCodeResponse.md)
 - [Model.GenerateSignInCodeRequestInput](docs/GenerateSignInCodeRequestInput.md)
 - [Model.GenerateSignInCodeResponse](docs/GenerateSignInCodeResponse.md)
 - [Model.GetAllProfilesResponse](docs/GetAllProfilesResponse.md)
 - [Model.GetAllProfilesResponseDataInner](docs/GetAllProfilesResponseDataInner.md)
 - [Model.GetAllProfilesResponsePagination](docs/GetAllProfilesResponsePagination.md)
 - [Model.GetAssetListingsResponse](docs/GetAssetListingsResponse.md)
 - [Model.GetAssetListingsResponseDataInner](docs/GetAssetListingsResponseDataInner.md)
 - [Model.GetAssetListingsResponseDataInnerNft](docs/GetAssetListingsResponseDataInnerNft.md)
 - [Model.GetAssetResponse](docs/GetAssetResponse.md)
 - [Model.GetAssetResponseAttributesInner](docs/GetAssetResponseAttributesInner.md)
 - [Model.GetAssetResponseContract](docs/GetAssetResponseContract.md)
 - [Model.GetAssetResponseContractAvatar](docs/GetAssetResponseContractAvatar.md)
 - [Model.GetAssetResponseContractHeader](docs/GetAssetResponseContractHeader.md)
 - [Model.GetAssetResponseContractHeaderBackground](docs/GetAssetResponseContractHeaderBackground.md)
 - [Model.GetAssetResponseListing](docs/GetAssetResponseListing.md)
 - [Model.GetAssetResponseOwnershipByAddressesInner](docs/GetAssetResponseOwnershipByAddressesInner.md)
 - [Model.GetAssetResponseOwnershipByAddressesInnerUser](docs/GetAssetResponseOwnershipByAddressesInnerUser.md)
 - [Model.GetAssetResponseOwnershipByAddressesInnerUserProfile](docs/GetAssetResponseOwnershipByAddressesInnerUserProfile.md)
 - [Model.GetAssetsResponse](docs/GetAssetsResponse.md)
 - [Model.GetAssetsResponseDataInner](docs/GetAssetsResponseDataInner.md)
 - [Model.GetChainResponse](docs/GetChainResponse.md)
 - [Model.GetChainResponseNativeCurrency](docs/GetChainResponseNativeCurrency.md)
 - [Model.GetGameResponse](docs/GetGameResponse.md)
 - [Model.GetGameResponseContractsInner](docs/GetGameResponseContractsInner.md)
 - [Model.GetGameResponsePoliciesInner](docs/GetGameResponsePoliciesInner.md)
 - [Model.GetProfileCurrenciesResponse](docs/GetProfileCurrenciesResponse.md)
 - [Model.GetProfileCurrenciesResponseDataInner](docs/GetProfileCurrenciesResponseDataInner.md)
 - [Model.GetProfileNativeCurrencyResponse](docs/GetProfileNativeCurrencyResponse.md)
 - [Model.GetProfileNativeCurrencyResponseNativeTokenBalance](docs/GetProfileNativeCurrencyResponseNativeTokenBalance.md)
 - [Model.GetProfileResponse](docs/GetProfileResponse.md)
 - [Model.GetQuoteResponse](docs/GetQuoteResponse.md)
 - [Model.GetTransactionResponse](docs/GetTransactionResponse.md)
 - [Model.GetTransactionsResponse](docs/GetTransactionsResponse.md)
 - [Model.GetTransactionsResponseDataInner](docs/GetTransactionsResponseDataInner.md)
 - [Model.GetTransactionsResponseDataInnerInteractionsInner](docs/GetTransactionsResponseDataInnerInteractionsInner.md)
 - [Model.GetTransactionsResponseDataInnerResponse](docs/GetTransactionsResponseDataInnerResponse.md)
 - [Model.GetTransactionsResponseDataInnerResponseLogsInner](docs/GetTransactionsResponseDataInnerResponseLogsInner.md)
 - [Model.RegenerateGameApiKeysRequestInput](docs/RegenerateGameApiKeysRequestInput.md)
 - [Model.RegenerateGameApiKeysResponse](docs/RegenerateGameApiKeysResponse.md)
 - [Model.RegenerateGameApiKeysResponseApiKeysInner](docs/RegenerateGameApiKeysResponseApiKeysInner.md)
 - [Model.SellAssetRequestInput](docs/SellAssetRequestInput.md)
 - [Model.SellAssetResponse](docs/SellAssetResponse.md)
 - [Model.TransferAssetRequestInput](docs/TransferAssetRequestInput.md)
 - [Model.TransferAssetResponse](docs/TransferAssetResponse.md)
 - [Model.TransferNativeTokenRequestInput](docs/TransferNativeTokenRequestInput.md)
 - [Model.TransferTokenRequestInput](docs/TransferTokenRequestInput.md)
 - [Model.TransferTokenResponse](docs/TransferTokenResponse.md)
 - [Model.UpdateGameRequestInput](docs/UpdateGameRequestInput.md)
 - [Model.UpdateGameResponse](docs/UpdateGameResponse.md)
 - [Model.UpdateProfileRequestInput](docs/UpdateProfileRequestInput.md)
 - [Model.UpdateProfileResponse](docs/UpdateProfileResponse.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="Beam API game key"></a>
### Beam API game key

- **Type**: API key
- **API key parameter name**: x-api-key
- **Location**: HTTP header

