using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{

    private float horizontalTarget;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<=this.horizontalTarget) {
            Invoke("DestroySun",10);
            return;
        }
        transform.Translate(Vector3.down*Time.deltaTime);
    }
    public void InitForSky(float horizontal,float generatePosX,float generatePosY) {
        this.horizontalTarget = horizontal;
        transform.position = new Vector2(generatePosX, generatePosY);
        
    }
    public void DestroySun() {
        Destroy(gameObject);
    }
}
