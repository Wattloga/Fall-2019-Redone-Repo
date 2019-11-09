using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{
    [System.Serializable]
    public class WaveComponent
    {
        public GameObject enemyPrefab;
        public int num;
    }

    public WaveComponent[] waveComponents;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
