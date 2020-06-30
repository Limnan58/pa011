using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;

namespace Tests
{
    public class NewTestScript
    {
        // A Test behaves as an ordinary method
        [UnityTest]
        public IEnumerator _Instantiantes_Gameobject()
        {

            Spawnerscript spawner = new GameObject().AddComponent<Spawnerscript>();
            GameObject[] spawnPref = {Resources.Load<GameObject>("Prefabs/RedCube")as GameObject
                ,Resources.Load<GameObject>("Prefabs/GreenCube")as GameObject
                ,Resources.Load<GameObject>("Prefabs/BrownCube") };
            spawner.SpawnObject = spawnPref;
            Debug.Log(spawner.SpawnObject[0]);
            yield return null;
            GameObject findobj = GameObject.FindGameObjectWithTag("Obstacle");
            Assert.IsNotNull(findobj);

        }

        [UnityTest]
        public IEnumerator _findplayer()
        {
            MonoBehaviour.Instantiate(Resources.Load<Camera>("Prefab/Camera"));
            MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Player"));
            Debug.Log("Hehe");
            yield return null;
            GameObject findplayer = GameObject.FindGameObjectWithTag("Player");
            Debug.Log(findplayer.gameObject.tag);
            Assert.IsNotNull(findplayer);

        }
        [UnityTest]
        public IEnumerator test()
        {
            yield return null;
        }

    }
}
