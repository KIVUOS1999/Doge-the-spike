using UnityEngine;

public class buttonsound : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip Hover;
    public AudioClip Click;

    public void hover()
    {
        myFx.PlayOneShot(Hover);
    }

    public void clk()
    {
        myFx.PlayOneShot(Click);
    }
}
