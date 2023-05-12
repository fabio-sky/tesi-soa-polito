using RESTfulHTTPServer.src.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor;
using UnityEngine;
using static UnityEngine.Mesh;

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

            Debug.Log(json);

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
                        GameManager.Instance.WorldData.ThirdPerson = data.thirdPerson;

                        GameManager.Instance.HandleChangeParameters();

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

    }

}