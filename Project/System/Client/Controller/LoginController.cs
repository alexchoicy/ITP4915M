﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Client.Helper;
using Client.Model.Receive;
using System.Xml.Linq;
using BCrypt.Net;

namespace Client.Controller
{
    public class LoginController
    {
        public async Task<string> Login(string username, string password)
        {
            var loginData = new {userID = username, password = password};
            var request = new RestRequest("/api/Login", Method.Post).AddJsonBody(loginData);
            Debug.WriteLine("Started," + username + " " + password);
            try
            {
                var userInfo = await ApiClient.client.ExecuteAsync(request);
                if (userInfo.StatusCode == HttpStatusCode.OK)
                {
                    var data = JsonDocument.Parse(userInfo.Content);
                    UserInformation userInfoData = new UserInformation
                    {
                        Token = "bearer " + data.RootElement.GetProperty("userToken").GetProperty("token").GetString(),
                        ExpireTime = data.RootElement.GetProperty("userToken").GetProperty("expire_time").GetDateTime(),
                        Name = data.RootElement.GetProperty("userData").GetProperty("name").GetString(),
                        StaffID = data.RootElement.GetProperty("userData").GetProperty("staffID").GetString(),
                        Position = data.RootElement.GetProperty("userData").GetProperty("postion").GetString(),
                        Department = data.RootElement.GetProperty("userData").GetProperty("dept").GetString(),
                        Remark = data.RootElement.GetProperty("userData").GetProperty("remark").GetString(),
                        address = data.RootElement.GetProperty("userData").GetProperty("address").GetString(),
                        RestaurantID = data.RootElement.GetProperty("userData").GetProperty("restaurantID").GetString()
                    };
                    GlobalData.UserInfo = userInfoData;
                    Debug.WriteLine(data.RootElement.GetProperty("userData").GetProperty("name").GetString());
                    return "Ok";
                }
                return userInfo.Content;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "Error";
            }

        }
    }
}
