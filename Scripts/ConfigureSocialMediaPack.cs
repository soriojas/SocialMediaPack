using System.Linq;
using UnityEngine;

//put this in your first scene
public class ConfigureSocialMediaPack : MonoBehaviour
{
    public static ConfigureSocialMediaPack Instance;

    public string TwitterProfile;
    [TextArea(0, 20)]
    [Tooltip("Insert comment here.")]
    public string TwitterMessage;

    void Awake()
    {
        if (Instance)
            DestroyImmediate(gameObject);
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }

        if (TwitterProfile == null || TwitterProfile == "")
            if(!TwitterMessage.Contains('@'))
                Debug.LogWarning("The variable TwitterProfile is empty. \nHow will your fans find you on Twitter? (ʘAʘ’)");
    }

    void Start()
    {
    }
}
