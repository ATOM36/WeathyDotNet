# WeathyDotNet

---
<p>
  A simple CLI tool built on top of .NET Core 6 and C#.<br/>
  Use it in order to get the weather in a specific city using <a href="https://openweathermap.org/" _target="blank">OpenWeather</a> API.
</p>

---
# Installation
After cloning the project, follow these steps for installation:
- First of all, you must have  <a href="https://dotnet.microsoft.com/en-us/download">***.NET SDK***</a> installed on your local machine.
- You must have a valid <a href="https://openweathermap.org/" _target="blank">OpenWeather</a> API key in order to have successful requests.
- After that you can edit the ***program.cs*** file and replace ***YOUR_API_KEY*** with the API key that you got from <a href="https://openweathermap.org/" _target="blank">OpenWeather</a>.
- After that, save changes and use the command ***dotnet pack*** to build the tool.
- Then use the command ***dotnet tool install --global --add-source ./nupkg WeathyDotNet*** to install it.<br/>
PS: Add the ***--global*** flag for a global installation.

---
# Usage

Simple open your terminal and type ***weathy <city_name>*** to get the weather in the specified city.<br/>
You can also type ***weathy*** and after that, you will be prompted to provide a city name.
  
---
Updates will be provided later. Feel free to use it and I'm also open to any feedback.<br/>Thanks😁.
