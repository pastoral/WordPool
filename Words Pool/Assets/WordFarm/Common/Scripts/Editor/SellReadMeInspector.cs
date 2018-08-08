﻿//#define UAS
//#define CHUPA
#define SMA

using System;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(SellReadMe))]
public class SellReadMeInspector : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("1. Edit Game Settings (Admob, In-app Purchase..)", EditorStyles.boldLabel);

        if (GUILayout.Button("Edit Game Settings", GUILayout.MinHeight(40)))
        {
            Selection.activeObject = AssetDatabase.LoadMainAssetAtPath("Assets/WordChef/Common/Prefabs/GameMaster.prefab");
        }

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("2. Game Documentation", EditorStyles.boldLabel);
#if UAS
        if (GUILayout.Button("Set Up (Important)", GUILayout.MinHeight(40)))
        {
            Application.OpenURL("https://drive.google.com/open?id=1aymh-PnpVm7qpVVHIRitORgtvTUonYPwgF7nOe_UrKc");
        }
        EditorGUILayout.Space();
#endif

        if (GUILayout.Button("Open Full Documentation", GUILayout.MinHeight(40)))
        {
            Application.OpenURL("https://drive.google.com/open?id=19rgMq-TcbFkPqh4U0k5dDPi68cMIQyOe3TqEkvuDVs4");
        }

        EditorGUILayout.Space();
        if (GUILayout.Button("Setup In-app Purchase Video Guide", GUILayout.MinHeight(40)))
        {
            Application.OpenURL("https://www.youtube.com/watch?v=LFuKHmFeR9g");
        }

        EditorGUILayout.Space();
        if (GUILayout.Button("Build For iOS Video Guide", GUILayout.MinHeight(40)))
        {
            Application.OpenURL("https://www.youtube.com/watch?v=f0TfqG9_Xbc");
        }

        EditorGUILayout.Space();
        if (GUILayout.Button("Enable Facebook Features", GUILayout.MinHeight(40)))
        {
            Application.OpenURL("https://drive.google.com/open?id=1bjhWT0xrIWOG0vY8t03Tiqh7_ErRCR2zTm8zNR667f4");
        }

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("3. My Other Great Source Codes", EditorStyles.boldLabel);
        if (GUILayout.Button("Hexa Puzzle Block", GUILayout.MinHeight(30)))
        {
#if UAS
            Application.OpenURL("https://www.assetstore.unity3d.com/en/#!/content/85474");
#elif CHUPA
            Application.OpenURL("https://www.chupamobile.com/unity-board/block-hexa-puzzle-unity-in-top-free-game-16762");
#elif SMA
            Application.OpenURL("https://www.sellmyapp.com/downloads/hexa-puzzle-blocks-top-free-game/");
#endif
        }

        EditorGUILayout.Space();

        if (GUILayout.Button("Unroll Ball - Slide Puzzle", GUILayout.MinHeight(30)))
        {
#if UAS
            Application.OpenURL("https://www.chupamobile.com/unity-puzzle/unroll-ball-slide-puzzle-18557");
#elif CHUPA
            Application.OpenURL("https://www.chupamobile.com/unity-puzzle/unroll-ball-slide-puzzle-18557");
#elif SMA
            Application.OpenURL("https://www.sellmyapp.com/downloads/unroll-ball-slide-puzzle/");
#endif
        }

        EditorGUILayout.Space();

        if (GUILayout.Button("Unblock Me", GUILayout.MinHeight(30)))
        {
#if UAS
            Application.OpenURL("https://www.assetstore.unity3d.com/en/#!/content/69070");
#elif CHUPA
            Application.OpenURL("https://www.chupamobile.com/unity-casual/unblock-me-12590");
#elif SMA
            Application.OpenURL("https://www.sellmyapp.com/downloads/unblock-me-2/");
#endif
        }

        EditorGUILayout.Space();

        if (GUILayout.Button("Cut The Rope", GUILayout.MinHeight(30)))
        {
            Application.OpenURL("https://www.chupamobile.com/unity-arcade/cut-my-rope-12320");
        }

        EditorGUILayout.Space();

        if (GUILayout.Button("Rolling Sky", GUILayout.MinHeight(30)))
        {
#if CHUPA || UAS
            Application.OpenURL("https://www.chupamobile.com/unity-arcade/rolling-ball-on-sky-15053");
#elif SMA
            Application.OpenURL("https://www.sellmyapp.com/downloads/rolling-ball-on-sky/");
#endif
        }

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("4. Contact Us For Support", EditorStyles.boldLabel);
        EditorGUILayout.TextField("Email: ", "phuongdong0702@gmail.com");
        EditorGUILayout.TextField("Skype: ", "phuongdong0702");
    }
}