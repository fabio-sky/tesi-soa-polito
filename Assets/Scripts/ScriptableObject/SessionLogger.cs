using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;
using UnityEngine;



public class SessionLogger
{
    const string GENERAL_LOG_HEADER = "delta [ms] - action";
    const string GENERAL_LOG_FILE = "general.log";
    const string WORLD_LOG_HEADER = "delta [ms] - action - localMirror - characterMirror - rotationMirror - delay - camera";
    const string WORLD_LOG_FILE = "world.log";

    const string HAND_LOG_HEADER = "delta [ms] - realPosition (x,y,z) - userPosition (x,y,z)";
    const string RIGHT_HAND_LOG_FILE = "rightHand.log";
    const string LEFT_HAND_LOG_FILE = "leftHand.log";

    const string JSON_FILE = "session_data.json";
    const string MAIN_FOLDER = "SESSIONS_DATA";

    const string TIMESTAMP_FORMAT = "yyyy-MM-dd HH-mm-ss-fff zz";
    const string LOG_DELIMITER = " - ";


    private StreamWriter _leftHandWriter;
    private StreamWriter _rightHandWriter;

    private DateTime _referenceTime;

    #region Private Methods

    //START - END - RECORDING LOGS
    private string GenerateSessionStartLog()
    {
        return string.Concat((DateTime.Now - _referenceTime).TotalMilliseconds.ToString(), LOG_DELIMITER, SessionAction.SESSION_START);
    }

    private string GenerateSessionEndLog()
    {
        return string.Concat((DateTime.Now - _referenceTime).TotalMilliseconds.ToString(), LOG_DELIMITER, SessionAction.SESSION_END);
    }

    private string GenerateRecordinStartLog()
    {
        return string.Concat((DateTime.Now - _referenceTime).TotalMilliseconds.ToString(), LOG_DELIMITER, SessionAction.SESSION_START_RECORDING);
    }

    private string GenerateRecordinEndLog()
    {
        return string.Concat((DateTime.Now - _referenceTime).TotalMilliseconds.ToString(), LOG_DELIMITER, SessionAction.SESSION_STOP_RECORDING);
    }

    private void CreateSessionJsonFile(string dirPath)
    {

        SessionInfo data = GameManager.Instance.SessionInProgress;

        using (StreamWriter outputFile = new StreamWriter(Path.Combine(dirPath, JSON_FILE)))
        {
            outputFile.WriteLine(JsonConvert.SerializeObject(data));
        }
    }

    private string CreateSessionFolder()
    {
        string sessionId = GameManager.Instance.SessionInProgress.Identifier;
        string mainDirPath = Path.Combine(Application.persistentDataPath, MAIN_FOLDER);
        string sessionDirPath = Path.Combine(Application.persistentDataPath, MAIN_FOLDER, sessionId);

        if(!Directory.Exists(mainDirPath))
        {
            Directory.CreateDirectory(mainDirPath);
        }

        Directory.CreateDirectory(sessionDirPath);

        return sessionDirPath;
    }


    //WORDL PARAMS
    private string GenerateWorldParamsLog()
    {
        WorldData world = GameManager.Instance.WorldData;

        return string.Concat((DateTime.Now - _referenceTime).TotalMilliseconds.ToString(), LOG_DELIMITER, SessionAction.WORLD_UPDATE, LOG_DELIMITER, world.LocalMirror, LOG_DELIMITER, world.CharacterMirror, LOG_DELIMITER,world.RotationMirror, LOG_DELIMITER, world.Delay, LOG_DELIMITER, world.CameraView);
    }

    private string GenerateHandLog(DateTime time, Vector3 real, Vector3 user)
    {
        return string.Concat((time - _referenceTime).TotalMilliseconds.ToString(), LOG_DELIMITER, real.ToString("F3"), LOG_DELIMITER, user.ToString("F3"));
    }

    #endregion

    #region Public Methods

    public void LogInitSession()
    {
        string sessionId = GameManager.Instance.SessionInProgress.Identifier;

        if (string.IsNullOrEmpty(sessionId))
        {
            Debug.LogError("No SESSION IN PROGRESS found");
            return;
        }

        _referenceTime = DateTime.Now;

        string dirPath = CreateSessionFolder();

        Debug.Log(dirPath);
        Debug.Log(GENERAL_LOG_HEADER);
        Debug.Log(GenerateSessionStartLog());

        CreateSessionJsonFile(dirPath);

        using (StreamWriter outputFile = new StreamWriter(Path.Combine(dirPath, GENERAL_LOG_FILE), true))
        {
            outputFile.WriteLine(string.Concat("## Reference DATE and TIME: " + _referenceTime.ToString(TIMESTAMP_FORMAT) + "\n", "## SESSION ID: " + sessionId, "\n\n", GENERAL_LOG_HEADER));
            outputFile.WriteLine(GenerateSessionStartLog());    
        }


    }

