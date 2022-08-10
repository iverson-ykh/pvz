using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkySunManager : MonoBehaviour
{
    private GameObject Prefab_Sun;
    private float createSunPosY=6;

    private float sunTopMin=6;
    private float sunBottomMax = -3.5f;
    
    private float sunLeftMin = -5f;
    private float sunRightMax = 8f;
    
    // Start is called before the first frame update
    void Start()
    {
        Prefab_Sun = Resources.Load<GameObject>("Sun");
        InvokeRepeating("CreateSun", 3,3);
    }
    public void CreateSun() {
        float horizontalPos = Random.Range(sunBottomMax,sunTopMin);
        float verticalPos = Random.Range(sunLeftMin,sunRightMax);
        
        Sun sun=GameObject.Instantiate<GameObject>(Prefab_Sun,Vector3.zero,Quaternion.identity,transform).GetComponent<Sun>();
        sun.InitForSky(verticalPos,horizontalPos,createSunPosY);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
