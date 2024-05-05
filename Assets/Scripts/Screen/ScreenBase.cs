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
        //abrir a tela / descobrir a tela que está / mostra os obj dessa tela

        public ScreenType screenType;

        public List<Transform> listOfObjects;

        public bool startHidden = false;

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
            listOfObjects.ForEach(i => i.gameObject.SetActive(true));
        }
    }

}