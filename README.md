# VintaSoft WinForms Image Scanning Demo

This WinForms project uses <a href="https://www.vintasoft.com/vstwain-dotnet-index.html">VintaSoft TWAIN .NET SDK</a> and demonstrates how to acquire images from TWAIN/WIA/eSCL image scanner in Windows.


## Screenshot
<img src="vintasoft-image-scanning-demo.png" title="VintaSoft Image Scanning Demo">


## Usage
1. Get the 30 day free evaluation license for <a href="https://www.vintasoft.com/vstwain-dotnet-index.html" target="_blank">VintaSoft TWAIN .NET SDK</a> here: <a href="https://myaccount.vintasoft.com/user/getEvaluationLicense" target="_blank">https://myaccount.vintasoft.com/user/getEvaluationLicense</a>

2. Update the evaluation license in "CSharp\MainForm.cs" file:
   ```
   Vintasoft.Twain.TwainGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");
   Vintasoft.WiaImageScanning.WiaGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");
   Vintasoft.EsclImageScanning.EsclGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");
   ```

3. Build the project ("ImageScanningDemo.Net10.csproj" file) in Visual Studio or using .NET CLI:
   ```
   dotnet build ImageScanningDemo.Net10.csproj
   ```

4. Run compiled application.


## Documentation
VintaSoft TWAIN .NET SDK on-line User Guide and API Reference for .NET developer is available here: https://www.vintasoft.com/docs/vstwain-dotnet/


## Support
Please visit our <a href="https://myaccount.vintasoft.com/">online support center</a> if you have any question or problem.
