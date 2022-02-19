using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform player;
    public float traceDist = 10.0f;
    NavMeshAgent nav;
    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        StartCoroutine(CheckDist());
    }
    
    IEnumerator CheckDist()
    {
        while (true)
        {
            //1秒間に５回実行する処理の設定。
            yield return new WaitForSeconds(0.2f);
            float dist = Vector3.Distance(player.position,transform.position);
            if (dist < traceDist)
            {
                //目的地の設定
                nav.SetDestination(player.position);
                //追跡開始
                nav.isStopped = false;
            }
            else
            {
                nav.isStopped = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
