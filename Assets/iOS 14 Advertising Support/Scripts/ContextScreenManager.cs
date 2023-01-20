using Unity.Advertisement.IosSupport.Components;
using UnityEngine;
using System;
using System.Collections;
using UnityEngine.iOS;
using UnityEngine.SceneManagement;

namespace Unity.Advertisement.IosSupport.Samples
{
    public class ContextScreenManager : MonoBehaviour
    {
        public ContextScreenView contextScreenPrefab;
        Version currentVersion;
        Version ios14;

        void Start()
        {
            #if UNITY_IOS
                var status = ATTrackingStatusBinding.GetAuthorizationTrackingStatus();
                currentVersion = new Version(Device.systemVersion);
                ios14 = new Version("14.5"); 
            
                if (status == ATTrackingStatusBinding.AuthorizationTrackingStatus.NOT_DETERMINED && currentVersion >= ios14) 
                {
                    var contextScreen = Instantiate(contextScreenPrefab).GetComponent<ContextScreenView>();
                    contextScreen.sentTrackingAuthorizationRequest += () => Destroy(contextScreen.gameObject);
                } 
            #endif

            StartCoroutine(LoadNextScene());
        }

        private IEnumerator LoadNextScene()
        {
            var status = ATTrackingStatusBinding.GetAuthorizationTrackingStatus();
                
            #if UNITY_IOS
                while (status == ATTrackingStatusBinding.AuthorizationTrackingStatus.NOT_DETERMINED && currentVersion >= ios14)
                {
                    status = ATTrackingStatusBinding.GetAuthorizationTrackingStatus();
                    yield return null;
                }
            #endif
            
            SceneManager.LoadScene(1);
            yield return null;
        }
    }   
}
