using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollarButton : MonoBehaviour {

    public ParticleSystem DollarParticle;

	public void JakiDebug()
    {
        Debug.Log("Dawaj kase biedaku");
        DollarParticle.Emit(1);
    }
}
