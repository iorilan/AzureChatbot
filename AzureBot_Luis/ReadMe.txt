how to get luis key & model id?

1.login to luis portal :
https://www.luis.ai

2.create app , add intent , train.

3.login to azure portal . create web bot app -> grab keys

4.go to publish tab. add key (grab from azure portal)
scroll down, find a string something like (you may also use the starterKey):
https://westus.api.cognitive.microsoft.com/luis/v2.0/apps/{yourmodelId}?subscription-key={yourkey}&verbose=true&timezoneOffset=0&q=

5.put the key , model id in code :
[LuisModel(Constant.LuisModelId, Constant.LuisSubscribeKey)]
	public class YourLuisDialog : LuisDialog<object>
	{
	...
	}


----
why my key not working ?
try pass in the domain parameter 'your_region.api.cognitive.microsoft.com' into LuisDialog attribute


----
now you can add pre-trained intent or train your own from luis portal. only need to specify the name in luis dialog method. 
e.g.
	[LuisIntent("Music.PlayMusic")]
	[LuisIntent("MovieTickets.book")]
	[LuisIntent("Weather.GetForecast")]