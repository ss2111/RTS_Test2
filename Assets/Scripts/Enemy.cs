using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float health;
	void Start(){
		health = 30f;
	}
	// Update is called once per frame
	void Update () {
		//transform.Translate(0,Time.deltaTime,0);
	}

	void OnCollisionEnter(Collision col)
	{
		print (col.gameObject.name);
		if (col.gameObject.tag == "Bullet")
		{//if we're hit by an arrow
			if (health > 0)
			{
				//decrease enemy health
				health -= 10f;
				if (health <= 0)
				{
					Destroy(this.gameObject);
				}
			}
			col.gameObject.GetComponent<Bullet>().Destroy(); //disable the arrow
		}
	}
}
