# Description
The Application performs the calculation of the premium based on the values entered by the user. 

# Backend Web API 
The project is developed in .NET Core WEB API version 6. It will require Visual Studio version 2022 as it may not fully supported in lower versions. In which case, we will have to add target framework in csproj as below
<TargetFramework>net6.0</TargetFramework>
Post build and launch, the api endpoint can be tested by providing the required query params in both http and https urls present in the launch settings.

Backend url to fetch the OK success response: https://{baseApiurl}/premiumCalculator?occupation={occupation}&age={age}&amount={amount} 

# ClientUIApplication 
The UI Front end project developed in Angular 14 version. It assumes the latest npm installed along with the Visual Code Software. Run 'npm install' to install the required packages post cloning.
Please note to make sure the api url is pointing to the correct api base url of the running local instance of the Backend in the premiumcalculatorservice.ts file.

In case you encounter running scripts disabled error, run the below powershell command to remove restriction
Set-ExecutionPolicy -Scope CurrentUser -ExecutionPolicy Unrestricted
