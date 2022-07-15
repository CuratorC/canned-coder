using UnityEditor;

public class AssetBundle
{
    [@MenuItem("ExportAsset/BuildAssetBundles")]
    static void BuildAssetBundles()
    {
        BuildPipeline.BuildAssetBundles("Assets/AssetBundles",
            BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
    }
}
