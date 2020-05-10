using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class menuStart : MonoBehaviour
{
 public void Changemenuscene(string scenename)
 {
  Application.LoadLevel (scenename);
 }
}