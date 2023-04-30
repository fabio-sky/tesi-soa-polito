using RESTfulHTTPServer.src.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor;
using UnityEngine;

namespace RESTfulHTTPServer.src.invoker
{
    public class ServerInvoke
    {
        public static Response GetTest(Request request)
        {
            Response response = new();

            bool done = false;


            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                if (GameManager.Instance != null )
                {
                    //broadcaster.GetComponent<Broadcaster>().BroadcastEvent();

                    response.SetContent("{\"content\": \"SERVER IS UP\"}");
                    response.SetHTTPStatusCode((int)HttpStatusCode.OK);
                }
                else
                {
                    response.SetContent("{\"content\": \"GameManager non instanciated\"}");
                    response.SetHTTPStatusCode((int)HttpStatusCode.InternalServerError);
                }

                done = true;
                
                
            });

            while (!done) ;

            return response;
        }

        public static Response GetDelay(Request request)
        {
            Response response = new();

            bool done = false;


            response.SetMimeType(Response.MIME_CONTENT_TYPE_JSON);

            //TRIGGER EVENT
            UnityInvoker.ExecuteOnMainThread.Enqueue(() => {

                if (GameManager.Instance != null)
                {
                    response.SetContent("{\"delay\":"+ GameManager.Instance.WorldData.Delay.ToString() + "}");
                    response.SetHTTPStatusCode((int)HttpStatusCode.OK);
                }
                else
                {
                    response.SetContent("{\"content\": \"error\"}");
                    response.SetHTTPStatusCode((int)HttpStatusCode.InternalServerError);
                }

                done = true;


            });

            while (!done) ;

            return response;
        }

        public static Response SetDelay(Request request)
        {
            Response response = new();

            bool done = false;
            string json = request.GetPOSTData();

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

                        response.SetContent("{\"delay\":" + GameManager.Instance.WorldData.Delay.ToString() + "}");
                        response.SetHTTPStatusCode((int)HttpStatusCode.OK);
                    }
                    else
                    {
                        response.SetContent("{\"content\": \"error\"}");
                        response.SetHTTPStatusCode((int)HttpStatusCode.InternalServerError);
                    }
                }
                catch(Exception e)
                {
                    response.SetContent("{\"content\": \"Errore boh\"}");
                    response.SetHTTPStatusCode((int)HttpStatusCode.InternalServerError);
                }
                finally { done = true; }


            });

            while (!done) ;

            return response;
        }

        public static Response SetCharacterMirror(Request request)
        {
            Response response = new();

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

                        response.SetContent("{\"value\":" + GameManager.Instance.WorldData.CharacterMirror.ToString() + "}");
                        response.SetHTTPStatusCode((int)HttpStatusCode.OK);

                       // GameManager.Instance.ManageCharacterMirror();
                    }
                    else
                    {
                        response.SetContent("{\"content\": \"error\"}");
                        response.SetHTTPStatusCode((int)HttpStatusCode.InternalServerError);
                    }
                }
                catch (Exception e)
                {
                    response.SetContent("{\"content\": \"Errore boh\"}");
                    response.SetHTTPStatusCode((int)HttpStatusCode.InternalServerError);
                }
                finally { done = true; }


            });

            while (!done) ;

            return response;
        }
    }

}
