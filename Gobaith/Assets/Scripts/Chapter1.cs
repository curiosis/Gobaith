using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter1 : MonoBehaviour
{
    public static Animator animator;
    public static bool showChapters;

    void Start()
    {
        animator = GetComponent<Animator>();
        showChapters = false;
    }

    void Update()
    {
    }

    public static void OpenCh1()
    {
        animator.SetBool("OpenChMM", true);
        showChapters = true;
    }

    public static void CloseCh1()
    {
        animator.SetBool("OpenChMM", false);
        showChapters = false;
    }
}
