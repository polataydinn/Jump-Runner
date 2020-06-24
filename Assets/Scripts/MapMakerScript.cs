using System.Collections.Generic;
using UnityEngine;

public class MapMakerScript : MonoBehaviour
{
    public GameObject[] sekil;

    public float sekilSayisi;

    public float sekilAraligi;

    public float eksenx;
    public float eksenx1;

    private float randomSayi;
    public List<GameObject> listeOlusturma;
    public List<GameObject> listeOlusturma1;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < sekilSayisi; i++)
        {
            createMap();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > ((eksenx+10) - sekilAraligi * sekilSayisi)){
            createMap();
            Destroy(listeOlusturma[0]);
            listeOlusturma.RemoveAt(0);
            Destroy(listeOlusturma1[0]);
            listeOlusturma1.RemoveAt((0));
        }    
    }

    private void createMap()
    {
        //randomSayi = Random.Range(-6.2f, -4.55f);
        GameObject diePlatform;
        GameObject stayPlatform;
        GameObject coin;
        diePlatform = Instantiate(sekil[1].gameObject);
        diePlatform.transform.position = new Vector3(eksenx1,-4.82f,5f);
        eksenx1 += sekilAraligi;
        stayPlatform = Instantiate(sekil[0].gameObject);
        stayPlatform.transform.position =new Vector3(eksenx, -5f,5f);
        eksenx += sekilAraligi;
        coin = Instantiate(sekil[2].gameObject);
        coin.transform.position = new Vector3(eksenx-6,1.5f,5f);
        listeOlusturma.Add(diePlatform);
        listeOlusturma1.Add(stayPlatform);
    }
}
