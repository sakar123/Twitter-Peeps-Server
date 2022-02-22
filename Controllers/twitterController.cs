using TwitterServer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
namespace TwitterServer.Controllers;
[ApiController]
[Route("api/[controller]")]
public class twitterController: ControllerBase
{
    private readonly HttpClient httpClient;

    public HttpClient InitializeClient(){
        var BearerToken = _configuration["BearerToken"];

        var apiClient = new HttpClient();

        apiClient.DefaultRequestHeaders.Accept.Clear();

        apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        apiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", BearerToken);

        return apiClient;
    }
    private readoonly Iconfiguraiton 
    [HttpGet]
    public async Task<Int64> getUserIdFromUserName(string userName){

    }
    [HttpGet]
    public async Task<> getFollowersFromUserId(string userId){

    }
    //just helper functions below
    [HttpGet]
    public async Task<> getUserTrackMetaData(string userId){

    }
    public async Task<> getTenRecentFollowingsFromUserId(string userId){

    }
    //another helper function below
    public async Task<>getFiftyRecentlyLikedTweets(string userId){

    }
    public async Task<> getBio(string userId){

    }
}