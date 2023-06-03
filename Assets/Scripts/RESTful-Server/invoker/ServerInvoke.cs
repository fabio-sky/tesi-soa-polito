using RESTfulHTTPServer.src.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor;
using UnityEngine;
using Newtonsoft.Json;

namespace RESTfulHTTPServer.src.invoker
{
    public class ServerInvoke
    {
        public static Response GetTest(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;


            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                if (GameManager.Instance != null)
                {
                    //broadcaster.GetComponent<Broadcaster>().BroadcastEvent();

                    respData.result = true;
                    respData.message = ServerMessages.TEST_OK;
                }
                else
                {
                    respData.result = false;
                    respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                }

                response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                response.SetContent(JsonUtility.ToJson(respData));
                done = true;



            });

            while (!done) ;

            return response;
        }

        public static Response GetDelay(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;


            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                if (GameManager.Instance != null)
                {
                    respData.result = true;
                    respData.message = GameManager.Instance.WorldData.Delay.ToString();
                }
                else
                {
                    respData.result = false;
                    respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                }


                response.SetContent(JsonUtility.ToJson(respData));
                response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                done = true;



            });

            while (!done) ;

            return response;
        }

        public static Response SetDelay(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;
            string json = request.GetPOSTData();

            //Debug.Log(json);

            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                //GameObject broadcaster = GameObject.FindWithTag("Server");

                try
                {
                    UpdateDelay data = JsonUtility.FromJson<UpdateDelay>(json);

                    if (GameManager.Instance != null)
                    {

                        GameManager.Instance.WorldData.Delay = data.delay;

                        respData.result = true;
                        respData.message = GameManager.Instance.WorldData.Delay.ToString();

                        GameManager.Instance.LogChangeParams();

                        GameObject broadcaster = GameObject.FindWithTag("Server");
                        if (broadcaster != null) broadcaster.GetComponent<Broadcaster>().BroadcastAudioEvent();
                    }
                    else
                    {
                        respData.result = false;
                        respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                    }
                }
                catch (Exception e)
                {
                    respData.result = false;
                    respData.message = e.Message;
                }
                finally
                {
                    response.SetContent(JsonUtility.ToJson(respData));
                    response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                    done = true;
                }


            });

            while (!done) ;



            return response;
        }

        public static Response SetCharacterMirror(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;
            string json = request.GetPOSTData();

            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                //GameObject broadcaster = GameObject.FindWithTag("Server");

                try
                {
                    UpdateBooleanProp data = JsonUtility.FromJson<UpdateBooleanProp>(json);

                    if (GameManager.Instance != null)
                    {

                        GameManager.Instance.WorldData.CharacterMirror = data.value;

                        respData.result = true;
                        respData.message = GameManager.Instance.WorldData.CharacterMirror.ToString();


                        GameObject broadcaster = GameObject.FindWithTag("Server");
                        if (broadcaster != null) broadcaster.GetComponent<Broadcaster>().BroadcastAudioEvent();
                    }
                    else
                    {
                        respData.result = false;
                        respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                    }
                }
                catch (Exception e)
                {
                    respData.result = false;
                    respData.message = e.Message;
                }
                finally
                {
                    response.SetContent(JsonUtility.ToJson(respData));
                    response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                    done = true;
                }


            });

            while (!done) ;

            return response;
        }

        public static Response SetAllParameter(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;
            string json = request.GetPOSTData();

            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                try
                {
                    UpdateParametersProp data = JsonUtility.FromJson<UpdateParametersProp>(json);

                    if (GameManager.Instance != null)
                    {

                        GameManager.Instance.WorldData.CharacterMirror = data.characterMirror;
                        GameManager.Instance.WorldData.LocalMirror = data.localMirror;
                        GameManager.Instance.WorldData.Delay = data.delay;
                        //GameManager.Instance.WorldData.ThirdPerson = data.thirdPerson;


                        respData.result = true;

                        GameObject broadcaster = GameObject.FindWithTag("Server");
                        if (broadcaster != null) broadcaster.GetComponent<Broadcaster>().BroadcastAudioEvent();
                    }
                    else
                    {
                        respData.result = false;
                        respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                    }
                }
                catch (Exception e)
                {
                    respData.result = false;
                    respData.message = e.Message;
                    response.SetHTTPStatusCode((int)HttpStatusCode.InternalServerError);
                }
                finally
                {
                    response.SetContent(JsonUtility.ToJson(respData));
                    response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                    done = true;
                }


            });

            while (!done) ;



            return response;
        }

        public static Response SetAllBooleanParameter(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;
            string json = request.GetPOSTData();

            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                try
                {
                    UpdateBooleanParametersProp data = JsonUtility.FromJson<UpdateBooleanParametersProp>(json);

                    if (GameManager.Instance != null)
                    {

                        GameManager.Instance.WorldData.CharacterMirror = data.characterMirror;
                        GameManager.Instance.WorldData.LocalMirror = data.localMirror;
                        GameManager.Instance.WorldData.RotationMirror = data.rotationMirror;

                        GameManager.Instance.LogChangeParams();

                        respData.result = true;
                    }
                    else
                    {
                        respData.result = false;
                        respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                    }
                }
                catch (Exception e)
                {
                    respData.result = false;
                    respData.message = e.Message;
                    response.SetHTTPStatusCode((int)HttpStatusCode.InternalServerError);
                }
                finally
                {
                    response.SetContent(JsonUtility.ToJson(respData));
                    response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                    done = true;
                }


            });

            while (!done) ;

            return response;
        }

        public static Response SetTableHeight(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;
            string json = request.GetPOSTData();

            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                //GameObject broadcaster = GameObject.FindWithTag("Server");

                try
                {
                    UpdateIntProp data = JsonUtility.FromJson<UpdateIntProp>(json);

                    if (GameManager.Instance != null)
                    {

                        GameManager.Instance.WorldData.TableHeight = data.value;

                        GameObject broadcaster = GameObject.FindWithTag("Server");


                        if (broadcaster != null)
                        {
                            broadcaster.GetComponent<Broadcaster>().BroadcastEvent();

                            respData.result = true;
                            respData.message = GameManager.Instance.WorldData.TableHeight.ToString();
                        }
                        else
                        {
                            respData.result = false;
                            respData.message = ServerMessages.BROADCASTER_NOT_FOUND;
                        }


                    }
                    else
                    {
                        respData.result = false;
                        respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                    }
                }
                catch (Exception e)
                {
                    respData.result = false;
                    respData.message = e.Message;
                }
                finally
                {
                    response.SetContent(JsonUtility.ToJson(respData));
                    response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                    done = true;
                }


            });

            while (!done) ;

            return response;
        }

        public static Response StartSession(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;
            string json = request.GetPOSTData();

            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                //GameObject broadcaster = GameObject.FindWithTag("Server");

                try
                {
                    StartSessionData data = JsonUtility.FromJson<StartSessionData>(json);

                    if (GameManager.Instance != null)
                    {
                        GameManager.Instance.StartNewSession(data);
                        respData.result = true;
                    }
                    else
                    {
                        respData.result = false;
                        respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                    }
                }
                catch (Exception e)
                {
                    respData.result = false;
                    respData.message = e.Message;
                }
                finally
                {
                    response.SetContent(JsonUtility.ToJson(respData));
                    response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                    done = true;
                }


            });

            while (!done) ;

            return response;
        }

        public static Response EndSession(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;
            //string json = request.GetPOSTData();

            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                //GameObject broadcaster = GameObject.FindWithTag("Server");

                try
                {
                    if (GameManager.Instance != null)
                    {

                        GameManager.Instance.EndSession();
                        respData.result = true;


                    }
                    else
                    {
                        respData.result = false;
                        respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                    }
                }
                catch (Exception e)
                {
                    respData.result = false;
                    respData.message = e.Message;
                }
                finally
                {
                    response.SetContent(JsonUtility.ToJson(respData));
                    response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                    done = true;
                }


            });

            while (!done) ;

            return response;
        }


        public static Response SetCameraView(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;
            string json = request.GetPOSTData();

            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                //GameObject broadcaster = GameObject.FindWithTag("Server");

                try
                {
                    UpdateCameraViewProp data = JsonUtility.FromJson<UpdateCameraViewProp>(json);

                    if (GameManager.Instance != null)
                    {

                        if (data.camera == "FIRST") GameManager.Instance.WorldData.CameraView = WorldData.CameraViewType.FIRST;
                        else if (data.camera == "THIRD") GameManager.Instance.WorldData.CameraView = WorldData.CameraViewType.THIRD;
                        else if (data.camera == "FRONT") GameManager.Instance.WorldData.CameraView = WorldData.CameraViewType.FRONT;


                        GameManager.Instance.UpdateCameraView();
                        GameManager.Instance.LogChangeParams();

                        /*GameObject broadcaster = GameObject.FindWithTag("Server");


                        if (broadcaster != null)
                        {
                            broadcaster.GetComponent<Broadcaster>().BroadcastEvent();

                            respData.result = true;
                            respData.message = GameManager.Instance.WorldData.TableHeight.ToString();
                        }
                        else
                        {
                            respData.result = false;
                            respData.message = ServerMessages.BROADCASTER_NOT_FOUND;
                        }*/

                        respData.result = true;


                    }
                    else
                    {
                        respData.result = false;
                        respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                    }
                }
                catch (Exception e)
                {
                    respData.result = false;
                    respData.message = e.Message;
                }
                finally
                {
                    response.SetContent(JsonUtility.ToJson(respData));
                    response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                    done = true;
                }


            });

            while (!done) ;

            return response;
        }


        public static Response StartHandLog(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;
            //string json = request.GetPOSTData();

            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                //GameObject broadcaster = GameObject.FindWithTag("Server");

                try
                {
                    if (GameManager.Instance != null)
                    {
                        GameManager.Instance.StartHandLogging();
                        respData.result = true;
                    }
                    else
                    {
                        respData.result = false;
                        respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                    }
                }
                catch (Exception e)
                {
                    respData.result = false;
                    respData.message = e.Message;
                }
                finally
                {
                    response.SetContent(JsonUtility.ToJson(respData));
                    response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                    done = true;
                }


            });

            while (!done) ;

            return response;
        }

        public static Response StopHandLog(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;
            //string json = request.GetPOSTData();

            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                //GameObject broadcaster = GameObject.FindWithTag("Server");

                try
                {
                    if (GameManager.Instance != null)
                    {
                        GameManager.Instance.StopHandLogging();
                        respData.result = true;
                    }
                    else
                    {
                        respData.result = false;
                        respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                    }
                }
                catch (Exception e)
                {
                    respData.result = false;
                    respData.message = e.Message;
                }
                finally
                {
                    response.SetContent(JsonUtility.ToJson(respData));
                    response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                    done = true;
                }


            });

            while (!done) ;

            return response;
        }

        public static Response GetSessions(Request request)
        {
            Response response = new();
            ResponseDataWithLPayload<SessionData> respData = new();

            bool done = false;


            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                if (GameManager.Instance != null)
                {
                    respData.result = true;

                    respData.data = GameManager.Instance.SessionLogger.GetSessionsDataSaved();

                    Debug.Log("ARRAY LENGHT: " + respData.data.Count);
                }
                else
                {
                    respData.result = false;
                    respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                }


                response.SetContent(JsonConvert.SerializeObject(respData));
                response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                done = true;



            });

            while (!done) ;

            return response;
        }

        public static Response DeleteSession(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;
            //string json = request.GetPOSTData();
            string sessionId = request.GetQuery("sessionId");
            //Dictionary<string, string> requestaParams = request.GetParameters();

            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                try
                {
                    if (GameManager.Instance != null)
                    {

                        if (!string.IsNullOrEmpty(sessionId))
                        {
                            
                            bool folderFound = GameManager.Instance.SessionLogger.DeleteFolder(sessionId);
                            respData.result = folderFound;
                            respData.message = folderFound ? "" : ServerMessages.FOLDER_NOT_FOUND;
                        }
                        else
                        {
                            respData.result = false;
                            respData.message = ServerMessages.MISSING_PARAMS;
                        }

                    }
                    else
                    {
                        respData.result = false;
                        respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                    }
                }
                catch (Exception e)
                {
                    respData.result = false;
                    respData.message = e.Message;
                }
                finally
                {
                    response.SetContent(JsonUtility.ToJson(respData));
                    response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                    done = true;
                }


            });

            while (!done) ;

            return response;
        }

        public static Response DownloadSessionData(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;
            string sessionId = request.GetQuery("sessionId");
            string sendTo = request.GetQuery("sendTo");

            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                try
                {
                    if (GameManager.Instance != null)
                    {

                        if (!string.IsNullOrEmpty(sessionId) && !string.IsNullOrEmpty(sendTo))
                        {

                            bool folderFound = GameManager.Instance.SessionLogger.ZipFolderSession(sessionId);

                            if(folderFound)
                            {
                                bool fileSent = GameManager.Instance.SessionLogger.SendFileZipped(sessionId, sendTo);

                                if(fileSent)
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
                            
                        }
                        else
                        {
                            respData.result = false;
                            respData.message = ServerMessages.MISSING_PARAMS;
                        }

                    }
                    else
                    {
                        respData.result = false;
                        respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                    }
                }
                catch (Exception e)
                {
                    respData.result = false;
                    respData.message = e.Message;
                }
                finally
                {
                    response.SetContent(JsonUtility.ToJson(respData));
                    response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                    done = true;
                }


            });

            while (!done) ;

            return response;
        }


        public static Response MoveCamera(Request request)
        {
            Response response = new();
            ResponseData respData = new();

            bool done = false;
            //string json = request.GetPOSTData();
            string movement = request.GetQuery("movement");
            //Dictionary<string, string> requestaParams = request.GetParameters();

            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                try
                {
                    if (GameManager.Instance != null)
                    {

                        if (!string.IsNullOrEmpty(movement))
                        {

                            GameManager.Instance.MoveCamera(movement);
                            respData.result = true;
                        }
                        else
                        {
                            respData.result = false;
                            respData.message = ServerMessages.MISSING_PARAMS;
                        }

                    }
                    else
                    {
                        respData.result = false;
                        respData.message = ServerMessages.GAMEMANAGER_NULL_ERR;
                    }
                }
                catch (Exception e)
                {
                    respData.result = false;
                    respData.message = e.Message;
                }
                finally
                {
                    response.SetContent(JsonUtility.ToJson(respData));
                    response.SetHTTPStatusCode(respData.result ? (int)HttpStatusCode.OK : (int)HttpStatusCode.InternalServerError);
                    done = true;
                }


            });

            while (!done) ;

            return response;
        }
    }
}
