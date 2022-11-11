using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateNewAgent : MonoBehaviour
{
    public GameObject agentPrefab;
    private AgentAttributes agentScript;
    // Start is called before the first frame update
    private void Awake()
    {
        agentScript = agentPrefab.GetComponent<AgentAttributes>();
    }
    void Start()
    {
        ExecuteGeneration();
    }

    private void ExecuteGeneration()
    {
        agentScript.mainRole = agentScript.SelectRoleRandom();
        if(agentScript.mainRole == AgentAttributes.Roles.Jungle)
        {
            GenerateJungleStats();
        }
        else if(agentScript.mainRole == AgentAttributes.Roles.Support)
        {
            GenerateSupportStats();
        }
        else
        {
            GenerateLanerStats();
        }

        Instantiate(agentPrefab);
    }

    private void GenerateLanerStats()
    {
        agentScript.JunglePathing = Random.Range(0, 5);
        agentScript.GameKnowledge = Random.Range(5, 20);
        agentScript.GameSense = Random.Range(5, 20);
        agentScript.Mechanics = Random.Range(5, 20);
        agentScript.LaneDominance = Random.Range(5, 20);
        agentScript.Csing = Random.Range(5, 20);
        agentScript.Teamfighting = Random.Range(5, 20);
        agentScript.MapAwareness = Random.Range(5, 20);
        agentScript.Drafting = Random.Range(0, 20);
    }
    private void GenerateJungleStats()
    {
        agentScript.JunglePathing = Random.Range(6, 20);
        agentScript.GameKnowledge = Random.Range(5, 20);
        agentScript.GameSense = Random.Range(5, 20);
        agentScript.Mechanics = Random.Range(5, 20);
        agentScript.LaneDominance = Random.Range(0, 5);
        agentScript.Csing = Random.Range(0, 5);
        agentScript.Teamfighting = Random.Range(5, 20);
        agentScript.MapAwareness = Random.Range(5, 20);
        agentScript.Drafting = Random.Range(0, 20);
    }

    private void GenerateSupportStats()
    {

        agentScript.JunglePathing = Random.Range(0, 5);
        agentScript.GameKnowledge = Random.Range(8, 20);
        agentScript.GameSense = Random.Range(8, 20);
        agentScript.Mechanics = Random.Range(5, 20);
        agentScript.LaneDominance = Random.Range(5, 20);
        agentScript.Csing = Random.Range(0, 5);
        agentScript.Teamfighting = Random.Range(5, 20);
        agentScript.MapAwareness = Random.Range(5, 20);
        agentScript.Drafting = Random.Range(0, 20);
    }
}
