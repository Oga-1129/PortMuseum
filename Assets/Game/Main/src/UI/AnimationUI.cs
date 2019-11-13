using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationUI : MonoBehaviour
{
	private Animator animator;
	public bool OpenUI = false;

	GameObject CrystalCanvas;
    CrystalCanvas crystalcanvasscript;

	public bool[] OpenProfile = new bool[4];
	void Start () {
		animator = GetComponent <Animator> ();

		CrystalCanvas = GameObject.Find("Canvas");
        crystalcanvasscript = CrystalCanvas.GetComponent<CrystalCanvas>();
	}

	void Update () 
	{
		if(OpenUI) {
			animator.SetBool("Open",true);
		}else{
			animator.SetBool("Open",false);
		}

		if(OpenProfile[0] == true)
		{
			animator.SetBool("Profile",true);
		}else{
			animator.SetBool("Profile",false);
		}
		
		if(OpenProfile[1] == true)
		{
			animator.SetBool("Skill",true);
		}else{
			animator.SetBool("Skill",false);
		}

		if(OpenProfile[2] == true)
		{
			animator.SetBool("Hobby",true);	
		}else{
			animator.SetBool("Hobby",false);	
		}

		if(OpenProfile[3] == true)
		{
			animator.SetBool("Carrer",true);
		}else{
			animator.SetBool("Carrer",false);	
		}
	}

	public void MotionEnd02()
	{
		crystalcanvasscript.Gage = false;
	}
}
