#if UNITY_EDITOR
using UnityEditor;

[InitializeOnLoad]
public static class CodexUnityMcpPortInitializer
{
    private const string HttpBaseUrlKey = "MCPForUnity.HttpBaseUrl";
    private const string UseHttpTransportKey = "MCPForUnity.UseHttpTransport";
    private const string ForceRefreshMarkerKey = "CodexUnityMcp.LastPortInitializerRefresh";
    private const string HttpUrl = "http://127.0.0.1:8081";

    static CodexUnityMcpPortInitializer()
    {
        if (EditorPrefs.GetString(HttpBaseUrlKey, string.Empty) != HttpUrl)
        {
            EditorPrefs.SetString(HttpBaseUrlKey, HttpUrl);
        }

        if (!EditorPrefs.GetBool(UseHttpTransportKey, true))
        {
            EditorPrefs.SetBool(UseHttpTransportKey, true);
        }

        EditorPrefs.SetString(ForceRefreshMarkerKey, HttpUrl);
    }
}
#endif
