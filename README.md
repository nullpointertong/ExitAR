# ExitAR

## Project Dependencies

- Unity 2020.1.2f1
- Vuforia Engine 9.3.3
- VSCode (optional but highly recommended)

## Steps to Begin Development

0. Install VSCode
1. Download Unity Hub [here](https://store.unity.com/download/thank-you?thank-you=personal&os=win&nid=1697)
2. Install Unity via Unity Hub, ensuring that you have included the following modules:
   - Microsoft Visual Studio Community 2019
   - Android Build Support
     - Android SDK & NDK Tools
     - OpenJDK
3. Clone the repository, and add the `ExitAR` directory as a project in Unity Hub
4. Add Vuforia Engine to Unity. Link is available [here](https://developer.vuforia.com/downloads/sdk). You will have to create an account and a [development key](https://developer.vuforia.com/vui/develop/licenses/free/new)
5. Once installed, Locate the Resources/VuforiaConfiguration file in the Project window inside Unity, and copy and paste your license key in the `App License Key` field.
6. Plug in an android device, enable [USB Debugging](https://www.embarcadero.com/starthere/xe5/mobdevsetup/android/en/enabling_usb_debugging_on_an_android_device.html) on your device if you have not done so
7. Navigate to File->Build Settings in Unity
8. In the Android->Run Device drop down menu, select you device. Hit refresh if it doesn't come up automatically.
9. Click `Build And Run` to run the application. Save the output .apk anywhere
