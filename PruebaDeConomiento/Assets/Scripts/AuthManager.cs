using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Auth;
using TMPro;
using UnityEngine.SceneManagement;

public class AuthManager : MonoBehaviour
{

    //Variables
    [Header("Firebase")]
    public DependencyStatus dependencyStatus;
    public FirebaseAuth auth;    
    public FirebaseUser User;

    //Variables de ingreso
    [Header("Ingreso")]
    public TMP_InputField emailLoginField;
    public TMP_InputField passwordLoginField;
    public TMP_Text warningLoginText;

    //Variables de registro
    [Header("Registro")]
    public TMP_InputField emailRegisterField;
    public TMP_InputField passwordRegisterField;
    public TMP_InputField passwordRegisterVerifyField;
    public TMP_Text warningRegisterText;

    void Awake()
    {
        //Verifica las dependencias de firebase
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            dependencyStatus = task.Result;
            if (dependencyStatus == DependencyStatus.Available)
            {
                //Si es correcto, inicia firebase
                InitializeFirebase();
            }
            else
            {
                Debug.LogError("Hubo un error al verificar las dependencias de firebase " + dependencyStatus);
            }
        });
    }

    private void InitializeFirebase()
    {
        Debug.Log("Iniciando autenticacion Firebase");
        //Inicializar la instancia del objeto para la autenticacion
        auth = FirebaseAuth.DefaultInstance;
    }

    //Boton de inicio de sesion
    public void LoginButton()
    {
        //Llama el email y la contraseña para el ingreso
        StartCoroutine(Login(emailLoginField.text, passwordLoginField.text));
    }
    
    //Boton de registro
    public void RegisterButton()
    {
        //Envía el email y la contraseña
        StartCoroutine(Register(emailRegisterField.text, passwordRegisterField.text));
    }

    private IEnumerator Login(string _email, string _password)
    {
        //Llama el autenticador para verificar el email y la contraseña
        var LoginTask = auth.SignInWithEmailAndPasswordAsync(_email, _password);
        //Espera a que la verificación termine
        yield return new WaitUntil(predicate: () => LoginTask.IsCompleted);

        if (LoginTask.Exception != null)
        {
            //Si hubo errores en la verificación 
            Debug.LogWarning(message: $"Falla en el registro de {LoginTask.Exception}");
            FirebaseException firebaseEx = LoginTask.Exception.GetBaseException() as FirebaseException;
            AuthError errorCode = (AuthError)firebaseEx.ErrorCode;

            string message = "Fallo en el ingreso!";
            switch (errorCode)
            {
                case AuthError.MissingEmail:
                    message = "Falta el email";
                    break;
                case AuthError.MissingPassword:
                    message = "Falta la contraseña";
                    break;
                case AuthError.WrongPassword:
                    message = "Error en la contraseña";
                    break;
                case AuthError.InvalidEmail:
                    message = "El email no existe";
                    break;
            }
            warningLoginText.text = message;
        }
        else
        {
            //El usuario ingresó
            User = LoginTask.Result;
            Debug.LogFormat("Ingresó correctamente: {0} ({1})", User.DisplayName, User.Email);
            SceneManager.LoadScene("PersonalizarPJ");
        }
    }


    private IEnumerator Register(string _email, string _password)
    {
        if (_email == "")
        {
            //Si el campo de email está vacío, salta la alerta
            warningRegisterText.text = "Falta el email";
        }
        else if(passwordRegisterField.text != passwordRegisterVerifyField.text)
        {
            //Si las contraseñas son diferentes, salta la alerta
            warningRegisterText.text = "!Las contraseñas no coinciden!";
        }
        else 
        {
            //Llama la función para registrar el email y la contraseña
            var RegisterTask = auth.CreateUserWithEmailAndPasswordAsync(_email, _password);
            //Espera a que el proceso termine
            yield return new WaitUntil(predicate: () => RegisterTask.IsCompleted);

            if (RegisterTask.Exception != null)
            {
                //Si hubo errores en el proceso
                Debug.LogWarning(message: $"Failed to register task with {RegisterTask.Exception}");
                FirebaseException firebaseEx = RegisterTask.Exception.GetBaseException() as FirebaseException;
                AuthError errorCode = (AuthError)firebaseEx.ErrorCode;

                string message = "!El registro falló!";
                switch (errorCode)
                {
                    case AuthError.MissingEmail:
                        message = "Falta el email";
                        break;
                    case AuthError.MissingPassword:
                        message = "Falta la contraseña";
                        break;
                    case AuthError.WeakPassword:
                        message = "Contraseña muy débil";
                        break;
                    case AuthError.EmailAlreadyInUse:
                        message = "El correo ya está en uso";
                        break;
                }
                warningRegisterText.text = message;
            }
            else
            {
                //Se creó el usuario correctamente
                User = RegisterTask.Result;

                if (User != null)
                {
                    //Crea un perfil a partir del correo
                    UserProfile profile = new UserProfile{DisplayName = _email};

                    //Actualiza la base de datos a partir del perfil del usuario
                    var ProfileTask = User.UpdateUserProfileAsync(profile);
                    //Espera a que termine el proceso
                    yield return new WaitUntil(predicate: () => ProfileTask.IsCompleted);

                    if (ProfileTask.Exception != null)
                    {
                        //Si hubo errores en el proceso
                        Debug.LogWarning(message: $"Fallo en el ingreso {ProfileTask.Exception}");
                        FirebaseException firebaseEx = ProfileTask.Exception.GetBaseException() as FirebaseException;
                        AuthError errorCode = (AuthError)firebaseEx.ErrorCode;
                        warningRegisterText.text = "!Fallo en el registro del perfil!";
                    }
                    else
                    {
                        //Perfil creado
                        SceneManager.LoadScene("PersonalizarPJ");
                        warningRegisterText.text = "";
                    }
                }
            }
        }
    }
}
