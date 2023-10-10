using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationFix : MonoBehaviour
{
    public void FixAnimation()
    {
        Animator anime = GetComponent<Animator>();
        anime.CrossFade("Normal", 0);
        anime.Update(0);
    }
}
