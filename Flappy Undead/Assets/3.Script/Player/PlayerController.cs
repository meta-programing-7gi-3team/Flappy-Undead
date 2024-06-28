using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerController : MonoBehaviour
{
    public Player_Data data;
    public float Speed = 5f;
    public int Health = 2;

    public Rigidbody player_rid;
    public AudioSource player_au;

    public AudioClip jumpClip;
    public AudioClip hitClip;
    public AudioClip deathClip;

    private void Awake()
    {
        player_rid = GetComponent<Rigidbody>();
        player_au = GetComponent<AudioSource>();

        Speed = data.Speed;
        Health = data.Health;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }
    public void Jump()
    {
        player_rid.velocity = Vector3.up * Speed;
        player_au.PlayOneShot(jumpClip);
    }
    public void OnDamage()
    {
        Health--;
        if(Health <= 0)
        {
            Dead();
            return;
        }
        player_au.PlayOneShot(hitClip);
    }
    public void Dead()
    {
        player_au.PlayOneShot(deathClip);
    }
}