﻿using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	public GameObject powerup;
	public GameObject obstacle;
	
	private int timeCount = 0;
	float timeElapsed = 0;
	float spawnCycle = 0.5f * 2;
	bool spawnPowerup = true;
	float[] spawnTimes = {
		0.7f, 0.9f, 1.1f, 1.3f,
		3.0f, 3.2f, 3.4f, 3.6f,
		4.5f,
		5.6f, 6.2f, 6.8f, 7.4f, 8.0f, 8.6f, 9.3f, 9.9f, 10.5f,
		11.1f,
		11.8f,
		12.4f,
		13.0f,
		13.6f,
		14.3f,
		14.8f,
		15.4f,
		16.1f,
		16.8f,
		17.4f,
		18.0f,
		18.6f,
		19.2f,
		19.9f,
		20.5f,
		21.1f,
		21.8f,
		22.4f,
		23.0f,
		23.6f,
		24.2f,
		24.5f,
		24.8f,
		25.3f,
		26.3f,
		27.0f,
		27.6f,
		28.2f,
		28.8f,
		29.4f,
		30.1f,
		30.7f,
		31.3f,
		32.0f,
		32.6f,
		33.1f,
		33.8f,
		34.5f,
		35.1f,
		35.7f,
		36.3f,
		37.0f,
		37.6f,
		38.2f,
		38.8f,
		39.5f,
		40.1f,
		40.7f,
		41.3f,
		42.0f,
		42.6f,
		43.2f,
		43.8f,
		44.5f,
		45.1f,
		45.7f,
		46.3f,
		47.0f,
		47.6f,
		48.2f,
		48.8f,
		49.4f,
		50.1f,
		50.7f,
		51.3f,
		52.0f,
		52.6f,
		52.9f,
		53.2f,
		53.8f,
		54.5f,
		55.1f,
		55.7f,
		56.3f,
		57.0f,
		57.6f,
		58.2f,
		58.8f,
		59.4f,
		60.1f,
		60.7f,
		61.3f,
		61.9f,
		62.2f,
		62.5f,
		63.2f,
		63.8f,
		64.4f,
		65.0f,
		65.7f,
		66.3f,
		66.9f,
		67.6f,
		68.2f,
		68.8f,
		69.4f,
		70.0f,
		70.7f,
		71.3f,
		71.9f,
		72.5f,
		73.2f,
		73.8f,
		74.4f,
		75.0f,
		75.7f,
		76.3f,
		76.9f,
		77.5f,
		78.2f,
		78.8f,
		79.4f,
		80.0f,
		80.7f,
		81.3f,
		81.9f,
		82.5f,
		83.2f,
		83.8f,
		84.4f,
		85.0f,
		85.7f,
		86.3f,
		86.9f,
		87.5f,
		88.2f,
		88.8f,
		89.4f,
		90.0f,
		90.7f,
		91.3f,
		91.9f,
		92.5f,
		93.2f,
		93.8f,
		94.4f,
		95.0f,
		95.7f,
		96.3f,
		96.9f,
		97.5f,
		98.2f,
		98.8f,
		99.4f,
		100.0f,
		100.7f,
		101.3f,
		101.9f,
		102.5f,
		103.2f,
		103.8f,
		104.4f,
		105.0f,
		105.7f,
		106.3f,
		106.9f,
		107.5f,
		108.2f,
		108.8f,
		109.4f,
		110.0f,
		110.7f,
		111.3f,
		111.9f,
		112.5f,
		113.2f,
		113.8f,
		114.4f,
		115.0f,
		115.7f,
		116.3f,
		116.9f,
		117.5f,
		118.2f,
		118.8f,
		119.4f,
		120.0f,
		120.7f,
		121.3f,
		121.9f,
		122.5f,
		123.2f,
		123.8f,
		124.6f,
		125.0f,
		125.7f,
		126.3f,
		126.9f,
		127.5f,
		128.2f,
		128.8f,
		129.4f,
		130.0f,
		130.7f,
		131.3f,
		132.9f,
		132.5f,
		133.2f,
		133.8f,
		134.4f,
		135.0f,
		135.7f,
		136.3f,
		136.9f,
		137.5f,
		138.2f,
		138.8f,
		139.4f,
		140.0f,
		140.7f,
		141.3f,
		141.9f,
		142.5f,
		143.2f,
		143.8f,
		144.4f,
		145.0f,
		145.7f,
		146.3f,
		146.9f,
		147.5f,
		148.2f,
		148.8f,
		149.4f,
		150.0f,
		150.7f,
		151.3f,
		151.9f,
		152.5f,
		153.2f,
		153.8f,
		154.4f,
		155.0f,
		155.7f,
		156.3f,
		156.9f
	};
	int[] type = {1, 2, 1, 2, 
		1, 2, 1, 2, 
		5, 
		1, 2, 1, 2, 1, 2, 1, 2, 
		1, 2, 1, 2, 2,
		1,
		1,
		1,
		1,
		1,
		2,
		1,
		2, 
		3,
		1,
		5, 
		1, 
		1,
		4,
		4,
		4,
		1, 1, 2, 1, 2, 1, 3,
		2, 2, 2, 2, 2, 1, 2, 1, 2, 1, 3, 3, 3, 1, 1, 2, 2, 1, 2, 2, 2, 1, 4, 4, 3, 3, 2, 2, 5, 2, 2, 2, 1, 1, 2, 1, 3, 4, 2, 1, 1, 2, 2, 2, 3, 4, 1, 1, 2, 1, 3, 1, 1, 3, 1, 1, 1, 2, 1, 1, 1, 2, 2, 1, 3, 2, 1, 3, 1, 2, 2, 1, 2, 1, 2, 1, 1, 3, 4, 3, 3, 4, 1, 1, 2, 2, 1, 3, 3, 1, 1, 1, 2, 2, 1, 1, 2, 2, 1, 5, 1, 2, 2, 2, 1, 1, 2, 1, 2, 2, 1, 1, 4, 4, 3, 3, 4, 3, 3, 4, 1, 2, 1, 1, 1, 2, 2, 1, 3, 3, 4, 4, 3, 3, 4, 1, 2, 2, 1, 1, 5, 2, 1, 1, 1, 2, 1, 2, 1, 2, 1, 1, 2, 1, 1, 2, 1, 2, 2, 1, 2, 1, 1, 2, 1, 1, 2, 2, 1, 2, 2, 1, 1, 2, 2, 1, 2, 2, 1, 3, 4, 2, 2, 5, 1, 2, 2, 1, 2, 1, 1, 2, 1, 1, 2, 1, 4, 3, 4, 3, 2, 1, 2, 1, 4, 3, 4, 3, 2};
	
	float POS = 2.6f;
	
	
	void Start () {
		/*float temp = Random.Range (0.45f, 0.46f);
        for (int i =0; i< 100; i++) {
            spawnTimes[i] = temp;
            temp += Random.Range (0.45f, 0.46f) * 2;
        }
        int numberOfBeats = spawnTimes.Length;
        spawnTimes = new float[numberOfBeats];
        type = new int[numberOfBeats];

        float temp = -0.1f;
        for(int i = 0; i < numberOfBeats; i++){
            spawnTimes[i] -= temp;
        }*/
		
		
		
	}
	/*
    void Update () {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > spawnCycle)
        {
            GameObject temp;
            if(spawnPowerup)
            {
                temp = (GameObject)Instantiate(powerup);
                Vector3 pos = temp.transform.position;
                temp.transform.position = new Vector3(Random.Range(-3, 4), pos.y, pos.z);
            }
            else
            {
                temp = (GameObject)Instantiate(obstacle);
                Vector3 pos = temp.transform.position;
                temp.transform.position = new Vector3(Random.Range(-3, 4), pos.y, pos.z);
            }
            
            timeElapsed -= spawnCycle;
            spawnPowerup = !spawnPowerup;
        }
    }*/
	void Update () {
		timeElapsed += Time.deltaTime;
		if (timeElapsed > spawnTimes[timeCount]) {
			GameObject temp;
			temp = type[timeCount] < 3 ? (GameObject) Instantiate (powerup) : (GameObject)Instantiate(obstacle);
			
			Vector3 pos = temp.transform.position;
			
			if (type[timeCount] == 5){
				temp.transform.position = new Vector3(0, pos.y, pos.z);
			}
			else{
				temp.transform.position = new Vector3(POS * ((type[timeCount] == 1 || type[timeCount] == 3) ? -1 : 1.5f), pos.y, pos.z);
			}
			timeCount ++;
			if (timeCount == spawnTimes.Length) {
				timeCount %= spawnTimes.Length;
				timeElapsed = 0;
			}
		}
	}
}