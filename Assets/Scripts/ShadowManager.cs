using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ShadowManager : MonoBehaviour {
    public Color color;

	void Update () {
        Shader.SetGlobalColor ("_GlobalShadowColor", color);
	}
}