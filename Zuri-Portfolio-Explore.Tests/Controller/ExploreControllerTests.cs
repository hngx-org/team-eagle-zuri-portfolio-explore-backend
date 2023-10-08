﻿using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuri_Portfolio_Explore.Controllers;
using Zuri_Portfolio_Explore.Domains.DTOs.Response;
using Zuri_Portfolio_Explore.Repository.Interfaces;

namespace Zuri_Portfolio_Explore.Tests.Controller
{
    public class ExploreControllerTests
    {
        private readonly IPortfolioService _portfolioService;

        public ExploreControllerTests()
        {
            _portfolioService = A.Fake<IPortfolioService>();
        }

        [Fact]
        public async void Explore_GetPortfolios_ReturnOk()
        {
            //Arrange
            var fPortfolioService = A.Fake<IPortfolioService>();
            var fPortfolios = A.Fake<List<PortfolioResponse>>();

            A.CallTo(() => fPortfolioService.GetAllPortfolios()).Returns(Task.FromResult(new ApiResponse<List<PortfolioResponse>>
            {
                 Data = fPortfolios,
                 IsSuccessful = true,
                 Message = "OK",
                 StatusCode = 200
            }));

            var controller = new ExploreController(fPortfolioService);

            //Act
            var result = await controller.GetAllPortfolio();

            //Assertions
            result.Should().NotBeNull().And.BeOfType<OkObjectResult>();  
        }
    }
}