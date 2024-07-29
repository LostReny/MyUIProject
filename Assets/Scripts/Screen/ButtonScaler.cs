using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ButtonScaler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Vector3 myVector;

    [Header("Aniamtion")]
    public float finalScale = 1.2f;
    public float scaleDuration = 0.2f;

    private Tween _currentTween;

    void Start()
    {
        myVector = new Vector3(2.5f, 4.6f, 2.3f);
    }

   public void OnPointerEnter(PointerEventData pointerEventData)
    {
        if (_currentTween != null)
        {
            _currentTween.Kill();
        }

        if (gameObject.CompareTag("NextButton"))
        {
            _currentTween = transform.DOScale(Vector3.one * finalScale, scaleDuration);
        }
        else
        {
            _currentTween = transform.DOScale(myVector * finalScale, scaleDuration);
        }
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        if (_currentTween != null)
        {
            _currentTween.Kill();
        }

        if (gameObject.CompareTag("NextButton"))
        {
            _currentTween = transform.DOScale(Vector3.one, scaleDuration);
        }
        else
        {
            _currentTween = transform.DOScale(myVector, scaleDuration);
        }
    }
}
