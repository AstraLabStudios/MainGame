namespace MainGame.Editor
{
    using MainGame.Components;
    using UnityEditor;
    using UnityEngine;

    /// <summary>
    /// Custom editor for UnityComment component.
    /// </summary>
    [CustomEditor(typeof(InspectorComment))]
    public class UnityCommentEditor : Editor
    {
        private InspectorComment Component => target as InspectorComment;
        
        private readonly GUIStyle _style = new();

        // Colors
        private static Color _pro = new(0.5f, 0.7f, 0.3f, 1f);
        private static Color _free = new(0.2f, 0.3f, 0.1f, 1f);

        public override void OnInspectorGUI()
        {
            if (serializedObject == null)
            {
                return;
            }

            _style.wordWrap = true;
            _style.normal.textColor = EditorGUIUtility.isProSkin ? _pro : _free;

            serializedObject.Update();
            EditorGUILayout.Space();

            string text = EditorGUILayout.TextArea(Component.Comment, _style);
            if (text != Component.Comment)
            {
                Undo.RecordObject(Component, "Edit Comments");
                Component.Comment = text;
            }

            EditorGUILayout.Space();

            _ = serializedObject.ApplyModifiedProperties();
        }
    }
}
