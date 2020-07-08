using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	public class Boss
    {
		private int MP = 53;

		public void Magic()
        {
				if (MP >= 5)
				{
					this.MP -= 5;
					Debug.Log("魔法攻撃をした。残りMPは" + MP);
				}
				else
				{
					Debug.Log("MPが足りないため魔法が使えない。");
				}
        }
    }

	// Use this for initialization
	void Start () {
		int[] array = { 10, 20, 30, 40, 50 };
		for (int i = 0; i < array.Length; i++)
        {
			Debug.Log(array[i]);
        }

		for (int a = array.Length-1; a >= 0; a--)
		{
			Debug.Log(array[a]);
		}

		Boss lastboss = new Boss();
		for (int a = 0; a <= 10; a++)
        {
			lastboss.Magic();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
