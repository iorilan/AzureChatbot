using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AzureBot_Luis.Models;

namespace AzureBot_Luis.Dialogs
{
	[Serializable]
	[LuisModel(Constant.LuisModelId, Constant.LuisSubscribeKey, domain: "southeastasia.api.cognitive.microsoft.com")]
	public class LanguageParseDialog : LuisDialog<object>
	{
		public LanguageParseDialog()
		{

		}
		public LanguageParseDialog(ILuisService service)
			: base(service)
		{
		}



		[LuisIntent("")]
		[LuisIntent("None")]
		public async Task None(IDialogContext context, LuisResult result)
		{
			var errorResult = "Try something else, please.";
			await context.PostAsync(errorResult);
			context.Wait(this.MessageReceived);
		}


		[LuisIntent("MovieTickets.book")]
		public async Task BookMovieTicket(IDialogContext context, LuisResult luisResult)
		{
			string response = string.Empty;
			response = "Do you want to book movie ticket ?";

			await context.PostAsync(response);
			context.Wait(this.MessageReceived);
		}

		[LuisIntent("Music.PlayMusic")]
		public async Task PlayMusic(IDialogContext context, LuisResult luisResult)
		{
			string response = string.Empty;
			response = "Do you want to play music?";

			await context.PostAsync(response);
			context.Wait(this.MessageReceived);
		}

		[LuisIntent("Weather.GetForecast")]
		public async Task Weather(IDialogContext context, LuisResult luisResult)
		{
			string response = string.Empty;


			//TODO link to weather
			response = "You want to know the weather?";

			await context.PostAsync(response);
			context.Wait(this.MessageReceived);
		}
	}
}