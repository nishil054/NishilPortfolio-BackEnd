﻿using System.Threading.Tasks;
using NishilPort.Models.TokenAuth;
using NishilPort.Web.Controllers;
using Shouldly;
using Xunit;

namespace NishilPort.Web.Tests.Controllers
{
    public class HomeController_Tests: NishilPortWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}