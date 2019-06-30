using UnityEngine;

public class Player : MonoBehaviour {
	
	public float jumpHeight;
	[HideInInspector]
	public Rigidbody2D rb;
	bool isGrounded;
	[HideInInspector]
	public float score; 
	[SerializeField]
	background bg;
	[HideInInspector]
	public bool lose;
	[HideInInspector]
	public int weed;
	[SerializeField] int weedValue;
	void Start () {
		rb=GetComponent<Rigidbody2D>();
		weed=PlayerPrefs.GetInt("weedCount");
	}
	
	// Update is called once per frame

	public void Jump(){
		if(isGrounded&&!lose)
		rb.velocity= new Vector2(rb.velocity.x,jumpHeight);
	}
	void OnTriggerStay2D(Collider2D col) {
		
		if(col.gameObject.tag=="GroundCol")
			 isGrounded=true;
		if(col.gameObject.tag=="Enemy")
			lose=true;
		
	}
	void OnTriggerEnter2D(Collider2D col) {
		 if (col.GetType() == typeof(BoxCollider2D)){
		if(col.gameObject.tag=="Weed"){
		Destroy(col.gameObject);
		weed++;	
		PlayerPrefs.SetInt("weedCount",weed);
		
			}
		}
	}
	void OnTriggerExit2D(Collider2D col) {
		if(col.gameObject.tag=="GroundCol")
			 isGrounded=false;
	}


}
