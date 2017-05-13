using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour {


	public Transform player; //obj to track is player
	float playerHeightY; // height at which camera will adjust to


	//definin step prefabs
	public Transform step;
	public Transform upDown;
	public Transform doubleJump;
	public Transform justStep;



	private float platformNum; //number of selected platform
	private float platformCheck;
	private float spawnPlatformsTo;




	// Use this for initialization
	void Start () {
		
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		PlatformSpanner(-2.0f);

		
	}
	
	// Update is called once per frame
	void Update () {


		playerHeightY = player.position.y;

		float currentCameraHeight = transform.position.y;
		float newHeightofCamera = Mathf.Lerp (currentCameraHeight,playerHeightY,Time.deltaTime * 10);

		/*lerp liner interpolasyona dayanır. bir değeri başka bi değerle değiştirir ama bunu aniden değil, yavaş yavai yapar
		amacımız kameranın oyuncuyu yavaşça takip etmesi

		currCamH ve playerHeY arasında deltatime uzaklığında bir değer döndürülür*/

		if (playerHeightY > platformCheck) {
			//increases platformChecknumber
			PlatformManager ();
		}

		if (playerHeightY > currentCameraHeight) {
		
			transform.position = new Vector3 (transform.position.x, newHeightofCamera, transform.position.z);

		} else {
			if (playerHeightY < (currentCameraHeight - 4.5f)) {
				UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex); 

			}
		}
	}



	void PlatformManager() {
		platformCheck = player.position.y +5;
		PlatformSpanner (platformCheck + 5);
	}

	//-2 ile başlatıldı
	void PlatformSpanner(float floatValue){
		//y başlangıçta 0
		float y = spawnPlatformsTo;
		//0
		while(y <= floatValue){
			float x = Random.Range (-2.35f, 2.35f);
			platformNum = Random.Range(0f,1f); //which one of prefabs
			Vector2 posXY = new Vector2(x,y);//position of prefabs

			if (platformNum > 0.8) {
				Instantiate (upDown, posXY, Quaternion.identity);
			}

		    else if (platformNum > 0.9) {
				Instantiate (doubleJump, posXY, Quaternion.identity);
			}

			else if (platformNum > 0.7) {	
				//object, position, identitiy
				Instantiate (step, posXY, Quaternion.identity);
			}
			else if (platformNum > 0.5) {
				//instantiating prefabs at runtime
				Instantiate (justStep, posXY, Quaternion.identity);
			} 
	
		

			y += Random.Range (0.3f,0.4f);

	}
		spawnPlatformsTo = floatValue;
	}


}