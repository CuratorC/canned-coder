using Assets.Scripts.Handlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Controllers
{

    public class MenuController : MonoBehaviour
    {
        private AssetBundle abPack;

        // Start is called before the first frame update
        void Start()
        {
            abPack = AssetBundleHandler.GetAssetBundle(AssetBundleHandler.AbPackName.Environments);
            if (abPack == null) return;

            Object Desktop = AssetBundleHandler.GetObject(
                AssetBundleHandler.AbPackName.Environments,
                AssetBundleHandler.Environments.Desktop.ToString()
                );
            
            Object AreaLight = AssetBundleHandler.GetObject(
                AssetBundleHandler.AbPackName.Environments,
                AssetBundleHandler.Environments.AreaLight.ToString()
                );

            Instantiate(Desktop);
            Instantiate(AreaLight);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}