    public void LogEndSession()
    {
        string sessionId = GameManager.Instance.SessionInProgress.Identifier;

        if (string.IsNullOrEmpty(sessionId))
        {
            Debug.LogError("No SESSION IN PROGRESS found");
            return;
        }

        string filePath = Path.Combine(Application.persistentDataPath, MAIN_FOLDER, sessionId, GENERAL_LOG_FILE);


        if(File.Exists(filePath))
        {
            using (StreamWriter outputFile = new StreamWriter(filePath, true))
            {
                outputFile.WriteLine(GenerateSessionEndLog());
            }
        }
        else
        {
            Debug.LogError("General session log file not found");
        }

        
    }



    public void LogWorldUpdate()
    {
        string sessionId = GameManager.Instance.SessionInProgress.Identifier;

        if (string.IsNullOrEmpty(sessionId))
        {
            Debug.LogError("No SESSION IN PROGRESS found");
            return;
        }

        string filePath = Path.Combine(Application.persistentDataPath, MAIN_FOLDER, sessionId, WORLD_LOG_FILE);



        if (!File.Exists(filePath))
        {
            using (StreamWriter outputFile = new StreamWriter(filePath, true))
            {
                outputFile.WriteLine(string.Concat("## Reference DATE and TIME: " + _referenceTime.ToString(TIMESTAMP_FORMAT) + "\n", "## SESSION ID: " + sessionId + "\n\n", WORLD_LOG_HEADER));
                outputFile.WriteLine(GenerateWorldParamsLog());
            }
        }
        else
        {
            using (StreamWriter outputFile = new StreamWriter(filePath, true))
            {
                outputFile.WriteLine(GenerateWorldParamsLog());
            }
        }


    }

    public void LogHandRecordingStartEnd(bool isStart)
    {
        string sessionId = GameManager.Instance.SessionInProgress.Identifier;

        if (string.IsNullOrEmpty(sessionId))
        {
            Debug.LogError("No SESSION IN PROGRESS found");
            return;
        }

        string filePath = Path.Combine(Application.persistentDataPath, MAIN_FOLDER, sessionId, GENERAL_LOG_FILE);

        if (File.Exists(filePath))
        {
            using (StreamWriter outputFile = new StreamWriter(filePath, true))
            {
                if(isStart)
                {
                    outputFile.WriteLine(GenerateRecordinStartLog());
                }
                else outputFile.WriteLine(GenerateRecordinEndLog());
            }
        }

    }



    // HAND POSITION LOG

    public void StartHandLog()
    {
        string sessionId = GameManager.Instance.SessionInProgress.Identifier;
        bool fileExist;

        if (string.IsNullOrEmpty(sessionId))
        {
            Debug.LogError("No SESSION IN PROGRESS found");
            return;
        }

        string rightFilePath = Path.Combine(Application.persistentDataPath, MAIN_FOLDER, sessionId, RIGHT_HAND_LOG_FILE);
        string leftFilePath = Path.Combine(Application.persistentDataPath, MAIN_FOLDER, sessionId, LEFT_HAND_LOG_FILE);

        fileExist = File.Exists(rightFilePath);

        _leftHandWriter = new StreamWriter(leftFilePath, true);
        _rightHandWriter= new StreamWriter(rightFilePath, true);

        if(!fileExist)
        {
            _rightHandWriter.WriteLine(string.Concat("## Reference DATE and TIME: " + _referenceTime.ToString(TIMESTAMP_FORMAT) , "\n", "## SESSION ID: " + sessionId,"\n", "## RIGHT HAND ", "\n\n", HAND_LOG_HEADER));

            _leftHandWriter.WriteLine(string.Concat("## Reference DATE and TIME: " + _referenceTime.ToString(TIMESTAMP_FORMAT), "\n", "## SESSION ID: " + sessionId, "\n", "## LEFT HAND ", "\n\n", HAND_LOG_HEADER));
        }

        LogHandRecordingStartEnd(true);

    }

