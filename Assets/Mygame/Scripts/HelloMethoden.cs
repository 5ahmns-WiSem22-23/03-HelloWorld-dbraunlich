using UnityEngine;

public class HelloMethoden : MonoBehaviour
{

    //2) Instanzvariable
    int startValue = 0;

    //3) der Wert, der dazugegeben wird ist bei Deklaration nicht bekannt
    // z.B: Random oder User Input
    int startValue3 = 0;

    //4) Copy by Value
    int startValue4 = 10;

    //5) return 
    int startValue5 = 20; 


    void Start()
    {
        //1)Verwende Start Methode
        Debug.Log("Hallo Methoden!");

        // 2) Instanzvariable nutzen
        Debug.Log("before startValue" + startValue);
        IncrementByOne();
        Debug.Log("after startValue" + startValue);

        // 3)
        Debug.Log("before startValue3:" + startValue3);
        IncrementByX(Random.Range(1, 10));
        Debug.Log("after startValue3:" + startValue3);

        // 4)
        Debug.Log("before startValue4:" + startValue4);
        DecrementByOne(startValue4);
        Debug.Log("after startValue4:" + startValue4);

        // 5)
        Debug.Log("before startValue4:" + startValue5);
        startValue5 = DecrementByX(startValue5,2);
        Debug.Log("after startValue4:" + startValue5);
    }




    private int DecrementByX(int start, int valToSub)
    {
        return start - valToSub;
    }
    private void DecrementByOne(int val)
    {
        val--;
        Debug.Log("val: " + val);
    }

    private void IncrementByX(int valToAdd)
    {
        startValue3 += valToAdd;
    }
    
    private void IncrementByOne()
    {
        startValue++;

    }
}