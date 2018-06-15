install bot emulator https://github.com/Microsoft/BotFramework-Emulator/releases
install vs template 
https://marketplace.visualstudio.com/items?itemName=BotBuilder.botbuilderv3
or you can download the latest (this sample using v3)
https://marketplace.visualstudio.com/items?itemName=BotBuilder.botbuilderv4

1. you need to create a web bot from azure portal
2. grab the publish profile and deploy this app service
3. find the microsoft app id and secret at Resource->bot app-> application settings. put in web.config
4. test local host with bot simulator https://github.com/Microsoft/BotFramework-Emulator/releases
5. test with web test in at Resource -> bot app-> test in web chat
if it doesnt work , check :
a. if web config including microsoft app id and secret 
b. publish check 'Remove additional files at destination'
refer to this answer :
https://stackoverflow.com/questions/47853172/waiting-for-bot-to-be-ready-after-deployment?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa

---

steps to get html iframe :
resource ->web bot->channels -> direct line

---
where to grab MS app id and MS app password ?
resource group-> web bot -> application settings