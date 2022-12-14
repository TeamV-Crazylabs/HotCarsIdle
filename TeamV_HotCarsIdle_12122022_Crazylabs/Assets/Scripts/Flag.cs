using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    [SerializeField] ParticleSystem Dollar1Particle;
    [SerializeField] ParticleSystem Dollar5Particle;
    [SerializeField] ParticleSystem Dollar25Particle;
    [SerializeField] ParticleSystem Dollar125Particle;
    [SerializeField] ParticleSystem Dollar625Particle;
    [SerializeField] Animator cashAnim;
    private void OnCollisionEnter(Collision collision)
    {
        cashAnim.SetTrigger("Cash");

        if (collision.gameObject.layer == 10)
        {
            //1 dolar partcile play
            Money.totalDollars += 1;
            Dollar1Particle.Play();
        }
        else if (collision.gameObject.layer == 11)
        {
            //1 dolar partcile play
            Money.totalDollars += 5;
            Dollar5Particle.Play();
        }
        else if (collision.gameObject.layer == 12)
        {
            //1 dolar partcile play
            Money.totalDollars += 25;
            Dollar25Particle.Play();
        }
        else if (collision.gameObject.layer == 13)
        {
            //1 dolar partcile play
            Money.totalDollars += 125;
            Dollar125Particle.Play();
        }
        else if (collision.gameObject.layer == 14)
        {
            //1 dolar partcile play
            Money.totalDollars += 625;
            Dollar625Particle.Play();
        }
        
    }
    
    
}
