using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static UnityEngine.Mesh;

public class NetworkConnectionManager : MonoBehaviour
{

    [SerializeField] int PORT = 8080;

    const string REQUEST_DELIMITER = "##";

    Socket _socketListener;
    IPEndPoint _endPoint;

    // Start is called before the first frame update
    void Start()
    {
        InitServer();
    }

    void InitServer()
    {
        IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
        Debug.Log(Dns.GetHostName() +" | " + JsonUtility.ToJson(ipHost.AddressList[0]));
        IPAddress ipAddr = ipHost.AddressList[0];
        //IPAddress ipAddr = IPAddress.Parse("192.168.4.174");
        _endPoint = new IPEndPoint(ipAddr, PORT);

        _socketListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        _socketListener.Bind(_endPoint);
        _socketListener.Listen(5);

        GameManager.Instance.DEBUG_AddToLog("NETWORK MANAGER: START LISTENING FOR CLIENTS | " + _endPoint);

        _ = ListenForClientsAsync();

    }

    async Task ListenForClientsAsync()
    {
        try
        {
            while (true)
            {
                Debug.Log("waiting for connections");
                Socket clientSocket = await _socketListener.AcceptAsync();
                Debug.Log("connection accepted: " + clientSocket.RemoteEndPoint);

                byte[] bytes = new byte[1024];
                string data = null;

                while (true)
                {

                    int numByte = clientSocket.Receive(bytes);

                    Debug.Log("numByte: " + numByte);

                    data += Encoding.ASCII.GetString(bytes,
                                                   0, numByte);

                    Debug.Log("data: " + data);

                    if (data.IndexOf("<EOF>") > -1)
                        break;
                }

                string response = HandleClient(data.Replace("<EOF>", ""));

                Debug.Log("response: " + response);

                byte[] message = Encoding.ASCII.GetBytes(string.Concat(response, "<EOF>"));

                clientSocket.Send(message);
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();

            }
        }
        catch (Exception e)
        {
            Debug.LogError("NETWORK MANAGER: " + e.Message);
        }

       return;
    }


    string HandleClient(string request)
    {

        Debug.Log("REQUEST: " + request);

        

        if (GameManager.Instance == null)
        {
            ResponseData respErr = new();
            respErr.result = false;
            respErr.message = ServerMessages.GAMEMANAGER_NULL_ERR;

            return JsonConvert.SerializeObject(respErr);
        }


        string[] data = request.Split(REQUEST_DELIMITER);

        ActionCode code;

        if(!Enum.TryParse(data[0], out code))
        {
            code = ActionCode.INVALID_CODE;
        }



        try
        {
            switch (code)
            {
                case ActionCode.INVALID_CODE:
                    ResponseData respInvalidCode = new();
                    respInvalidCode.result = false;
                    respInvalidCode.message = ServerMessages.INVALID_ACTION;
                    return JsonConvert.SerializeObject(respInvalidCode);

                case ActionCode.TEST_CONNECTION:
                    return JsonConvert.SerializeObject(HandleTestConnection());

                case ActionCode.BUTTON_POSITION:
                    return JsonConvert.SerializeObject(HandleButtonPosition(JsonConvert.DeserializeObject<UpdateButtonPositionData>(data[1])));

                case ActionCode.MOVE_BUTTON:
                    return JsonConvert.SerializeObject(HandleMoveButtonPosition(JsonConvert.DeserializeObject<UpdateCameraPositionData>(data[1])));


                case ActionCode.TABLE_DIMENSIONS:
                    return JsonConvert.SerializeObject(HandleTableDimensions(JsonConvert.DeserializeObject<UpdateTableDimensionData>(data[1])));

                case ActionCode.TABLE_POSITION:
                    return JsonConvert.SerializeObject(HandleTablePosition(JsonConvert.DeserializeObject<UpdateTablePositionData>(data[1])));

                case ActionCode.CAMERA_USER_POSITION:
                    return JsonConvert.SerializeObject(HandleUserCameraPosition(JsonConvert.DeserializeObject<UpdateCameraPositionData>(data[1])));

                case ActionCode.START_SESSION:
                    Debug.Log("START SESSION DATA: " + data[0] + " | " + data[1]);
                    return JsonConvert.SerializeObject(HandleStartSession(JsonConvert.DeserializeObject<StartSessionData>(data[1])));
                    
                case ActionCode.GET_SESSIONS_LIST:
                    return JsonConvert.SerializeObject(HandleGetSessionsList());

                case ActionCode.ENABLE_SESSION:
                    return JsonConvert.SerializeObject(HandleEnableSession());

                case ActionCode.FORCE_END_SESSION:
                    return JsonConvert.SerializeObject(HandleEndSession());

                case ActionCode.DELETE_SESSION:
                    return JsonConvert.SerializeObject(HandleDeleteSession(JsonConvert.DeserializeObject<UpdateStringProp>(data[1])));

                case ActionCode.DOWNLOAD_SESSION:
                    return JsonConvert.SerializeObject(HandleDownloadSession(JsonConvert.DeserializeObject<DownloadSessionProp>(data[1])));
            }
        }
        catch (Exception e)
        {
            ResponseData respErr = new();
            respErr.result = false;
            respErr.message = e.Message;
            return JsonConvert.SerializeObject(respErr);
        }

        ResponseData respData = new() { result = false, message = "Error processing the request" } ;
        return JsonConvert.SerializeObject(respData);
    }

