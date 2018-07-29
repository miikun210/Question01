using UnityEngine;
using UnityEngine.Rendering;
using System;

[ExecuteInEditMode]
public class DispTestGUI : MonoBehaviour
{
    void OnGUI()
    {
        GUI.color = Color.green;
        GUILayout.Label("UnityEngine.Rendering.CompareFunction");
        foreach( CompareFunction func in Enum.GetValues(typeof(CompareFunction)))
        {
            GUILayout.Label( string.Format("{0} : {1}", func.ToString(), (int)func ));
        }

        GUILayout.Label("公式からシェーダ拾ってきて[Enum(UnityEngine.Rendering.CompareFunction)]をプロパティにかましてもいいんだけど、一応");

        GUILayout.Label("UnityEngine.Rendering.StencilOp");
        foreach( StencilOp func in Enum.GetValues(typeof(StencilOp)))
        {
            GUILayout.Label( string.Format("{0} : {1}", func.ToString(), (int)func ));
        }

        
    }
}