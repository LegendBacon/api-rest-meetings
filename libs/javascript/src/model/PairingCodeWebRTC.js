/**
 * BlueJeans Meetings REST API
 *  ## Video That Works Where You Do. <p>This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you can see and try actual API calls to manage User Accounts, Meetings, and Recordings, pull Analytical Data and Current State information.</p>    <nosdk> <hr> <div> <div class=\"key\">     <a href=\"./basics.html\" target=\"_\"><img class=\"keyimg\" src=\"./img/bjnmeeting.png\"/></a> </div> <div class=\"keybox\"> Basic instructions about What is a BlueJeans Meeting, and Getting Started Using API's, are <a href=\"./basics.html\" target=\"_blank\">available here <i class=\"glyphicon glyphicon-new-window\"></i></a>. </div> </div> <hr> <alert>2/21/2019</alert> Change response of Change layout and Endpoint API's to 204<br/> 12/03/2018 Add API for setting user profile photograph.<br/> 10/17/2018 Updated API field definitions for time variables to be 64-bit .<br/> 7/23/2018 Corrected errors in API definition file.<br/> 7/10/2018 Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> </nosdk> <hr> 
 *
 * OpenAPI spec version: 1.0.4402212019
 * Contact: glenn@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.0-SNAPSHOT
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient', 'model/PairingCodeSIPTurnservers'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./PairingCodeSIPTurnservers'));
  } else {
    // Browser globals (root is window)
    if (!root.BlueJeansMeetingsRestApi) {
      root.BlueJeansMeetingsRestApi = {};
    }
    root.BlueJeansMeetingsRestApi.PairingCodeWebRTC = factory(root.BlueJeansMeetingsRestApi.ApiClient, root.BlueJeansMeetingsRestApi.PairingCodeSIPTurnservers);
  }
}(this, function(ApiClient, PairingCodeSIPTurnservers) {
  'use strict';




  /**
   * The PairingCodeWebRTC model module.
   * @module model/PairingCodeWebRTC
   * @version 1.0.4402212019
   */

  /**
   * Constructs a new <code>PairingCodeWebRTC</code>.
   * @alias module:model/PairingCodeWebRTC
   * @class
   */
  var exports = function() {
    var _this = this;












  };

  /**
   * Constructs a <code>PairingCodeWebRTC</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PairingCodeWebRTC} obj Optional instance to populate.
   * @return {module:model/PairingCodeWebRTC} The populated <code>PairingCodeWebRTC</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('callguid')) {
        obj['callguid'] = ApiClient.convertToType(data['callguid'], 'String');
      }
      if (data.hasOwnProperty('endpointGuid')) {
        obj['endpointGuid'] = ApiClient.convertToType(data['endpointGuid'], 'String');
      }
      if (data.hasOwnProperty('forceTURN')) {
        obj['forceTURN'] = ApiClient.convertToType(data['forceTURN'], 'Boolean');
      }
      if (data.hasOwnProperty('pairingCode')) {
        obj['pairingCode'] = ApiClient.convertToType(data['pairingCode'], 'String');
      }
      if (data.hasOwnProperty('status')) {
        obj['status'] = ApiClient.convertToType(data['status'], 'Number');
      }
      if (data.hasOwnProperty('statusText')) {
        obj['statusText'] = ApiClient.convertToType(data['statusText'], 'String');
      }
      if (data.hasOwnProperty('turnservers')) {
        obj['turnservers'] = ApiClient.convertToType(data['turnservers'], [PairingCodeSIPTurnservers]);
      }
      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('seamEndpointGuid')) {
        obj['seamEndpointGuid'] = ApiClient.convertToType(data['seamEndpointGuid'], 'String');
      }
      if (data.hasOwnProperty('connectionGuid')) {
        obj['connectionGuid'] = ApiClient.convertToType(data['connectionGuid'], 'String');
      }
      if (data.hasOwnProperty('endpointName')) {
        obj['endpointName'] = ApiClient.convertToType(data['endpointName'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {String} callguid
   */
  exports.prototype['callguid'] = undefined;
  /**
   * @member {String} endpointGuid
   */
  exports.prototype['endpointGuid'] = undefined;
  /**
   * @member {Boolean} forceTURN
   */
  exports.prototype['forceTURN'] = undefined;
  /**
   * @member {String} pairingCode
   */
  exports.prototype['pairingCode'] = undefined;
  /**
   * @member {Number} status
   */
  exports.prototype['status'] = undefined;
  /**
   * @member {module:model/PairingCodeWebRTC.StatusTextEnum} statusText
   */
  exports.prototype['statusText'] = undefined;
  /**
   * @member {Array.<module:model/PairingCodeSIPTurnservers>} turnservers
   */
  exports.prototype['turnservers'] = undefined;
  /**
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;
  /**
   * Globally unique identifier associated with the media component of this endpoint for this meeting.  (Typically a string starting with \"seamguid:\")
   * @member {String} seamEndpointGuid
   */
  exports.prototype['seamEndpointGuid'] = undefined;
  /**
   * Globally unique identifier associated with this endpoint in this meeting. (Typically a string starting with \"connguid:\")
   * @member {String} connectionGuid
   */
  exports.prototype['connectionGuid'] = undefined;
  /**
   * @member {String} endpointName
   */
  exports.prototype['endpointName'] = undefined;


  /**
   * Allowed values for the <code>statusText</code> property.
   * @enum {String}
   * @readonly
   */
  exports.StatusTextEnum = {
    /**
     * value: "OK"
     * @const
     */
    "OK": "OK"  };


  return exports;
}));


