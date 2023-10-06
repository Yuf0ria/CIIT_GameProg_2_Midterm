using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwnn : MonoBehaviour
{
    public GameObject Enemy;
    public Transform spawnEnemyHere;
    public float EnemySpeed;
    public int xPos;
    public int zPos;
    public int enemyCount;// Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    
    IEnumerator EnemyDrop()
    {
        while (enemyCount <= 1)
        {
            xPos = Random.Range(1, 50);
            zPos = Random.Range(1, 31);
            Instantiate(Enemy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0f);
            enemyCount += 1;
            if(enemyCount <=0)
            {
                enemyCount += 1;
            }
        }
    }
    public void UpdateEnemySpeed(Vector2 newSpeed)
    {
        GameObject EnemySpawn = Instantiate(Enemy, spawnEnemyHere.position, spawnEnemyHere.rotation);
        Rigidbody bulletRB = EnemySpawn.GetComponent<Rigidbody>();

        bulletRB.AddForce(spawnEnemyHere.forward * EnemySpeed, ForceMode.Impulse);
        
    }


}
