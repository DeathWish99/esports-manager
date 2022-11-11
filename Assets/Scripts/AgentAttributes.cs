using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentAttributes : MonoBehaviour
{
    public enum Roles
    {
        Top,
        Jungle,
        Mid,
        Bot,
        Support
    }

    public Roles mainRole;
    [Range(0, 20)]
    public int GameSense;
    [Range(0, 20)]
    public int GameKnowledge;
    [Range(0, 20)]
    public int Mechanics;
    [Range(0, 20)]
    public int Csing;
    [Range(0, 20)]
    public int LaneDominance;
    [Range(0, 20)]
    public int JunglePathing;
    [Range(0, 20)]
    public int Teamfighting;
    [Range(0, 20)]
    public int MapAwareness;
    [Range(0, 20)]
    public int Drafting;
    public Roles SelectRoleRandom()
    {
        return (Roles)Random.Range(0, 4);
    }

}
