using System.Collections;
using UnityEngine;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.Networking;

public class EmailManager : MonoBehaviour
{
  
   // [SerializeField] TMPro.TextMeshProUGUI txtData;
    //[SerializeField] UnityEngine.UI.Button btnSubmit;
    [SerializeField] bool sendDirect;
    readonly string URL = "https://staging.interappusa.com/public/send_email";

    const string kReceiverEmailAddress = "onegreggybrady@gmail.com";
    //const string kReceiverEmailAddress = "jameelqureshi2013@gmail.com";
    

   

    public static bool bzb1=true, bzb2=true, bzb3=true, bzb4=true, Dad=true;

    

    public void SendEmail(string targetName)
    {
        Debug.Log("Sending Email");
        switch (targetName)
        {
            case "bzb1":
                if (bzb1)
                {
                    string message = "User At " + targetName;
                    StartCoroutine(PostSendEmailRequest(kReceiverEmailAddress,message,"Map Position Alert"));
                    bzb1 = false;
                }
                break;

            case "bzb2":
                if (bzb2)
                {
                    string message = "User At " + targetName;
                    StartCoroutine(PostSendEmailRequest(kReceiverEmailAddress, message, "Map Position Alert"));
                    bzb2 = false;
                }
                break;

            case "bzb3":
                if (bzb3)
                {
                    string message = "User At " + targetName;
                    StartCoroutine(PostSendEmailRequest(kReceiverEmailAddress, message, "Map Position Alert"));
                    bzb3 = false;
                }
                break;

            case "bzb4":
                if (bzb4)
                {
                    string message = "User At " + targetName;
                    StartCoroutine(PostSendEmailRequest(kReceiverEmailAddress, message, "Map Position Alert"));
                    bzb4 = false;
                }
                break;

            case "Dad":
                if (Dad)
                {
                    string message = "User At " + targetName;
                    StartCoroutine(PostSendEmailRequest(kReceiverEmailAddress, message, "Map Position Alert"));
                    Dad = false;
                }
                break;
        }


        
    }

    

    IEnumerator PostSendEmailRequest(string email, string text, string subject)
    {
        WWWForm form = new WWWForm();
        form.AddField("email", email);
        form.AddField("text", text);
        form.AddField("subject", subject);

        using (UnityWebRequest www = UnityWebRequest.Post(URL, form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Email Sent!");
            }
        }
    }


    
}
