using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwnn : MonoBehaviour
{
    public GameObject Enemy;
    public int xPos;
    public int zPos;
    public int enemyCount;// Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    
    IEnumerator EnemyDrop()
    {
        while (enemyCount <=1)
        {
            xPos = Random.Range(1, 50);
            zPos = Random.Range(1, 31);
            Instantiate(Enemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            enemyCount += 1;
            if (enemyCount == enemyCount - 1)
            {
                xPos = Random.Range(1, 50);
                zPos = Random.Range(1, 31);
                Instantiate(Enemy, transform.position, Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                enemyCount += 1;
            }
            
        }
    }


}
