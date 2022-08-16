using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerHitSound ,swordSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        playerHitSound = Resources.Load<AudioClip>("inBetweenSound");
        swordSound = Resources.Load<AudioClip>("slicingSound");

        audioSrc = GetComponent<AudioSource>()  ;
    }

    // Update is called once per frame
    
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "inBetweenSound":
                audioSrc.PlayOneShot(playerHitSound);
                    break;
            case "slicingSound":
                audioSrc.PlayOneShot (swordSound);
                    break;
                }
    }
}
