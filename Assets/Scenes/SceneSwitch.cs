using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class SceneSwitch : MonoBehaviour
{
    private InterstitialAd interstitial;
    public Canvas myCanvas;
    bool playFlag;
    int showAd;

    public GameObject panel;
    public GameObject loading;

    void Start() {
        playFlag = true;
        showAd = PlayerPrefs.GetInt("showAd");
    }

    public void CreditBtnDown() {
        SceneManager.LoadScene("CreditScene");
    }
    
    public void PlayBtnDown() {
        panel.SetActive(true);
        loading.SetActive(true);
        SceneManager.LoadSceneAsync("PlayScene");
    }

    public void HomeBtnDown() {
        SceneManager.LoadScene("HomeScene");
    }

    public void ExitBtnDown() {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            UnityEngine.Application.Quit();
        #endif

        // Application.Quit();
    }

    // 테스트 ID : ca-app-pub-3940256099942544/1033173712 / ca-app-pub-3940256099942544/4411468910
    // 전면 ID : ca-app-pub-7133795579324273/1820087821 / ca-app-pub-7133795579324273/4494352622
    private void RequestInterstitial() {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-7133795579324273/1820087821";
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-7133795579324273/4494352622";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        this.interstitial = new InterstitialAd(adUnitId);
        
        // Called when an ad request failed to load.
        this.interstitial.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        // Called when the ad is closed.
        this.interstitial.OnAdClosed += HandleOnAdClosed;
        
        AdRequest request = new AdRequest.Builder().Build();
        this.interstitial.LoadAd(request);
    }

    public void GameOverToPlayBtnDown() {
        if (showAd == 0) {
            PlayerPrefs.SetInt("showAd", 1);
            SceneManager.LoadSceneAsync("PlayScene");
        } else {
            PlayerPrefs.SetInt("showAd", 0);
            playFlag = true;
            RequestInterstitial();
            StartCoroutine(showInterstitial());

            IEnumerator showInterstitial() {
                while(!this.interstitial.IsLoaded()) {
                    panel.SetActive(true);
                    loading.SetActive(true);
                    yield return new WaitForSeconds(0.2f);
                }
                
                this.interstitial.Show();
                myCanvas.sortingOrder = -1;
            }
        }
    }

    public void GameOverToHomeBtnDown() {
        if (showAd == 0) {
            PlayerPrefs.SetInt("showAd", 1);
            SceneManager.LoadSceneAsync("HomeScene");
        } else {
            PlayerPrefs.SetInt("showAd", 0);
            playFlag = false;
            RequestInterstitial();
            StartCoroutine(showInterstitial());

            IEnumerator showInterstitial() {
                while(!this.interstitial.IsLoaded()) {
                    panel.SetActive(true);
                    loading.SetActive(true);
                    yield return new WaitForSeconds(0.2f);
                }
                
                this.interstitial.Show();
                myCanvas.sortingOrder = -1;
            }
        }
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args) {
        panel.SetActive(true);
        loading.SetActive(true);

        if (playFlag) {
            SceneManager.LoadSceneAsync("PlayScene");
        } else {
            SceneManager.LoadSceneAsync("HomeScene");
        }
    }

    public void HandleOnAdClosed(object sender, System.EventArgs args) {
        panel.SetActive(true);
        loading.SetActive(true);

        if (playFlag) {
            SceneManager.LoadSceneAsync("PlayScene");
        } else {
            SceneManager.LoadSceneAsync("HomeScene");
        }
    }
}
