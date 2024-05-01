using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TopScript : MonoBehaviour
{
    public float ziplamaKuvveti = 5f;
    public string mevcutRenk;
    public Color turkuaz;
    public Color sari;
    public Color kirmizi;
    public Color mor;
    public Color topRenk;
    public Text skorYazisi;
    public static int skor = 0;
    public GameObject cember;
    public GameObject renkTekeri;
   public MenuManagerInGame menuManagerInGame;
    // Start is called before the first frame update
    void Start()
    {
        RastgeleRenkBelirle();
        skorYazisi.text = skor.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * ziplamaKuvveti;
            //GetComponent<AudioSource>().Play();
        }    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Cember")
        {
            //audio.GetComponent<AudioSource>().Play();
        }
        if (collision.tag=="SkoruArttir")
        {
            skor += 5;
            skorYazisi.text = skor.ToString();
            Instantiate(cember, new Vector3(transform.position.x, transform.position.y + 8f, transform.position.z),transform.rotation);
            Instantiate(renkTekeri, new Vector3(transform.position.x, transform.position.y + 4f, transform.position.z),Quaternion.identity);
            Destroy(collision.gameObject);

        }
        if (collision.tag=="RenkTekeri")
        {
            RastgeleRenkBelirle();
            Destroy(collision.gameObject);
            return;
        }
        if (collision.tag!=mevcutRenk&&collision.tag!="SkoruArttir")
        {
            
            GetComponent<AudioSource>().Pause();
            
            menuManagerInGame.GameOverManage();
            skor = 0;
            skorYazisi.text = skor.ToString();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void RastgeleRenkBelirle()
    {
        int rastgeleSayi = Random.Range(0, 4);

        switch (rastgeleSayi)
        {
            case 0 : mevcutRenk = "Turkuaz";
                topRenk = turkuaz;
                break;
            case 1: mevcutRenk = "Sari";
                topRenk = sari;
                break;
            case 2: mevcutRenk = "Kirmizi";
                topRenk = kirmizi;
                break;
            case 3: mevcutRenk = "Mor";
                topRenk = mor;
                break;
        }
        GetComponent<SpriteRenderer>().color = topRenk;
    }
}
