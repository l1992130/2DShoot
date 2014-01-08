using UnityEngine;
using System.Collections;

public class SpecialEffectHelper : MonoBehaviour {

	public static SpecialEffectHelper Instance;
	public ParticleSystem smokeEffect;
	public ParticleSystem fireEffect;

	void Awake()
	{
		if(Instance != null)
		{
			Debug.LogError("Multiple instances of SpecialEffectsHelper!");
		}
		Instance = this;
	}

	public void Explosion(Vector3 position)
	{
		instantiate(fireEffect,position);
		instantiate(smokeEffect,position);
	}

	private ParticleSystem instantiate(ParticleSystem prefab,Vector3 position)
	{
		ParticleSystem newParticleSystem = Instantiate(prefab,position,Quaternion.identity) as ParticleSystem;
		Destroy(newParticleSystem.gameObject,newParticleSystem.startLifetime);
		return newParticleSystem;
	}

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
