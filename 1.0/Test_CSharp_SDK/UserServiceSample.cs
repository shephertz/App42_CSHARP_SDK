using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.shephertz.app42.paas.sdk.csharp;
using com.shephertz.app42.paas.sdk.csharp.user;


namespace Test_CSharp_SDK
{
    class UserServiceSample
    {
        ///<summary> 
        ///Main Method To Create App42 User on Cloud.
        ///</summary>
        ///<param name=args>args</param>

        static void Main(string[] args)
        {
            CreateUser();
        }
        /// <summary>
        /// Test Method for creating the User in App42 Cloud. 
        /// </summary>
        public static void CreateUser()
        {
            /// Enter your Public Key and Private Key Here in Constructor. You can
            /// get it once you will create a app in app42 console.

            ServiceAPI sp = new ServiceAPI("YOUR_API_KEY","YOUR_SECRET_KEY");
            sp.SetBaseURL("YOUR API SERVER URL");
            /// Create Instance of User Service
            UserService userService = sp.BuildUserService();
            /// Create user or call other available method on the user service
            /// reference
            try
            {
                User user = userService.CreateUser("Your User Name","Your PassWord","Your EmailId");
                Console.WriteLine("Your UserName is " + user.GetUserName());
                Console.WriteLine("Your Password is " + user.GetEmail());
            }
            catch (App42BadParameterException ex)
            {

                /// Exception Caught
                /// Check if User already Exist by checking app error code
                if (ex.GetAppErrorCode() == 2001)
                {
                    Console.WriteLine("App42BadParameterException : " + ex.GetAppErrorCode());
                    /// Do exception Handling for Already created User.
                }
                if (ex.GetAppErrorCode() == 2005)
                {
                    Console.WriteLine("App42BadParameterException : " + ex.GetAppErrorCode());
                    /// Do exception Handling for Already created User.
                }

            }
            catch (App42SecurityException ex)
            {
                /// Exception Caught
                /// Check for authorization Error due to invalid Public/Private Key
                if (ex.GetAppErrorCode() == 1401)
                {
                    /// Do exception Handling here
                    Console.WriteLine("App42SecurityException : " + ex.GetAppErrorCode());
                }
            }
            catch (App42Exception ex)
            {
                Console.WriteLine("App42Exception : " + ex);
            }
            /// Render the object response. This will return the Successful created
            /// User response
        }
    }
}

