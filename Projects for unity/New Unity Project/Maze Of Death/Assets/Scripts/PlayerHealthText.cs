using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealthText : MonoBehaviour {

	// Use this for initialization
	public int health = 10;
	public string levelToLoad;
	void Start () {
		PlayerPrefs.SetInt ("Health", health);
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("Health") <=0 ) {
			//reload the scene if player health is equal to or less than 0
			//Scene scene = SceneManager.GetActiveScene();
			SceneManager.LoadScene (levelToLoad);
			}
		}
	

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Enemy" || collision.gameObject.name == "Enemy Bullet(Clone)") {
					PlayerPrefs.SetInt ("Health", PlayerPrefs.GetInt ("Health") - 1);
				}
			}
		}