using System;
using Cysharp.Threading.Tasks;
using Entities;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;
using ErrorEventArgs = Newtonsoft.Json.Serialization.ErrorEventArgs;


/// <summary>
/// Class that allow to load data from google sheets via json deseralization
/// Installation of com.unity.nuget.newtonsoft-json and Unitasks required
/// </summary>
namespace DataManagement
{
    public class GoogleDataLoader
    {
        private const string JsonUrl = "https://script.googleusercontent.com/macros/echo?user_content_key" +
                                       "=cpTfwO2WfuXI27lDgAClvTleFZJ4HnhNpnM8o3KX93wr_6pCL2Ijb3clsRfLhFi3ovwAmHp_" +
                                       "K0OibeJyxChZo8VI93moFXTgm5_BxDlH2jW0nuo2oDemN9CCS2h10ox_" +
                                       "1xSncGQajx_ryfhECjZEnEa9Z8-z3wRVlUaM9j2ZJp8cp0ZD_eEW8Vf-" +
                                       "RCROpKWEAv0jOY2HrsspmBg0IRZU5Gc3KsdNg-aD-qNTlt0XkBkGbNKFuA0Shw&lib=M5YioJdcbZ146fiZV43VHb_-qERZM9JSA";

        private static bool _isRequestInProgress;
        
        public static async UniTask<GoogleRequestObject> GetGoogleObject()
        {
            if (Application.internetReachability == NetworkReachability.NotReachable)
                return null;
            
            if (_isRequestInProgress)
                return null;
            
            _isRequestInProgress = true;
            
            var request = UnityWebRequest.Get(JsonUrl);
        
            await request.SendWebRequest();

            Debug.Log(request.result); // Update to normal logger in the game
            
            if (request.result == UnityWebRequest.Result.Success)
            {
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    TypeNameHandling = TypeNameHandling.Auto,
                    Formatting = Newtonsoft.Json.Formatting.None,
                    Error = delegate(object sender, ErrorEventArgs args) { args.ErrorContext.Handled = true; }
                };
                
                var googleObject = JsonConvert.DeserializeObject<GoogleRequestObject>(request.downloadHandler.text, settings);
                _isRequestInProgress = false;
                return googleObject;
            }
            
            _isRequestInProgress = false;
            return null;
        }
    }
}

