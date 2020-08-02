using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;

public class BallAgentLogic : Agent
{

    Rigidbody rBody;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    public Transform target;
    public override void OnEpisodeBegin()
    {
        // Reset agent
        this.rBody.angularVelocity = Vector3.zero;
        this.rBody.velocity = Vector3.zero;
		Debug.Log("Reset transform");

        // Move target to a new spot
        //target.localPosition = new Vector3(12 + Random.value * 8, Random.value * 3, Random.value * 10 - 5);
        //target.position = new Vector3(29.27f + Random.value * 2, 17.35f + Random.value * 2, 32f + Random.value * 2);

		Vector3 realV = new Vector3(29.27f + Random.value * 2, 17.35f + Random.value * 2, 32f + Random.value * 2);
		Vector3 realVBall = new Vector3(20.44f, 11.584f, 31.15f);
		Vector3 fixedV = new Vector3(453.7077f, -0.9097576f, +220.1232f);
		target.position = Vector3.zero + fixedV + realV;
		this.transform.position = Vector3.zero + fixedV + realVBall;
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        // Target and Agent positions & Agent velocity
        sensor.AddObservation(target.position);
        sensor.AddObservation(this.transform.position);
        sensor.AddObservation(rBody.velocity);
    }


    public float speed = 20;
    public override void OnActionReceived(float[] vectorAction)
    {
        Vector3 controlSignal = Vector3.zero;
        controlSignal.x = vectorAction[0];

        if (vectorAction[1] == 2)
        {
            controlSignal.z = 1;
        }
        else
        {
            controlSignal.z = -vectorAction[1];
        }

        // Prevent adding forces after jumping
        //if (this.transform.localPosition.x < 8.5)
        if (this.transform.position.x < 25)
        {
            rBody.AddForce(controlSignal * speed);
        }

        float distanceToTarget = Vector3.Distance(this.transform.position, target.position);
        // Reached target
        if (distanceToTarget < 1.42f)
        {
            SetReward(1.0f);
            EndEpisode();
        }

        // Fell of platform
        if (this.transform.position.y < 0)
        {
            EndEpisode();
        }
    }

    public override void Heuristic(float[] actionsOut)
    {
        actionsOut[0] = Input.GetAxis("Vertical");
        actionsOut[1] = Input.GetAxis("Horizontal");
    }

}

