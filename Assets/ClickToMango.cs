using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ClickToMango : MonoBehaviour {

	public GameObject mango;

	public static bool mangoEnabled
	{
		get
		{
		#if UNITY_EDITOR
            return EditorPrefs.GetBool("mangoEnabled", false);
		#else
            return false;
		#endif
        }

        set
        {
		#if UNITY_EDITOR
            EditorPrefs.SetBool("mangoEnabled", value);
		#endif
        }
	}

	void Update()
	{
		if (mangoEnabled == true)
		{
			//Debug.Log("true");
			mango.SetActive(true);
		}
		else
		{
			mango.SetActive(false);
		}
	}
}
