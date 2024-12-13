using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives_UI : MonoBehaviour
{
    public Sprite[] sprites;
    public Image[] hearts;

    // Update is called once per frame
    void Update()
    {
        switch(GameManager.Instance.currLives)
        {
            case 3:
                hearts[0].sprite = sprites[1];
                hearts[1].sprite = sprites[1];
                hearts[2].sprite = sprites[1];
                break;
            case 2:
                hearts[0].sprite = sprites[1];
                hearts[1].sprite = sprites[1];
                hearts[2].sprite = sprites[0];
                break;
            case 1:
                hearts[0].sprite = sprites[1];
                hearts[1].sprite = sprites[0];
                hearts[2].sprite = sprites[0];
                break;
        }

        if (GameManager.Instance.godMode)
        {
            var tempColor = hearts[3].color;
            tempColor.a = 1f;
            hearts[3].color = tempColor;
        }
        else
        {
            var tempColor = hearts[3].color;
            tempColor.a = 0f;
            hearts[3].color = tempColor;
        }
    }
}
