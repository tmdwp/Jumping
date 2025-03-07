using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class DamageIndicator : MonoBehaviour
{
    public Image image;
    public float flashSpeed;

    private Coroutine coroutine;
    void Start()
    {
        CharacterManager.Instance.Player.condition.onTakeDamage += Flash;
    }

    public void Flash()
    {
        if (coroutine != null) 
        {
            StopCoroutine(coroutine);
        }
        image.enabled = true;
        image.color = new Color(1f, 125 / 255f, 125 / 255f);
        coroutine = StartCoroutine(FadeAway());
    }

    private IEnumerator FadeAway()
    {
        float startAlpha = 0.3f;
        float a = startAlpha;

        while (a > 0)
        {
            a -= (startAlpha / flashSpeed) * Time.deltaTime;
            image.color = new Color(1f, 125/255f, 125/255f, a);
            yield return null;
        }
    }
}
