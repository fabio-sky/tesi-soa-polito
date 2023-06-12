using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ServerMessages
{
    public const string GAMEMANAGER_NULL_ERR = "GameManager is NOT instanciated";
    public const string TEST_OK = "Server is up";
    public const string BROADCASTER_NOT_FOUND = "Server broadcaster not found";
    public const string MISSING_PARAMS = "Missing params";
    public const string FOLDER_NOT_FOUND = "Folder not found";
    public const string SEND_FILE_ERR = "Error sending zipped data";
    public const string HANDS_LOG_ALREADY_STARTED = "Hands logging already started";
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

public struct UpdateBooleanParametersProp
{
    public bool localMirror;
    public bool characterMirror;
    public bool rotationMirror;
}

public struct UpdateCameraViewProp
{
    public string camera;
}

public struct ResponseDataWithLPayload<T>
{
    public bool result;
    public string message;
    public List<T> data;
}

public struct ResponseData
{
    public bool result;
    public string message;
}

public struct StartSessionData
{
    public string  Name;
    public string Description;
    public string Identifier;
    public string CreatedAt;
}

public struct SessionData
{
    public string Name;
    public string Description;
    public string Identifier;
    public DateTime CreatedAt;
}

public struct UpdateSamplingProp
{
    public int position;
    public int log;
}
