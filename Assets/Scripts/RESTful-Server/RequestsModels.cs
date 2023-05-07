using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ServerMessages
{
    public const string GAMEMANAGER_NULL_ERR = "GameManager is NOT instanciated";
    public const string TEST_OK = "Server is up";
    public const string BROADCASTER_NOT_FOUND = "Server broadcaster not found";
}

public struct UpdateDelay
{
    public int delay;
}

public struct UpdateBooleanProp
{
    public bool value;
}

public struct UpdateIntProp
{
    public int value;
}

public struct UpdateParametersProp
{
    public int delay;
    public bool localMirror;
    public bool characterMirror;
    public bool rotationMirror;
    public bool thirdPerson;
}

public struct ResponseData
{
    public bool result;
    public string message;

    public new string ToString() { return "{\"result\":" + this.result + ", \"message\":\"" + this.message + "\"}"; }
}