using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ColisionesPlayer : MonoBehaviour
{
    public AudioSource reproductor;
    public AudioClip audioExhibicion;
    public Image imagenObra;
    public GameObject videoDocumental;

    void Start()
    {
        imagenObra.gameObject.SetActive(false);
        videoDocumental.SetActive(false);
    }

    void OnTriggerEnter(Collider objeto)
    {
        if (objeto.tag == "Audioguia")
        {
            reproductor.PlayOneShot(audioExhibicion);
        }
        if (objeto.tag == "Exhibicion")
        {
            imagenObra.gameObject.SetActive(true);
        }
        if (objeto.tag == "SalaVideo")
        {
            videoDocumental.SetActive(true);
        }
    }

    void OnTriggerExit(Collider objeto)
    {
        if (objeto.tag == "Audioguia")
        {
            reproductor.Stop();
        }
        if (objeto.tag == "Exhibicion")
        {
            imagenObra.gameObject.SetActive(false);
        }
        if (objeto.tag == "SalaVideo")
        {
            videoDocumental.SetActive(false);
        }
    }
}