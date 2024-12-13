using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Box : MonoBehaviour
{
    public GameObject cereal;
    public GameObject turret;
    public GameObject[] cerealBits;
    public GameObject[] turrets;
    public float duration;

    void FireCerealBit()
    {
        Instantiate(cereal, turret.transform.position, Quaternion.identity);
    }

    void DeleteBox()
    {
        Destroy(gameObject.transform.parent.gameObject);    // Destroys the parent object and all its children
        //Destroy(gameObject);
    }

    void FireCerealFan()
    {
        int rotation = -210;
        for (int i = 0; i < turrets.Length; i++)
        {
            int cerealIndex = Random.Range(0, cerealBits.Length);
            Instantiate(cerealBits[cerealIndex], turrets[i].transform.position, Quaternion.Euler(new Vector3(0, 0, rotation)));
            rotation += 15;
        }
    }

    void FireCerealLine()
    {
        int turretIndex = Random.Range(0, turrets.Length);
        int cerealIndex = Random.Range(0, cerealBits.Length);

        Instantiate(cerealBits[cerealIndex], turrets[turretIndex].transform.position, Quaternion.identity);
    }

    void DeleteBoxAfter()
    {
        StartCoroutine(DelayedDestroy(duration));
    }

    IEnumerator DelayedDestroy(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        Destroy(gameObject.transform.parent.gameObject);    // Destroys the parent object and all its children
    }
}
