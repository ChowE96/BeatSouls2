using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Progress_Bar : MonoBehaviour
{
    public float percentage = 0;
    public Image uiImage;

    // Update is called once per frame
    void Update()
    {
        percentage = SoundManager.Instance.songPercentage;
        if (percentage > 0)
        {
            // Scale the Image by setting the localScale
            Vector3 newScale = new Vector2(1f * (1 - (percentage / 100)), 1f); // Example: doubling the size
            uiImage.transform.localScale = newScale;
        }
    }
}
