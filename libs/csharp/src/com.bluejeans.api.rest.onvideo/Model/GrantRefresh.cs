/* 
 * BlueJeans onVideo REST API
 *
 * _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use one of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace com.bluejeans.api.rest.onvideo.Model
{
    /// <summary>
    /// GrantRefresh
    /// </summary>
    [DataContract]
    public partial class GrantRefresh :  IEquatable<GrantRefresh>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantRefresh" /> class.
        /// </summary>
        /// <param name="AccessToken">The access token acts as a kind of \&quot;valet key\&quot; that the application can include with its requests to the identity provider, which prove that it has permission from the user to access those APIs..</param>
        /// <param name="RefreshToken">A longer lasting token that may be used to retrieve new access tokens upon access token expiration..</param>
        /// <param name="ExpiresIn">Seconds that access token is valid for from now..</param>
        /// <param name="Scope">Scope.</param>
        public GrantRefresh(string AccessToken = default(string), string RefreshToken = default(string), int? ExpiresIn = default(int?), GrantCodeScope Scope = default(GrantCodeScope))
        {
            this.AccessToken = AccessToken;
            this.RefreshToken = RefreshToken;
            this.ExpiresIn = ExpiresIn;
            this.Scope = Scope;
        }
        
        /// <summary>
        /// The access token acts as a kind of \&quot;valet key\&quot; that the application can include with its requests to the identity provider, which prove that it has permission from the user to access those APIs.
        /// </summary>
        /// <value>The access token acts as a kind of \&quot;valet key\&quot; that the application can include with its requests to the identity provider, which prove that it has permission from the user to access those APIs.</value>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
        /// <summary>
        /// A longer lasting token that may be used to retrieve new access tokens upon access token expiration.
        /// </summary>
        /// <value>A longer lasting token that may be used to retrieve new access tokens upon access token expiration.</value>
        [DataMember(Name="refresh_token", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }
        /// <summary>
        /// Seconds that access token is valid for from now.
        /// </summary>
        /// <value>Seconds that access token is valid for from now.</value>
        [DataMember(Name="expires_in", EmitDefaultValue=false)]
        public int? ExpiresIn { get; set; }
        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public GrantCodeScope Scope { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrantRefresh {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as GrantRefresh);
        }

        /// <summary>
        /// Returns true if GrantRefresh instances are equal
        /// </summary>
        /// <param name="other">Instance of GrantRefresh to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantRefresh other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.RefreshToken == other.RefreshToken ||
                    this.RefreshToken != null &&
                    this.RefreshToken.Equals(other.RefreshToken)
                ) && 
                (
                    this.ExpiresIn == other.ExpiresIn ||
                    this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(other.ExpiresIn)
                ) && 
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                if (this.RefreshToken != null)
                    hash = hash * 59 + this.RefreshToken.GetHashCode();
                if (this.ExpiresIn != null)
                    hash = hash * 59 + this.ExpiresIn.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
