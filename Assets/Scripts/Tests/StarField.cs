//using UnityEngine;
//using System.Collections;

//public class StarField : MonoBehaviour {

//    private Transform tx;

//    private ParticleSystem.Particle[] points;

//    public int starsMaximum = 100;

//    public float starSize = 1.0f;

//    public float starDistance = 10;

//    //public void SetParticles(Particle[] particles, int size);


//	// Use this for initialization
//	void Start () {
//        tx = transform;
//	}

//    private void CreateStars(){
//        points = new ParticleSystem.Particle[starsMaximum];
//        //SetParticles(Particle[] particles, int size);

//        for (int i = 0; i < starsMaximum; i++)
//        {
//            points[i].position = Random.insideUnitSphere * starDistance + tx.position;
//            points[i].color = new Color(1,1,1,1);
//            points[i].size = starSize;
//        }
//    }
	
//	// Update is called once per frame
//	void Update () {
//        if (points = null) { CreateStars(); }

//        //particleSystem.SetParticles(points, points.Length);
//        GetComponent<ParticleSystem>().setParticles(points, points.Length);
//        SetParticles();

//    }

    
//}
