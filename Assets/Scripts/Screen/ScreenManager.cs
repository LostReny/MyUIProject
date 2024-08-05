using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using Singleton;


namespace Screens
{
    public class ScreenManager : Singleton<ScreenManager>
    {
        public List<ScreenBase> screenBases;

        public ScreenType starScreen = ScreenType.InitialMenu;

        private ScreenBase _currentScreen;

        public void Start()
        {
            HideAll();
            ShowByType(starScreen);
        }

        public void ShowByType(ScreenType type)
        {
            if(_currentScreen != null) _currentScreen.Hide();

            var nextScreen = screenBases.Find(i => i.screenType == type);

            nextScreen.Show();
            _currentScreen = nextScreen;
        }

        public void HideAll()
        {
            screenBases.ForEach(i => i.Hide());
        }
    }

}