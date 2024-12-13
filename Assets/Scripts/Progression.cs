using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Progression : MonoBehaviour
{
    public float percentage = 0;
    public TMP_Text uiText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        percentage = SoundManager.Instance.songPercentage;
        if (percentage > 0)
        {
            uiText.text = string.Format("{0:0}", percentage) + "%";
        }
        uiText.ForceMeshUpdate(true);
    }
}
