using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Product Added";
        public static string ProductListed = "Product Listed";

        public static string ProductCountOfCategoryError = "Max Product Count is Reached In This Category";

        public static string ProductSameNameAlreadyExist = "Product Name already Exists";

        public static string ProductCategoryLimitExeeded = "Product Category Limit Exeeded";

        public static string AuthorizationDenied = "You are not Authorized";

        public static string UserRegistered = "User Registered";
        public static string UserNotFound = "User Not Found";
        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Successful Login";
        public static string UserAlreadyExists = "User Already Exists";
        public static string AccessTokenCreated = "Access Token Created";
    }
}
