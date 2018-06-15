using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace AzureBot_Luis.Dialogs
{
	//[Serializable]
	//public class RootDialog : IDialog<object>
	//{
	//	public Task StartAsync(IDialogContext context)
	//	{
	//		context.Wait(MessageReceivedAsync);

	//		return Task.CompletedTask;
	//	}

	//	private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
	//	{
	//		var activity = await result as Activity;

	//		// Calculate something for us to return
	//		int length = (activity.Text ?? string.Empty).Length;

	//		// Return our reply to the user
	//		await context.PostAsync($"You sent {activity.Text} which was {length} characters");

	//		context.Wait(MessageReceivedAsync);
	//	}
	//}
	[Serializable]
	public class RootDialog : IDialog<object>
	{
		public Task StartAsync(IDialogContext context)
		{
			context.Wait(MessageReceivedAsync);

			return Task.CompletedTask;
		}

		private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
		{
			var activity = await result as Activity;
			await context.Forward(new LanguageParseDialog(), ResumeAftelLuisDialog, activity, CancellationToken.None);
		}

		private async Task ResumeAftelLuisDialog(IDialogContext context, IAwaitable<object> result)
		{
			context.Wait(MessageReceivedAsync);
		}
	}
}