    ResponseData HandleTestConnection()
    {
       return new()
        {
            result = true,
            message = "Server is up and running"
        };
    }

    ResponseData HandleButtonPosition(UpdateButtonPositionData data)
    {
        ResponseData respData = new();

        GameManager.Instance.WorldData.ButtonHorizontal = data.horizontal;
        GameManager.Instance.WorldData.ButtonVertical = data.vertical;

        GameObject broadcaster = GameObject.FindWithTag("Server");


        if (broadcaster != null)
        {
            broadcaster.GetComponent<Broadcaster>().BroadcastEvent();

            respData.result = true;
            respData.message = "Button updated";
        }
        else
        {
            respData.result = false;
            respData.message = ServerMessages.BROADCASTER_NOT_FOUND;
        }

        return respData;
    }

    ResponseData HandleTableDimensions(UpdateTableDimensionData data)
    {
        ResponseData respData = new();

        GameManager.Instance.WorldData.TableHeight = data.height;
        GameManager.Instance.WorldData.TableWidth = data.width;
        GameManager.Instance.WorldData.TableDepth = data.depth;

        GameObject broadcaster = GameObject.FindWithTag("Server");


        if (broadcaster != null)
        {
            broadcaster.GetComponent<Broadcaster>().BroadcastEvent();

            respData.result = true;
            respData.message = "Table updated";
        }
        else
        {
            respData.result = false;
            respData.message = ServerMessages.BROADCASTER_NOT_FOUND;
        }

        return respData;
    }

    ResponseData HandleTablePosition(UpdateTablePositionData data)
    {
        ResponseData respData = new();

        GameManager.Instance.MoveTable(data.direction);
        respData.result = true;
        respData.message = "Table position updated";

        return respData;
    }

    ResponseData HandleStartSession(StartSessionData data)
    {
        ResponseData respData = new();

        try
        {
            GameManager.Instance.StartNewSession(data);
            respData.result = true;
            respData.message = "Session [" + data.Identifier + "] started";
        }
        catch (Exception e)
        {
            respData.result = false;
            respData.message = e.Message;
        }

        return respData;
       
    }



    ResponseData HandleEndSession()
    {
        ResponseData respData = new();

        try
        {
            GameManager.Instance.EndSession();
            respData.result = true;
            respData.message = "Session ended";
        }
        catch (Exception e)
        {
            respData.result = false;
            respData.message = e.Message;
        }

        return respData;

    }

    ResponseData HandleEnableSession()
    {
        ResponseData respData = new();

        try
        {
            GameManager.Instance.EnableSession();
            respData.result = true;
            respData.message = "Session enabled";
        }
        catch (Exception e)
        {
            respData.result = false;
            respData.message = e.Message;
        }

        return respData;

    }

    ResponseData HandleUserCameraPosition(UpdateCameraPositionData data)
    {
        ResponseData respData = new();

        GameManager.Instance.MoveCamera(data.direction);
        respData.result = true;
        respData.message = "Camera position updated";

        return respData;
    }

    ResponseData HandleMoveButtonPosition(UpdateCameraPositionData data)
    {
        ResponseData respData = new();

        GameManager.Instance.MoveButton(data.direction);
        respData.result = true;
        respData.message = "Button position updated";

        return respData;
    }

    ResponseDataWithLPayload<SessionData> HandleGetSessionsList()
    {
        ResponseDataWithLPayload<SessionData> respData = new();

        respData.result = true;

        respData.data = GameManager.Instance.SessionLogger.GetSessionsDataSaved();

        return respData;
    }

    ResponseData HandleDeleteSession(UpdateStringProp data)
    {
        ResponseData respData = new();

        bool folderFound = GameManager.Instance.SessionLogger.DeleteFolder(data.value);
        respData.result = folderFound;
        respData.message = folderFound ? "Session ["+data.value+"] deleted" : ServerMessages.FOLDER_NOT_FOUND;

        return respData;
    }

    ResponseData HandleDownloadSession(DownloadSessionProp data)
    {
        ResponseData respData = new();

        bool folderFound = GameManager.Instance.SessionLogger.ZipFolderSession(data.sessionId);

        if (folderFound)
        {
            bool fileSent = GameManager.Instance.SessionLogger.SendFileZipped(data.sessionId, data.sendTo);

            if (fileSent)
            {
                respData.result = true;
            }
            else
            {
                respData.result = false;
                respData.message = ServerMessages.SEND_FILE_ERR;
            }
        }
        else
        {
            respData.result = false;
            respData.message = ServerMessages.FOLDER_NOT_FOUND;
        }

        return respData;
    }


    //ENUMS
    enum ActionCode
    {
        TEST_CONNECTION,
        START_SESSION,
        FORCE_END_SESSION,
        ENABLE_SESSION,
        GET_SESSIONS_LIST,

        BUTTON_POSITION,
        MOVE_BUTTON,
        TABLE_DIMENSIONS,
        TABLE_POSITION,
        CAMERA_USER_POSITION,

        DELETE_SESSION,
        DOWNLOAD_SESSION,


        INVALID_CODE,
    }

}
