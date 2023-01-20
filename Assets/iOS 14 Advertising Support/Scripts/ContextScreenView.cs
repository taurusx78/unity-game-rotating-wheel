using System;
using UnityEngine;
#if UNITY_IOS
using Unity.Advertisement.IosSupport;
#endif

namespace Unity.Advertisement.IosSupport.Components
{
    public sealed class ContextScreenView : MonoBehaviour
    {
        public event Action sentTrackingAuthorizationRequest;

        public void RequestAuthorizationTracking()
        {
            #if UNITY_IOS
                ATTrackingStatusBinding.RequestAuthorizationTracking();
                sentTrackingAuthorizationRequest?.Invoke();
            #endif
        }
    }
}
