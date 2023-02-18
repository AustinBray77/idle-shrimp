using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEnvironment
{
    public enum Platform
    {
        Windows,
        Android,
        Editor
    }

#if UNITY_STANDALONE_WIN
    public static Platform CurrentPlatform = Platform.Windows;
#elif UNITY_ANDROID
        public static Platform CurrentPlatform = Platform.Android;
#elif UNITY_EDITOR
        public static Platform CurrentPlatform = Platform.Editor;
#endif

}
