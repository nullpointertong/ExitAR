# ExitAR

## Project Dependencies

- Unity 2020.1.2f1
- Vuforia Engine 9.3.3
- VSCode (optional but highly recommended)

## Steps to Begin Development

0. Install VSCode
1. Download Unity Hub [here](https://unity3d.com/get-unity/download)
2. Install Unity via Unity Hub, ensuring that you have included the following modules:
   - Microsoft Visual Studio Community 2019
   - Android Build Support
     - Android SDK & NDK Tools
     - OpenJDK
3. Clone the repository, and add the `ExitAR` directory as a project in Unity Hub
4. Plug in an android device, enable [USB Debugging](https://www.embarcadero.com/starthere/xe5/mobdevsetup/android/en/enabling_usb_debugging_on_an_android_device.html) on your device if you have not done so
5. Navigate to File->Build Settings in Unity
6. In the Android->Run Device drop down menu, select you device. Hit refresh if it doesn't come up automatically.
7. Click `Build And Run` to run the application. Save the output .apk anywhere
