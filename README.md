App42_BPaaS_CSharp_SDK
================

App42 BPaaS Cloud API Client SDK for CSHARP

- Download the App42 BPaaS CSHARP SDK
- Unzip the file and open **App42 CSHARP Sample** project.
- Add the **App42_BPaaS_CSharp_SDK_x.x.x.dll** into refrence. (**Add Reference -> Select Your dll path)**
- Initialize the library using
```
ServiceAPI sp = new ServiceAPI("<YOUR_API_KEY>","<YOUR_SECRET_KEY>");
sp.SetBaseURL("<YOUR_API_SERVER_URL>");
```
- Instantiate the service that one wants to use in the App, e.g. using User service one has to do the following
```
UserService userService = sp.BuildUserService();
```

- Now one can call associated method of that service e.g. user creation can be done with the following snippet

```
String userName = "Nick";
String pwd = "********";
String emailId = "nick@shephertz.co.in";    
User user = userService.CreateUser(userName, pwd, emailId); 
Console.WriteLine("userName is " + user.GetUserName());
Console.WriteLine("emailId is " + user.GetEmail());
```

- Build the project and run.
