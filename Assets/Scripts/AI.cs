using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;


public class AI : MonoBehaviour
{
    public NavMeshAgent agent;
    public float dis;
    public float disPlayer;
    private float waitTime = 5f;
    public float runTime;
    private Animator _animator;
    [SerializeField] private int numeroAseguir;
    [SerializeField] private List<GameObject> Targets = new List<GameObject>();



    // Start is called before the first frame update
    void Start()
    {
        runTime = waitTime;
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

      agent.SetDestination(Targets[numeroAseguir].transform.position);
      _animator.SetBool("Moving", true);

      dis = Vector3.Distance(transform.position, Targets[numeroAseguir].transform.position);
      if (dis < 17)
      {
         runTime -= Time.deltaTime;
         _animator.SetBool("Moving", false);
         if (runTime <= 0)
          {
           if (numeroAseguir == 0)
           {
             numeroAseguir++;
           }
           else
           {
             numeroAseguir--;
           }
           runTime = waitTime;
           _animator.SetBool("Moving", true);      
         }
      }
    }
       

}








