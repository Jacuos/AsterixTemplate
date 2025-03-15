using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityToolbarExtender;

[InitializeOnLoad]
public class RunGameButton
{
    static RunGameButton()
    {
        ToolbarExtender.LeftToolbarGUI.Add( OnToolbarGUI );
    }

    static void OnToolbarGUI()
    {
        GUILayout.FlexibleSpace();

        if ( GUILayout.Button( new GUIContent( "Start Game", "Loads first scene" ) ) ) {
            EditorSceneManager.OpenScene( EditorBuildSettings.scenes[0].path );
            EditorApplication.isPlaying = true;
        }
    }
}