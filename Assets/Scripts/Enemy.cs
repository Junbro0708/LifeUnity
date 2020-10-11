using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 dir;
    public float speed = 5;
    public GameObject explosionFactory;
    // Start is called before the first frame update
    void Start()
    {
        int randValue = UnityEngine.Random.Range(0, 10);

        if(randValue < 3)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position; // target <- me
            dir.Normalize();
        }else
        {
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        GameObject smObject = GameObject.Find("ScoreManager");
        ScoreManager sm = smObject.GetComponent<ScoreManager>();
        sm.currentScore++;
        sm.currentScoreUI.text = "현재 점수 : " + sm.currentScore;

        if(sm.currentScore > sm.bestScore)
        {
            sm.bestScore = sm.currentScore;
            sm.bestScoreUI.text = "최고 점수 : " + sm.bestScore;
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