    public void StopHandLog()
    {
        //_leftHandWriter?.Flush();
        _leftHandWriter?.Close();

       // _rightHandWriter?.Flush();
        _rightHandWriter?.Close();

        LogHandRecordingStartEnd(false);

    }

    public void LogHandPosition(Vector3 leftReal, Vector3 leftUser, Vector3 rightReal, Vector3 rightUser)
    {
        DateTime time = DateTime.Now;
        _leftHandWriter?.WriteLine(GenerateHandLog(time, leftReal, leftUser));
        _rightHandWriter?.WriteLine(GenerateHandLog(time, rightReal, rightUser));
    }





    // FOLDERS MANAGEMENT
    public List<SessionData> GetSessionsDataSaved()
    {
        string mainPath = Path.Combine(Application.persistentDataPath, MAIN_FOLDER);
        string[] directories = Directory.GetDirectories(mainPath);

        List<SessionData> sessions = new();

        foreach (string dirName in directories)
        {
            Debug.Log("DIRNAME: " + dirName);
            string fileContent = File.ReadAllText(Path.Combine(mainPath, dirName, JSON_FILE));
            Debug.Log(fileContent);
            SessionData s = JsonConvert.DeserializeObject<SessionData>(fileContent);
            Debug.Log(s.ToString());

            sessions.Add(s);
        }

        return sessions;
    }

    public bool DeleteFolder(string sessionId)
    {
        bool found = false;
        string mainPath = Path.Combine(Application.persistentDataPath, MAIN_FOLDER);
        string[] directories = Directory.GetDirectories(mainPath);


        foreach (string dirName in directories)
        {
            if(string.Compare(dirName, Path.Combine(mainPath, sessionId)) == 0)
            {
                found = true;
                File.Delete(Path.Combine(mainPath, sessionId, GENERAL_LOG_FILE));
                File.Delete(Path.Combine(mainPath, sessionId, WORLD_LOG_FILE));
                File.Delete(Path.Combine(mainPath, sessionId, JSON_FILE));
                File.Delete(Path.Combine(mainPath, sessionId, RIGHT_HAND_LOG_FILE));
                File.Delete(Path.Combine(mainPath, sessionId, LEFT_HAND_LOG_FILE));
                Directory.Delete(Path.Combine(mainPath, sessionId));
            }   
        }

        return found;
    }

    public bool ZipFolderSession(string sessionId)
    {
        try
        {
            string folderToZip  = Path.Combine(Application.persistentDataPath, MAIN_FOLDER, sessionId);
            string zippedContent = Path.Combine(Application.persistentDataPath, MAIN_FOLDER, sessionId + "_DATA.zip");

            if(File.Exists(zippedContent))
            {
                File.Delete(zippedContent);
            }

            ZipFile.CreateFromDirectory(folderToZip, zippedContent, System.IO.Compression.CompressionLevel.Optimal, true);

            return true;
        }
        catch (Exception)
        {
            return false;
        }
        
    }

    /// <summary>
    /// Send session DATA through a TCP channel
    /// </summary>
    /// <param name="sessionId"></param>
    /// <param name="sendTo"></param>
    /// <returns></returns>
    public bool SendFileZipped(string sessionId, string sendTo)
    {

        Debug.Log("Send file to: " + sendTo);

        bool fileSent = false;
        try
        {
            string filePath = Path.Combine(Application.persistentDataPath, MAIN_FOLDER, sessionId + "_DATA.zip");

            FileInfo info = new(filePath);


            TcpClient client = new(sendTo, 5050);
            StreamWriter streamInfo = new(client.GetStream());

            streamInfo.WriteLine(info.Length);
            streamInfo.Flush();
            streamInfo.Close();

            client.Close();

            client = new(sendTo, 5055);

            Stream streamFile = client.GetStream();

            byte[] fileBytes = File.ReadAllBytes(filePath);

            streamFile.Write(fileBytes, 0, fileBytes.Length);
            streamFile.Close();
            client.Close();

            File.Delete(filePath);

            fileSent = true;
        }
        catch(Exception e)
        {
            Debug.LogException(e);
        }

        return fileSent;
    }

    #endregion


    enum SessionAction
    {
        SESSION_START,
        SESSION_END,
        SESSION_START_RECORDING,
        SESSION_STOP_RECORDING,

        WORLD_UPDATE,
        WORLD_CAMERA_UPDATE
    }
}
