using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyScript : MonoBehaviour
{
 public GameObject Enemy;
 public float spawnTime = 2f;
 public float fallSpeed = 40.0f;
 private float timer = 0;
 private int randomNumber;
 // Start is called before the first frame update
 void Start()
 {
 
 }
 // Update is called once per frame
 void Update()
 {
 timer += Time.deltaTime;
 if(timer > spawnTime)
 {
 SpawnRandom();
 timer = 0;
 }
 }
 public void SpawnRandom()
 {
 Vector3 screenPosition = 
Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, 
Screen.width), 
Random.Range(400,Screen.height),Camera.main.farClipPlane/2));
 Instantiate(Enemy, screenPosition, Quaternion.identity);
 }
}
