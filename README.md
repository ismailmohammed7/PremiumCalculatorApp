# Description
The Application performs the calculation of the premium based on the values entered by the user. 

# Backend Web API 
The project is developed in .NET Core WEB API version 6. It will require Visual Studio version 2022 as it may not fully supported in lower versions. To get Visual Studio 2019 to work with .NET 6 all you have to do is the following:

•	Install the .NET 6 SDK: https://dotnet.microsoft.com/download
•	Open your VS project that you want to switch to .NET 6
•	Build your project with .NET 5(+)
•	go into the project dir and find your project file: .csproj
•	open the project file in notepad or Notepad++, basically any txt editor and find the node: < TargetFramework>
•	If you built your project with .NET 5(+) it will read as: <TargetFramework>net5.0-windows</TargetFramework>
•	Simply switch the value to: net6.0-windows 5 changed to 6
•	Your TargetFramework entry should be edited to: < TargetFramework>net6.0-windows</ TargetFramework>
•	Now save your project file
•	Next simply boot up Visual Studio 2019 and the target project you just modified to run .NET 6.
•	Do a clean on your project under the [ Build ] menu item
•	Now re-build your project and you are good to go


Post build and launch, the api endpoint can be tested by providing the required query params in both http and https urls present in the launch settings.

Backend url to fetch the OK success response: https://{baseApiurl}/premiumCalculator?occupation={occupation}&age={age}&amount={amount} 

# ClientUIApplication 
The UI Front end project developed in Angular 14 version. It assumes the latest npm installed along with the Visual Code Software. Run 'npm install' to install the required packages post cloning.
Please note to make sure the api url is pointing to the correct api base url of the running local instance of the Backend in the premiumcalculatorservice.ts file.

In case you encounter running scripts disabled error, run the below powershell command to remove restriction
Set-ExecutionPolicy -Scope CurrentUser -ExecutionPolicy Unrestricted
