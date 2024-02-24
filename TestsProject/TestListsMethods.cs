using DustyPig.TMDB.Models.Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestsProject;

[TestClass]
public class TestListsMethods
{
	[TestMethod]
	[DoNotParallelize]
	public async Task AddMovieAsync()
	{
		//MediaIdObject postData = ;
		//int listId = ;
		//string sessionId = ;

		//await ClientFactory.GetClient().Endpoints.Lists.AddMovieAsync(postData, listId, sessionId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetCheckItemStatusAsync()
	{
		//int listId = ;
		string language = "en-US";
		int? movieId = null;

		//await ClientFactory.GetClient().Endpoints.Lists.GetCheckItemStatusAsync(listId, language, movieId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task ClearAsync()
	{
		//int listId = ;
		//Boolean confirm = ;
		//string sessionId = ;

		//await ClientFactory.GetClient().Endpoints.Lists.ClearAsync(listId, confirm, sessionId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task CreateAsync()
	{
		//CreateRequest postData = ;
		//string sessionId = ;

		//await ClientFactory.GetClient().Endpoints.Lists.CreateAsync(postData, sessionId);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task GetDetailsAsync()
	{
		//int listId = ;
		int page = 1;
		string language = "en-US";

		//await ClientFactory.GetClient().Endpoints.Lists.GetDetailsAsync(listId, page, language);
	}



	[TestMethod]
	[DoNotParallelize]
	public async Task RemoveMovieAsync()
	{
		//MediaIdObject postData = ;
		//int listId = ;
		//string sessionId = ;

		//await ClientFactory.GetClient().Endpoints.Lists.RemoveMovieAsync(postData, listId, sessionId);
	}
}
