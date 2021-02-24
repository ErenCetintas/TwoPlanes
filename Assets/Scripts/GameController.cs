using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject[] RedGO;
    public GameObject[] BlueGO;

    public float startWait;
    public float spawnWait;

    GameObject Blue,Red;

    float[] XPosition=new float[2] {1f , 3f};
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(CircleSquare.speed<12){
            CircleSquare.speed += CircleSquare.speed*0.0001f;
        }else{
            CircleSquare.speed=12;
        }
    }
    IEnumerator SpawnObjects(){
        yield return new WaitForSeconds(startWait);
        while(true){
            for (int i=0; i<50; i++){
                float RedXpos = -XPosition[Random.Range(0,XPosition.Length)];
                Vector3 RedPos = new Vector3(RedXpos,10,0);
                Red = RedGO[Random.Range(0,RedGO.Length)] as GameObject;
                Instantiate(Red, RedPos, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);

                float BlueXpos = XPosition[Random.Range(0,XPosition.Length)];
                Vector3 BluePos = new Vector3(BlueXpos,10,0);
                Blue = BlueGO[Random.Range(0,BlueGO.Length)] as GameObject;
                Instantiate(Blue, BluePos, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);

            }
        }
    }
}
