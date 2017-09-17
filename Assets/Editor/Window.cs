using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Window : EditorWindow {

	[MenuItem ("Window/Sophia's Window")]
    public static void ShowWindow()
    {
        GetWindow<Window>(false, "Click To Mango", true);
    }

	void OnGUI()
	{
		GUILayout.Label ("Click To Mango", EditorStyles.boldLabel);

        ClickToMango.mangoEnabled = EditorGUILayout.Toggle("Mango Toggle", ClickToMango.mangoEnabled);
	}
}
