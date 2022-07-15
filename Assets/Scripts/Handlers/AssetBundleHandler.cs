using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Handlers
{
    internal static class AssetBundleHandler
    {
        private static readonly string AbBasicPath = "Assets/AssetBundles/";
        private static Dictionary<string, AssetBundle> AssetBundles = new();

        // AB 包名
        public enum AbPackName
        {
            Environments, Elements
        }

        // AB 包资源列表

        public enum Environments
        {
            Desktop, AreaLight,
        }

        public enum Elements
        {
            Text,
        }


        public static AssetBundle GetAssetBundle(AbPackName abPackName)
        {
            string filePath = abPackName.ToString().ToLower();
            if (AssetBundles.ContainsKey(filePath)) return AssetBundles[filePath];
            else
            {
                AssetBundle abPack = AssetBundle.LoadFromFile(AbBasicPath + filePath);

                if (abPack == null)
                {
                    Debug.Log("资源加载失败");
                    return null;
                }

                AssetBundles.Add(filePath, abPack);

                return abPack;
            }
        }

        public static Object GetObject(AbPackName abPackName, string ObjectName)
        {
            AssetBundle abPack = GetAssetBundle(abPackName);

            if (abPack == null) return null;

            return abPack.LoadAsset(ObjectName);
        }
    }
}
