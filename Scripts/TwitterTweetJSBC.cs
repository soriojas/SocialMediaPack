using UnityEngine;
using UnityEngine.UI;

public class TwitterTweetJSBC : MonoBehaviour
{
    ConfigureSocialMediaPack config;

    void Start()
    {
        GameObject configGameObject;
        configGameObject = GameObject.FindGameObjectWithTag("ConfigureSocialMediaPack");
        if (configGameObject == null)
            Debug.LogWarning("You need the GameObject \"ConfigureSocialMediaPack\" in your scene for Tweets to work.");
        else
            config = configGameObject.GetComponent<ConfigureSocialMediaPack>();

        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.OpenURL("https://twitter.com/intent/tweet?text=" + System.Uri.EscapeUriString(config.TwitterMessage + (config.TwitterProfile == null || config.TwitterProfile == "" ? "" :(config.TwitterProfile[0] == '@' ? config.TwitterProfile:"@"+config.TwitterProfile)) + " @playCAT2020"));
    }
}