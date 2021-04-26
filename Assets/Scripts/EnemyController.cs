using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public GameObject Player;
    public int MoveSpeed = 4;
    int MinDist = 5;

    public List<Transform> waypoints = new List<Transform>();
    private Transform targetWayPoint;
    private int wayPointIndex = 0;





    void Start()
    {
        targetWayPoint = waypoints[wayPointIndex];
    }

    void Update()
    {
        transform.LookAt(Player.transform);

        if (Vector2.Distance(transform.position, Player.transform.position) <= MinDist)
        {
            transform.LookAt(Player.transform);
            Chase();
        }
        else
        {
            float movementStep = MoveSpeed * Time.deltaTime;
            float distance = Vector2.Distance(transform.position, targetWayPoint.position);
            CheckDistance(distance);
            WayPoint(movementStep);
        }
        var otherPosn = transform.position;
        transform.position = new Vector3(otherPosn.x, otherPosn.y, 100.0f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //restart game
        if (collision.gameObject.layer == 9)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void Chase()
    {
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
    }
    void CheckDistance(float distance)
    {
        if(distance < 0.1)
        {
            wayPointIndex++;
            ChangeWayPoint();
        }
    }
    void ChangeWayPoint()
    {
        if(wayPointIndex >= waypoints.Count)
        {
            wayPointIndex = 0;
        }
        targetWayPoint = waypoints[wayPointIndex];
        
    }
    void WayPoint(float step)
    {
        transform.position = Vector2.MoveTowards(transform.position, targetWayPoint.position, step);
    }
}
