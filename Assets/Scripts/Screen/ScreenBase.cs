using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using DG.Tweening;

namespace Screens {

    public enum ScreenType
    {
        InitialMenu,
        Game
    }

    public class ScreenBase : MonoBehaviour
    {
        //input/process/output
        //abrir a tela / descobrir a tela que est� / mostra os obj dessa tela

        public ScreenType screenType;

        public List<Transform> listOfObjects;

        public List<Typer> listOfPhrases;

        public bool startHidden = false;

        [Header("Animation")]
        public float delayBtObjects = .5f;
        public float animDuration = .3f;


        private void Start()
        {
            if(startHidden)
            {
                HideObjects();
            }
        }

        [Button]
        protected virtual void Show()
        {
            ShowObjects();
            Debug.Log("Show");
        }

        [Button]
        protected virtual void Hide()
        {
            HideObjects();
            Debug.Log("Hide");
        }
        
        private void HideObjects()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(false));
        }

        private void ShowObjects()
        {
            for (int i = 0; i < listOfObjects.Count; i++)
            {
                var obj = listOfObjects[i];

                obj.gameObject.SetActive(true);
                obj.DOScale(0, animDuration).From().SetDelay(i * delayBtObjects);
            }

            Invoke(nameof(StartType), delayBtObjects * listOfObjects.Count);
        }

        private void StartType()
        {
            for (int i = 0; i < listOfPhrases.Count; i++)
            {
                listOfPhrases[i].StartType();
            }
        }

        private void FirstShowObjects()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(true));
        }
    }

}