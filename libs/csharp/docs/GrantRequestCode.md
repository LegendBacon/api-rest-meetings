# com.bluejeans.api.rest.meetings.Model.GrantRequestCode
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GrantType** | **string** | The type of access token you are requesting. Use \&quot;authorization_code\&quot;. | [optional] [default to GrantTypeEnum.Authorizationcode]
**ClientId** | **string** | The client ID will be generated on creation of the application. Normally, a 32 character hexadecimal numeric string. | [optional] 
**ClientSecret** | **string** | The client secret will be generated on creation of the application. Retain this value as it will only be revealed one time. If lost, you will need to regenerate. | [optional] 
**RedirectUri** | **string** | One of the registered url or sub-url of registered urls. | [optional] 
**Code** | **string** | Code obtained after /oauth2/authorize redirect. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

