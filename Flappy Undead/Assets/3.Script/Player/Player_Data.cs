using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Player_Data : ScriptableObject
{
    public enum CharType
    {
        Normal,
        Witch,
        Axe,
        Horn
    }
    public CharType Type;
    public int Health;
    public float Speed;
    public float CoolTime;
}
